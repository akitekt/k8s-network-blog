10.0.183.0/24 dev kube-bridge  proto kernel  scope link  src 10.0.183.1
10.0.184.0/24 via 101.202.7.67 dev eth0  proto 17
10.0.185.0/24 via 101.202.6.237 dev eth0  proto 17
10.0.186.0/24 via 101.202.7.200 dev eth0  proto 17
10.0.188.0/24 via 101.202.7.43 dev eth0  proto 17
10.0.195.0/24 dev tun-102050124  proto 17  src 101.202.7.202
10.0.196.0/24 dev tun-102051237  proto 17  src 101.202.7.202
10.0.230.0/24 dev tun-1020514194  proto 17  src 101.202.7.202
10.0.231.0/24 dev tun-1020514171  proto 17  src 101.202.7.202



root@ip-10-205-7-202:/home/pie# ip addr
1: lo: <LOOPBACK,UP,LOWER_UP> mtu 65536 qdisc noqueue state UNKNOWN group default qlen 1
    link/loopback 00:00:00:00:00:00 brd 00:00:00:00:00:00
    inet 127.0.0.1/8 scope host lo
       valid_lft forever preferred_lft forever
    inet6 ::1/128 scope host
       valid_lft forever preferred_lft forever
2: eth0: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 9001 qdisc mq state UP group default qlen 1000
    link/ether 0a:97:3e:7f:5f:fe brd ff:ff:ff:ff:ff:ff
    inet 101.202.7.202/23 brd 101.202.7.255 scope global eth0
       valid_lft forever preferred_lft forever
    inet6 fe80::897:3eff:fe7f:5ffe/64 scope link
       valid_lft forever preferred_lft forever
3: docker0: <NO-CARRIER,BROADCAST,MULTICAST,UP> mtu 1500 qdisc noqueue state DOWN group default
    link/ether 02:42:a4:2f:8f:27 brd ff:ff:ff:ff:ff:ff
    inet 172.17.0.1/16 scope global docker0
       valid_lft forever preferred_lft forever
4: kube-bridge: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1500 qdisc noqueue state UP group default qlen 1000
    link/ether 0a:58:0a:00:b7:01 brd ff:ff:ff:ff:ff:ff
    inet 10.0.183.1/24 scope global kube-bridge
       valid_lft forever preferred_lft forever
    inet6 fe80::a08f:7ff:fe16:a696/64 scope link
       valid_lft forever preferred_lft forever
5: veth982197a6@if3: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1500 qdisc noqueue master kube-bridge state UP group default
    link/ether 82:bf:d9:51:69:dc brd ff:ff:ff:ff:ff:ff link-netnsid 0
    inet6 fe80::80bf:d9ff:fe51:69dc/64 scope link
       valid_lft forever preferred_lft forever
6: veth0a383f08@if3: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1500 qdisc noqueue master kube-bridge state UP group default
    link/ether 2a:83:c8:76:ce:7a brd ff:ff:ff:ff:ff:ff link-netnsid 1
    inet6 fe80::2883:c8ff:fe76:ce7a/64 scope link
       valid_lft forever preferred_lft forever
7: tunl0@NONE: <NOARP> mtu 1480 qdisc noop state DOWN group default qlen 1
    link/ipip 0.0.0.0 brd 0.0.0.0
8: tun-10205467@eth0: <POINTOPOINT,NOARP,UP,LOWER_UP> mtu 8961 qdisc noqueue state UNKNOWN group default qlen 1
    link/ipip 101.202.7.202 peer 101.202.4.67
...






root@ip-10-205-7-202:/home/pie# iptables -L -t nat | grep -B 1 -A 4 -E 'KUBE-SVC-3C2I2DNJ4VWZY5PF|KUBE-SEP-P6JNEFEXMECE2WS6|KUBE-SEP-DX25GZBAXCASAQMI|KUBE-SEP-HI43CU4ZL6YUQHDB'

KUBE-MARK-MASQ  tcp  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ tcp dpt:30998
KUBE-SVC-3C2I2DNJ4VWZY5PF  tcp  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ tcp dpt:30998
--

Chain KUBE-SEP-DX25GZBAXCASAQMI (1 references)
target     prot opt source               destination
KUBE-MARK-MASQ  all  --  ip-10-0-11-27.ec2.internal  anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */
DNAT       tcp  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ tcp to:10.0.11.27:80

--

Chain KUBE-SEP-HI43CU4ZL6YUQHDB (1 references)
target     prot opt source               destination
KUBE-MARK-MASQ  all  --  ip-10-0-35-21.ec2.internal  anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */
DNAT       tcp  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ tcp to:10.0.35.21:80

--

Chain KUBE-SEP-P6JNEFEXMECE2WS6 (1 references)
target     prot opt source               destination
KUBE-MARK-MASQ  all  --  ip-10-0-11-26.ec2.internal  anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */
DNAT       tcp  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ tcp to:10.0.11.26:80

--
KUBE-MARK-MASQ  tcp  -- !ip-10-0-0-0.ec2.internal/16  ip-10-1-60-159.ec2.internal  /* performanceks1/performanceks1-external-ingress-controller:https cluster IP */ tcp dpt:https
KUBE-SVC-3C2I2DNJ4VWZY5PF  tcp  --  anywhere             ip-10-1-60-159.ec2.internal  /* performanceks1/performanceks1-external-ingress-controller:https cluster IP */ tcp dpt:https
--

Chain KUBE-SVC-3C2I2DNJ4VWZY5PF (2 references)
target     prot opt source               destination
KUBE-SEP-P6JNEFEXMECE2WS6  all  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ statistic mode random probability 0.33332999982
KUBE-SEP-DX25GZBAXCASAQMI  all  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */ statistic mode random probability 0.50000000000
KUBE-SEP-HI43CU4ZL6YUQHDB  all  --  anywhere             anywhere             /* performanceks1/performanceks1-external-ingress-controller:https */
