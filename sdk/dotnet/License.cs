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
    /// Resource to manage license activation and deactivation.
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
    ///     var dummyLicense = new F5os.License("dummy_license", new()
    ///     {
    ///         RegistrationKey = "W9XXX-8YYYZ-8KKK7-7PPP2-ZZZZZZ",
    ///         AddonKeys = new[]
    ///         {
    ///             "NNNWWWW-9PPPPKK",
    ///             "WWWWXXX-4ZZZYYY",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [F5osResourceType("f5os:index/license:License")]
    public partial class License : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The additional registration keys from a license server for the device license activation.
        /// </summary>
        [Output("addonKeys")]
        public Output<ImmutableArray<string>> AddonKeys { get; private set; } = null!;

        /// <summary>
        /// The license server url.
        /// </summary>
        [Output("licenseServer")]
        public Output<string?> LicenseServer { get; private set; } = null!;

        /// <summary>
        /// The Base registration key from a license server for the device license activation.
        /// </summary>
        [Output("registrationKey")]
        public Output<string> RegistrationKey { get; private set; } = null!;


        /// <summary>
        /// Create a License resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public License(string name, LicenseArgs args, CustomResourceOptions? options = null)
            : base("f5os:index/license:License", name, args ?? new LicenseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private License(string name, Input<string> id, LicenseState? state = null, CustomResourceOptions? options = null)
            : base("f5os:index/license:License", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "addonKeys",
                    "registrationKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing License resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static License Get(string name, Input<string> id, LicenseState? state = null, CustomResourceOptions? options = null)
        {
            return new License(name, id, state, options);
        }
    }

    public sealed class LicenseArgs : global::Pulumi.ResourceArgs
    {
        [Input("addonKeys")]
        private InputList<string>? _addonKeys;

        /// <summary>
        /// The additional registration keys from a license server for the device license activation.
        /// </summary>
        public InputList<string> AddonKeys
        {
            get => _addonKeys ?? (_addonKeys = new InputList<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableArray.Create<string>());
                _addonKeys = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        /// <summary>
        /// The license server url.
        /// </summary>
        [Input("licenseServer")]
        public Input<string>? LicenseServer { get; set; }

        [Input("registrationKey", required: true)]
        private Input<string>? _registrationKey;

        /// <summary>
        /// The Base registration key from a license server for the device license activation.
        /// </summary>
        public Input<string>? RegistrationKey
        {
            get => _registrationKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _registrationKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public LicenseArgs()
        {
        }
        public static new LicenseArgs Empty => new LicenseArgs();
    }

    public sealed class LicenseState : global::Pulumi.ResourceArgs
    {
        [Input("addonKeys")]
        private InputList<string>? _addonKeys;

        /// <summary>
        /// The additional registration keys from a license server for the device license activation.
        /// </summary>
        public InputList<string> AddonKeys
        {
            get => _addonKeys ?? (_addonKeys = new InputList<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableArray.Create<string>());
                _addonKeys = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        /// <summary>
        /// The license server url.
        /// </summary>
        [Input("licenseServer")]
        public Input<string>? LicenseServer { get; set; }

        [Input("registrationKey")]
        private Input<string>? _registrationKey;

        /// <summary>
        /// The Base registration key from a license server for the device license activation.
        /// </summary>
        public Input<string>? RegistrationKey
        {
            get => _registrationKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _registrationKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public LicenseState()
        {
        }
        public static new LicenseState Empty => new LicenseState();
    }
}
