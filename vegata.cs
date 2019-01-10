10.0.100.0/24 via 101.202.2.69 dev tunl0  proto bird onlink
10.0.101.0/24 via 101.202.3.165 dev tunl0  proto bird onlink
10.0.102.0/24 via 101.202.3.163 dev tunl0  proto bird onlink
10.0.103.0/24 via 101.202.0.92 dev tunl0  proto bird onlink
blackhole 10.0.104.0/24  proto bird
10.0.104.2 dev calibeec4c34496  scope link
10.0.104.7 dev calia08627eee93  scope link
10.0.104.8 dev cali7f75471adc7  scope link
10.0.104.9 dev cali9066bf87c18  scope link
10.0.104.36 dev calibb5dd9f41de  scope link
10.0.104.43 dev calicf6bd8e667d  scope link
10.0.104.44 dev califfcbcf93207  scope link
10.0.104.50 dev caliaa698084a1f  scope link
10.0.104.53 dev calib424fcbd49c  scope link
10.0.105.0/24 via 101.202.5.238 dev tunl0  proto bird onlink
10.0.106.0/24 via 101.202.4.29 dev tunl0  proto bird onlink
10.0.107.0/24 via 101.202.5.246 dev tunl0  proto bird onlink
10.0.108.0/24 via 101.202.2.210 dev tunl0  proto bird onlink
10.0.109.0/24 via 101.202.1.102 dev tunl0  proto bird onlink
10.0.110.0/24 via 101.202.0.189 dev tunl0  proto bird onlink
101.202.4.0/23 dev eth0  proto kernel  scope link  src 101.202.5.39
172.17.0.0/16 dev docker0  proto kernel  scope link  src 172.17.0.1 linkdown


root@ip-10-205-5-39:/home/pie# crictl pods
POD ID              CREATED             STATE               NAME                                                              NAMESPACE           ATTEMPT
843aae920308e       2 weeks ago         Ready               splunk-universal-forwarder-mhqxk                                  kube-system         0
3c825484d2734       2 weeks ago         Ready               jaeger-agent-2x26m                                                jaeger              0
6a4731b67a62c       2 weeks ago         Ready               kube2iam-6wkjc                                                    kube-system         0
15fd1a68b837d       2 weeks ago         Ready               calico-node-j8nf9                                                 kube-system         0
254a9cc452cfd       2 weeks ago         Ready               kube-proxy-cshd9                                                  kube-system         0


root@ip-10-205-5-39:/home/pie# crictl inspectp 3c825484d2734
{
  "status": {
    "id": "3c825484d2734e4fe1c54f2ecdc9d34bb54e4330ab48c9426fc90fdd02d2335d",
    "metadata": {
      "attempt": 0,
      "name": "jaeger-agent-2x26m",
      "namespace": "jaeger",
      "uid": "6dc97082-095c-11e9-a5bc-0258965a256c"
    },
    "state": "SANDBOX_READY",
    "createdAt": "2018-12-26T22:20:50.673959575Z",
    "network": {
      "ip": "10.0.104.2"
    },
    "linux": {
      "namespaces": {
        "options": {
          "ipc": "POD",
          "network": "POD",
          "pid": "CONTAINER"
        }
      }
    },
    "labels": {
      "app": "jaeger",
      "component": "agent",
      "controller-revision-hash": "957477944",
      "io.kubernetes.pod.name": "jaeger-agent-2x26m",
      "io.kubernetes.pod.namespace": "jaeger",
      "io.kubernetes.pod.uid": "6dc97082-095c-11e9-a5bc-0258965a256c",
      "jaeger-infra": "agent-instance",
      "pod-template-generation": "1",
      "release": "jaeger"
    },
    "annotations": {
      "kubernetes.io/config.seen": "2018-12-26T22:20:18.48411321Z",
      "kubernetes.io/config.source": "api"
    }
  }
}



root@ip-10-205-5-39:/home/pie# ip addr
1: lo: <LOOPBACK,UP,LOWER_UP> mtu 65536 qdisc noqueue state UNKNOWN group default qlen 1
    link/loopback 00:00:00:00:00:00 brd 00:00:00:00:00:00
    inet 127.0.0.1/8 scope host lo
       valid_lft forever preferred_lft forever
    inet6 ::1/128 scope host
       valid_lft forever preferred_lft forever
2: eth0: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 9001 qdisc mq state UP group default qlen 1000
    link/ether 12:d8:dd:fa:14:ce brd ff:ff:ff:ff:ff:ff
    inet 101.202.5.39/23 brd 101.202.5.255 scope global eth0
       valid_lft forever preferred_lft forever
    inet6 fe80::10d8:ddff:fefa:14ce/64 scope link
       valid_lft forever preferred_lft forever
3: docker0: <NO-CARRIER,BROADCAST,MULTICAST,UP> mtu 1500 qdisc noqueue state DOWN group default
    link/ether 02:42:86:d2:7f:b8 brd ff:ff:ff:ff:ff:ff
    inet 172.17.0.1/16 scope global docker0
       valid_lft forever preferred_lft forever
4: tunl0@NONE: <NOARP,UP,LOWER_UP> mtu 1440 qdisc noqueue state UNKNOWN group default qlen 1
    link/ipip 0.0.0.0 brd 0.0.0.0
    inet 10.0.104.1/32 brd 10.0.104.1 scope global tunl0
       valid_lft forever preferred_lft forever
5: calibeec4c34496@if4: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1440 qdisc noqueue state UP group default
    link/ether ee:ee:ee:ee:ee:ee brd ff:ff:ff:ff:ff:ff link-netnsid 0
    inet6 fe80::ecee:eeff:feee:eeee/64 scope link
       valid_lft forever preferred_lft forever
10: calia08627eee93@if4: <BROADCAST,MULTICAST,UP,LOWER_UP> mtu 1440 qdisc noqueue state UP group default
    link/ether ee:ee:ee:ee:ee:ee brd ff:ff:ff:ff:ff:ff link-netnsid 1
    inet6 fe80::ecee:eeff:feee:eeee/64 scope link
       valid_lft forever preferred_lft forever
...



