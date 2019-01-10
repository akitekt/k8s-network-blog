root@ip-101-202-7-202:/home/pie# iptables -L -t nat | grep -B 1 -A 4 -E 'KUBE-SVC-3C2I2DNJ4VWZY5PF|KUBE-SEP-P6JNEFEXMECE2WS6|KUBE-SEP-DX25GZBAXCASAQMI|KUBE-SEP-HI43CU4ZL6YUQHDB'

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
