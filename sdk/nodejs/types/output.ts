// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as enums from "../types/enums";

export interface GetDeviceInfoControllerImage {
    /**
     * OS of the ISO image
     */
    os: string;
    /**
     * Service number of the ISO image
     */
    service: string;
    /**
     * Version of the ISO image
     */
    version: string;
}

export interface GetDeviceInfoInterface {
    /**
     * Interface enabled
     */
    enabled: boolean;
    l3Counters: {[key: string]: string};
    /**
     * Interface mtu
     */
    mtu: number;
    /**
     * Interface name
     */
    name: string;
    /**
     * Interface operational status
     */
    operationalStatus: string;
    /**
     * Interface port speed
     */
    portSpeed: string;
    /**
     * Interface type
     */
    type: string;
}

export interface GetDeviceInfoPartitionImage {
    /**
     * OS of the ISO image
     */
    os: string;
    /**
     * Service number of the ISO image
     */
    service: string;
    /**
     * Version of the ISO image
     */
    version: string;
}

export interface GetDeviceInfoTenantImage {
    /**
     * Image Date
     */
    date: string;
    /**
     * Image name
     */
    imageName: string;
    /**
     * In use
     */
    inUse: boolean;
    /**
     * Image Size
     */
    size: string;
    /**
     * Image Status
     */
    status: string;
    /**
     * Image Type
     */
    type: string;
}

export interface GetDeviceInfoVlan {
    /**
     * Vlan id
     */
    vlanId: number;
    /**
     * Vlan name
     */
    vlanName: string;
}

