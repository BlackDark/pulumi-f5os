// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package f5os

import (
	"context"
	"reflect"

	"github.com/BlackDark/pulumi-f5os/sdk/go/f5os/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about the tenant Image on f5os platform.
//
// # Use this data source to get information, whether image available on platform or not
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/BlackDark/pulumi-f5os/sdk/go/f5os"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := f5os.LookupTenantImage(ctx, &f5os.LookupTenantImageArgs{
//				ImageName: "BIGIP-17.1.0-0.0.16.ALL-F5OS.qcow2.zip.bundle",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupTenantImage(ctx *pulumi.Context, args *LookupTenantImageArgs, opts ...pulumi.InvokeOption) (*LookupTenantImageResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupTenantImageResult
	err := ctx.Invoke("f5os:index/getTenantImage:getTenantImage", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTenantImage.
type LookupTenantImageArgs struct {
	// Name of the tenant image to check
	ImageName string `pulumi:"imageName"`
}

// A collection of values returned by getTenantImage.
type LookupTenantImageResult struct {
	// Unique identifier of this data source
	Id string `pulumi:"id"`
	// Name of the tenant image to check
	ImageName string `pulumi:"imageName"`
	// Status of Image on the F5OS Platforms
	ImageStatus string `pulumi:"imageStatus"`
}

func LookupTenantImageOutput(ctx *pulumi.Context, args LookupTenantImageOutputArgs, opts ...pulumi.InvokeOption) LookupTenantImageResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupTenantImageResultOutput, error) {
			args := v.(LookupTenantImageArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("f5os:index/getTenantImage:getTenantImage", args, LookupTenantImageResultOutput{}, options).(LookupTenantImageResultOutput), nil
		}).(LookupTenantImageResultOutput)
}

// A collection of arguments for invoking getTenantImage.
type LookupTenantImageOutputArgs struct {
	// Name of the tenant image to check
	ImageName pulumi.StringInput `pulumi:"imageName"`
}

func (LookupTenantImageOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTenantImageArgs)(nil)).Elem()
}

// A collection of values returned by getTenantImage.
type LookupTenantImageResultOutput struct{ *pulumi.OutputState }

func (LookupTenantImageResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTenantImageResult)(nil)).Elem()
}

func (o LookupTenantImageResultOutput) ToLookupTenantImageResultOutput() LookupTenantImageResultOutput {
	return o
}

func (o LookupTenantImageResultOutput) ToLookupTenantImageResultOutputWithContext(ctx context.Context) LookupTenantImageResultOutput {
	return o
}

// Unique identifier of this data source
func (o LookupTenantImageResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTenantImageResult) string { return v.Id }).(pulumi.StringOutput)
}

// Name of the tenant image to check
func (o LookupTenantImageResultOutput) ImageName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTenantImageResult) string { return v.ImageName }).(pulumi.StringOutput)
}

// Status of Image on the F5OS Platforms
func (o LookupTenantImageResultOutput) ImageStatus() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTenantImageResult) string { return v.ImageStatus }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupTenantImageResultOutput{})
}
