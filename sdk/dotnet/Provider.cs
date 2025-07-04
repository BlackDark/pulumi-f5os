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
    /// The provider type for the f5os package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [F5osResourceType("pulumi:providers:f5os")]
    public partial class Provider : global::Pulumi.ProviderResource
    {
        /// <summary>
        /// URI/Host details for F5os Device,can be provided via `F5OS_HOST` environment variable.
        /// </summary>
        [Output("host")]
        public Output<string?> Host { get; private set; } = null!;

        /// <summary>
        /// Password for F5os Device,can be provided via `F5OS_PASSWORD` environment variable.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// Username for F5os Device,can be provided via `F5OS_USERNAME` environment variable.User provided here need to have
        /// required permission as per
        /// [UserManagement](https://techdocs.f5.com/en-us/f5os-a-1-4-0/f5-rseries-systems-administration-configuration/title-user-mgmt.html)
        /// </summary>
        [Output("username")]
        public Output<string?> Username { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs? args = null, CustomResourceOptions? options = null)
            : base("f5os", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }

        /// <summary>
        /// This function returns a Terraform config object with terraform-namecased keys,to be used with the Terraform Module Provider.
        /// </summary>
        public global::Pulumi.Output<ProviderTerraformConfigResult> TerraformConfig()
            => global::Pulumi.Deployment.Instance.Call<ProviderTerraformConfigResult>("pulumi:providers:f5os/terraformConfig", CallArgs.Empty, this);
    }

    public sealed class ProviderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// `disable_tls_verify` controls whether a client verifies the server's certificate chain and host name. default it is set
        /// to `true`. If `disable_tls_verify` is true, crypto/tls accepts any certificate presented by the server and any host name
        /// in that certificate. In this mode, TLS is susceptible to machine-in-the-middle attacks unless custom verification is
        /// used. can be provided by `DISABLE_TLS_VERIFY` environment variable. &gt; **NOTE** If it is set to `false`, certificate/ca
        /// certificates should be added to `trusted store` of host where we are running this provider.
        /// </summary>
        [Input("disableTlsVerify", json: true)]
        public Input<bool>? DisableTlsVerify { get; set; }

        /// <summary>
        /// URI/Host details for F5os Device,can be provided via `F5OS_HOST` environment variable.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for F5os Device,can be provided via `F5OS_PASSWORD` environment variable.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Port Number to be used to make API calls to HOST
        /// </summary>
        [Input("port", json: true)]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// If this flag set to true,sending telemetry data to TEEM will be disabled,can be provided via `TEEM_DISABLE` environment
        /// variable.
        /// </summary>
        [Input("teemDisable", json: true)]
        public Input<bool>? TeemDisable { get; set; }

        /// <summary>
        /// Username for F5os Device,can be provided via `F5OS_USERNAME` environment variable.User provided here need to have
        /// required permission as per
        /// [UserManagement](https://techdocs.f5.com/en-us/f5os-a-1-4-0/f5-rseries-systems-administration-configuration/title-user-mgmt.html)
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ProviderArgs()
        {
        }
        public static new ProviderArgs Empty => new ProviderArgs();
    }

    /// <summary>
    /// The results of the <see cref="Provider.TerraformConfig"/> method.
    /// </summary>
    [OutputType]
    public sealed class ProviderTerraformConfigResult
    {
        public readonly ImmutableDictionary<string, object> Result;

        [OutputConstructor]
        private ProviderTerraformConfigResult(ImmutableDictionary<string, object> result)
        {
            Result = result;
        }
    }
}
