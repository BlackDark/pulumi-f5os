// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

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

export interface LoggingCaBundle {
    /**
     * The PEM-encoded content of the CA bundle.
     */
    content: string;
    /**
     * The name of the CA bundle.
     */
    name: string;
}

export interface LoggingRemoteForwarding {
    /**
     * Whether remote forwarding is enabled.
     */
    enabled: boolean;
    /**
     * List of files for remote forwarding output.
     */
    files?: outputs.LoggingRemoteForwardingFile[];
    /**
     * Log selectors for remote forwarding, specifying facility and severity.
     */
    logs?: outputs.LoggingRemoteForwardingLog[];
}

export interface LoggingRemoteForwardingFile {
    /**
     * The name of the file for log output.
     */
    name: string;
}

export interface LoggingRemoteForwardingLog {
    /**
     * The syslog facility for remote forwarding (local0 or authpriv).
     */
    facility: string;
    /**
     * The syslog severity for remote forwarding.
     */
    severity: string;
}

export interface LoggingServer {
    /**
     * The IP address or hostname of the remote logging server.
     */
    address: string;
    /**
     * Whether authentication is enabled for TCP protocol.
     */
    authentication?: boolean;
    /**
     * Log selectors for this server, specifying facility and severity.
     */
    logs?: outputs.LoggingServerLog[];
    /**
     * The port number for the remote logging server (1-65535).
     */
    port: number;
    /**
     * The protocol used for logging (tcp or udp).
     */
    protocol: string;
}

export interface LoggingServerLog {
    /**
     * The syslog facility (e.g., local0, authpriv).
     */
    facility: string;
    /**
     * The syslog severity (e.g., debug, informational, notice, warning, error, critical, alert, emergency).
     */
    severity: string;
}

export interface LoggingTls {
    /**
     * TLS certificate for secure logging.
     */
    certificate: string;
    /**
     * TLS private key for secure logging (sensitive).
     */
    key: string;
}

