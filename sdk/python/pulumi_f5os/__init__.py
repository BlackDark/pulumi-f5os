# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
from . import _utilities
import typing
# Export this package's modules as members:
from .config_backup import *
from .dns import *
from .get_device_info import *
from .get_tenant_image import *
from .interface import *
from .lag import *
from .license import *
from .logging import *
from .ntp_server import *
from .partition import *
from .partition_change_password import *
from .primarykey import *
from .provider import *
from .system import *
from .tenant import *
from .tenant_image import *
from .tls_cert_key import *
from .vlan import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_f5os.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumi_f5os.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "f5os",
  "mod": "index/configBackup",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/configBackup:ConfigBackup": "ConfigBackup"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/dns",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/dns:Dns": "Dns"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/interface",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/interface:Interface": "Interface"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/lag",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/lag:Lag": "Lag"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/license",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/license:License": "License"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/logging",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/logging:Logging": "Logging"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/ntpServer",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/ntpServer:NtpServer": "NtpServer"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/partition",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/partition:Partition": "Partition"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/partitionChangePassword",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/partitionChangePassword:PartitionChangePassword": "PartitionChangePassword"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/primarykey",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/primarykey:Primarykey": "Primarykey"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/system",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/system:System": "System"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/tenant",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/tenant:Tenant": "Tenant"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/tenantImage",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/tenantImage:TenantImage": "TenantImage"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/tlsCertKey",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/tlsCertKey:TlsCertKey": "TlsCertKey"
  }
 },
 {
  "pkg": "f5os",
  "mod": "index/vlan",
  "fqn": "pulumi_f5os",
  "classes": {
   "f5os:index/vlan:Vlan": "Vlan"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "f5os",
  "token": "pulumi:providers:f5os",
  "fqn": "pulumi_f5os",
  "class": "Provider"
 }
]
"""
)
