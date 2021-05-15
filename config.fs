[vendor/bin/*]
mode: 0755
user: AID_ROOT
group: AID_SHELL
caps: 0

[vendor/bin/cnss-daemon]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE

[vendor/bin/pm-service]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE

[vendor/bin/sensors.qcom]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE

[vendor/bin/imsdatadaemon]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE

[vendor/bin/ims_rtp_daemon]
mode: 0755
user: AID_SYSTEM
group: AID_RADIO
caps: NET_BIND_SERVICE

[persist/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[vendor/]
mode: 0755
user: AID_ROOT
group: AID_SHELL
caps: 0
