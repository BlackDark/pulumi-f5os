// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.F5os
{
    /// <summary>
    /// Resource used for Manage VELOS chassis partition
    /// 
    /// &gt; **NOTE** `f5os.Partition` resource is used with Velos Chassis controller only, More info on [chassis partition](https://techdocs.f5.com/en-us/velos-1-5-0/velos-systems-administration-configuration/title-partition-mgmt.html#about-partitions).
    /// Provider `f5os` credentials will be chassis controller `host`,`username` and `password`
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using F5os = Pulumi.F5os;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     // Manages F5OS partition
    ///     var velos_part = new F5os.Partition("velos-part", new()
    ///     {
    ///         Name = "TerraformPartition",
    ///         OsVersion = "1.3.1-5968",
    ///         Ipv4MgmtAddress = "10.144.140.125/24",
    ///         Ipv4MgmtGateway = "10.144.140.253",
    ///         Ipv6MgmtAddress = "2001::1/64",
    ///         Ipv6MgmtGateway = "2001::",
    ///         Slots = new[]
    ///         {
    ///             1,
    ///             2,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [F5osResourceType("f5os:index/partition:Partition")]
    public partial class Partition : global::Pulumi.CustomResource
    {
        /// <summary>
        /// select the desired configuration volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 15 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Output("configurationVolumeSize")]
        public Output<int> ConfigurationVolumeSize { get; private set; } = null!;

        /// <summary>
        /// Enables or disables partition.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// select the desired storage volume for all tenant images in increments of 1 GB.
        /// The default value is 15 GB, with a minimum of 5 GB and a maximum of 50 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Output("imagesVolumeSize")]
        public Output<int> ImagesVolumeSize { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv4 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 192.168.1.1/24.
        /// </summary>
        [Output("ipv4MgmtAddress")]
        public Output<string?> Ipv4MgmtAddress { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv4 chassis partition management gateway.
        /// </summary>
        [Output("ipv4MgmtGateway")]
        public Output<string?> Ipv4MgmtGateway { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv6 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 2002::1234:abcd:ffff:c0a8:101/64.
        /// Required for create operations.
        /// </summary>
        [Output("ipv6MgmtAddress")]
        public Output<string?> Ipv6MgmtAddress { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv6 chassis partition management gateway.
        /// Required for create operations.
        /// </summary>
        [Output("ipv6MgmtGateway")]
        public Output<string?> Ipv6MgmtGateway { get; private set; } = null!;

        /// <summary>
        /// Name of the chassis partition.
        /// Partition names must consist only of alphanumerics (0-9, a-z, A-Z), must begin with a letter, and are limited to 31 characters.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the partition F5OS-C OS Bundled version.(ISO image version)
        /// </summary>
        [Output("osVersion")]
        public Output<string> OsVersion { get; private set; } = null!;

        /// <summary>
        /// select the desired user data (tcpdump captures, QKView data, etc.) volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 20 GBAfter volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Output("sharedVolumeSize")]
        public Output<int> SharedVolumeSize { get; private set; } = null!;

        /// <summary>
        /// List of integers.
        /// Specifies which slots with which the chassis partition should associated.
        /// </summary>
        [Output("slots")]
        public Output<ImmutableArray<int>> Slots { get; private set; } = null!;

        /// <summary>
        /// The number of seconds to wait for partition to transition to running state.
        /// </summary>
        [Output("timeout")]
        public Output<int> Timeout { get; private set; } = null!;


        /// <summary>
        /// Create a Partition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Partition(string name, PartitionArgs? args = null, CustomResourceOptions? options = null)
            : base("f5os:index/partition:Partition", name, args ?? new PartitionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Partition(string name, Input<string> id, PartitionState? state = null, CustomResourceOptions? options = null)
            : base("f5os:index/partition:Partition", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Partition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Partition Get(string name, Input<string> id, PartitionState? state = null, CustomResourceOptions? options = null)
        {
            return new Partition(name, id, state, options);
        }
    }

    public sealed class PartitionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// select the desired configuration volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 15 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("configurationVolumeSize")]
        public Input<int>? ConfigurationVolumeSize { get; set; }

        /// <summary>
        /// Enables or disables partition.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// select the desired storage volume for all tenant images in increments of 1 GB.
        /// The default value is 15 GB, with a minimum of 5 GB and a maximum of 50 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("imagesVolumeSize")]
        public Input<int>? ImagesVolumeSize { get; set; }

        /// <summary>
        /// Specifies the IPv4 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 192.168.1.1/24.
        /// </summary>
        [Input("ipv4MgmtAddress")]
        public Input<string>? Ipv4MgmtAddress { get; set; }

        /// <summary>
        /// Specifies the IPv4 chassis partition management gateway.
        /// </summary>
        [Input("ipv4MgmtGateway")]
        public Input<string>? Ipv4MgmtGateway { get; set; }

        /// <summary>
        /// Specifies the IPv6 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 2002::1234:abcd:ffff:c0a8:101/64.
        /// Required for create operations.
        /// </summary>
        [Input("ipv6MgmtAddress")]
        public Input<string>? Ipv6MgmtAddress { get; set; }

        /// <summary>
        /// Specifies the IPv6 chassis partition management gateway.
        /// Required for create operations.
        /// </summary>
        [Input("ipv6MgmtGateway")]
        public Input<string>? Ipv6MgmtGateway { get; set; }

        /// <summary>
        /// Name of the chassis partition.
        /// Partition names must consist only of alphanumerics (0-9, a-z, A-Z), must begin with a letter, and are limited to 31 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the partition F5OS-C OS Bundled version.(ISO image version)
        /// </summary>
        [Input("osVersion")]
        public Input<string>? OsVersion { get; set; }

        /// <summary>
        /// select the desired user data (tcpdump captures, QKView data, etc.) volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 20 GBAfter volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("sharedVolumeSize")]
        public Input<int>? SharedVolumeSize { get; set; }

        [Input("slots")]
        private InputList<int>? _slots;

        /// <summary>
        /// List of integers.
        /// Specifies which slots with which the chassis partition should associated.
        /// </summary>
        public InputList<int> Slots
        {
            get => _slots ?? (_slots = new InputList<int>());
            set => _slots = value;
        }

        /// <summary>
        /// The number of seconds to wait for partition to transition to running state.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        public PartitionArgs()
        {
        }
        public static new PartitionArgs Empty => new PartitionArgs();
    }

    public sealed class PartitionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// select the desired configuration volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 15 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("configurationVolumeSize")]
        public Input<int>? ConfigurationVolumeSize { get; set; }

        /// <summary>
        /// Enables or disables partition.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// select the desired storage volume for all tenant images in increments of 1 GB.
        /// The default value is 15 GB, with a minimum of 5 GB and a maximum of 50 GB.After volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("imagesVolumeSize")]
        public Input<int>? ImagesVolumeSize { get; set; }

        /// <summary>
        /// Specifies the IPv4 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 192.168.1.1/24.
        /// </summary>
        [Input("ipv4MgmtAddress")]
        public Input<string>? Ipv4MgmtAddress { get; set; }

        /// <summary>
        /// Specifies the IPv4 chassis partition management gateway.
        /// </summary>
        [Input("ipv4MgmtGateway")]
        public Input<string>? Ipv4MgmtGateway { get; set; }

        /// <summary>
        /// Specifies the IPv6 address and subnet mask used to access the chassis partition.
        /// The address must be specified in CIDR notation e.g. 2002::1234:abcd:ffff:c0a8:101/64.
        /// Required for create operations.
        /// </summary>
        [Input("ipv6MgmtAddress")]
        public Input<string>? Ipv6MgmtAddress { get; set; }

        /// <summary>
        /// Specifies the IPv6 chassis partition management gateway.
        /// Required for create operations.
        /// </summary>
        [Input("ipv6MgmtGateway")]
        public Input<string>? Ipv6MgmtGateway { get; set; }

        /// <summary>
        /// Name of the chassis partition.
        /// Partition names must consist only of alphanumerics (0-9, a-z, A-Z), must begin with a letter, and are limited to 31 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the partition F5OS-C OS Bundled version.(ISO image version)
        /// </summary>
        [Input("osVersion")]
        public Input<string>? OsVersion { get; set; }

        /// <summary>
        /// select the desired user data (tcpdump captures, QKView data, etc.) volume in increments of 1 GB.
        /// The default value is 10 GB, with a minimum of 5 GB and a maximum of 20 GBAfter volume sizes are configured, their sizes can be increased but not reduced
        /// </summary>
        [Input("sharedVolumeSize")]
        public Input<int>? SharedVolumeSize { get; set; }

        [Input("slots")]
        private InputList<int>? _slots;

        /// <summary>
        /// List of integers.
        /// Specifies which slots with which the chassis partition should associated.
        /// </summary>
        public InputList<int> Slots
        {
            get => _slots ?? (_slots = new InputList<int>());
            set => _slots = value;
        }

        /// <summary>
        /// The number of seconds to wait for partition to transition to running state.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        public PartitionState()
        {
        }
        public static new PartitionState Empty => new PartitionState();
    }
}
