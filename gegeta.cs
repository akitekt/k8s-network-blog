default via 101.202.4.1 dev eth0
10.0.0.0/24 via 101.202.0.205 dev tunl0  proto bird onlink
10.0.1.0/24 via 101.202.3.103 dev tunl0  proto bird onlink
10.0.2.0/24 via 101.202.5.209 dev eth0  proto bird
10.0.3.0/24 via 101.202.2.123 dev tunl0  proto bird onlink
10.0.4.0/24 via 101.202.3.104 dev tunl0  proto bird onlink
10.0.5.0/24 via 101.202.4.217 dev eth0  proto bird
10.0.6.0/24 via 101.202.1.41 dev tunl0  proto bird onlink
blackhole 10.0.7.0/24  proto bird
10.0.7.2 dev cali77ec83574f4  scope link
10.0.7.3 dev cali09a12e605e2  scope link
10.0.7.4 dev calid9fe6681678  scope link
10.0.7.5 dev cali00eb81c9259  scope link
10.0.7.8 dev calia645991a7fb  scope link
10.0.7.9 dev cali8e98e4eb396  scope link
10.0.7.11 dev cali15c7619fccc  scope link
10.0.7.12 dev calid75abf4f5e0  scope link
101.202.4.0/23 dev eth0  proto kernel  scope link  src 101.202.4.39
172.17.0.0/16 dev docker0  proto kernel  scope link  src 172.17.0.1 linkdown



1: lo: <LOOPBACK,UP,LOWER_UP> mtu 65536 qdisc noqueue state UNKNOWN group default qlen 1
    link/loopback 00:00:00:00:00:00 brd 00:00:00:00:00:00
    inet 127.0.0.1/8 scope host lo
       valid_lft forever preferred_lft forever
    inet6 ::1/128 scope host
       valid_lft forever preferred_lft forever
2: eth0: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 9001 qdisc mq state UP group default qlen 1000
    link/ether 12:24:0c:dc:87:ba brd ff:ff:ff:ff:ff:ff
    inet 101.202.4.39/23 brd 101.202.5.255 scope global eth0
       valid_lft forever preferred_lft forever
    inet6 fe80::1024:cff:fedc:87ba/64 scope link
       valid_lft forever preferred_lft forever
3: docker0: <NO-CARRIER,BROADCAST,MULTICAST,UP> mtu 1500 qdisc noqueue state DOWN group default
    link/ether 02:42:4d:e0:4d:fb brd ff:ff:ff:ff:ff:ff
    inet 172.17.0.1/16 scope global docker0
       valid_lft forever preferred_lft forever
4: dummy0: <BROADCAST,NOARP> mtu 1500 qdisc noop state DOWN group default qlen 1000
    link/ether de:0a:02:05:62:83 brd ff:ff:ff:ff:ff:ff
5: kube-ipvs0: <BROADCAST,NOARP> mtu 1500 qdisc noop state DOWN group default
    link/ether 96:6f:61:22:f0:24 brd ff:ff:ff:ff:ff:ff
    inet 10.1.0.1/32 brd 10.1.0.1 scope global kube-ipvs0
       valid_lft forever preferred_lft forever
    inet 10.1.0.10/32 brd 10.1.0.10 scope global kube-ipvs0
       valid_lft forever preferred_lft forever
    inet 10.1.1.241/32 brd 10.1.1.241 scope global kube-ipvs0
       valid_lft forever preferred_lft forever
    inet 10.1.173.239/32 brd 10.1.173.239 scope global kube-ipvs0
       valid_lft forever preferred_lft forever
    ...
6: tunl0@NONE: <NOARP,UP,LOWER_UP> mtu 1440 qdisc noqueue state UNKNOWN group default qlen 1
    link/ipip 0.0.0.0 brd 0.0.0.0
    inet 10.0.7.1/32 brd 10.0.7.1 scope global tunl0
       valid_lft forever preferred_lft forever
7: cali77ec83574f4@if4: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1440 qdisc noqueue state UP group default
    link/ether ee:ee:ee:ee:ee:ee brd ff:ff:ff:ff:ff:ff link-netnsid 0
    inet6 fe80::ecee:eeff:feee:eeee/64 scope link
       valid_lft forever preferred_lft forever
8: cali09a12e605e2@if4: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1440 qdisc noqueue state UP group default
    link/ether ee:ee:ee:ee:ee:ee brd ff:ff:ff:ff:ff:ff link-netnsid 1
    inet6 fe80::ecee:eeff:feee:eeee/64 scope link
       valid_lft forever preferred_lft forever
    ...



TCP  10.1.0.1:443 rr
  -> 101.202.0.205:6443            Masq    1      2          0
  -> 101.202.3.103:6443            Masq    1      3          0
  -> 101.202.5.209:6443            Masq    1      3          0
TCP  10.1.0.10:53 rr
  -> 10.0.3.2:53                  Masq    1      0          0
  -> 10.0.3.3:53                  Masq    1      0          0
TCP  10.1.1.241:5473 rr
  -> 101.202.1.41:5473             Masq    1      0          0
  -> 101.202.4.217:5473            Masq    1      1          0
TCP  10.1.18.9:80 rr
  -> 10.0.3.6:80                  Masq    1      0          0
  -> 10.0.6.6:80                  Masq    1      0          0
  -> 10.0.7.9:80                  Masq    1      0          0