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