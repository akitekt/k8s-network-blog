root@ip-101-202-5-39:/home/pie# crictl pods
POD ID              CREATED             STATE               NAME                                                              NAMESPACE           ATTEMPT
843aae920308e       2 weeks ago         Ready               splunk-universal-forwarder-mhqxk                                  kube-system         0
3c825484d2734       2 weeks ago         Ready               jaeger-agent-2x26m                                                jaeger              0
6a4731b67a62c       2 weeks ago         Ready               kube2iam-6wkjc                                                    kube-system         0
15fd1a68b837d       2 weeks ago         Ready               calico-node-j8nf9                                                 kube-system         0
254a9cc452cfd       2 weeks ago         Ready               kube-proxy-cshd9                                                  kube-system         0


root@ip-101-202-5-39:/home/pie# crictl inspectp 3c825484d2734
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