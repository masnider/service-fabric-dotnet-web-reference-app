﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Common.Wrappers
{
    using System;
    using Microsoft.ServiceFabric.Services.Remoting;
    using Microsoft.ServiceFabric.Services.Client;
    /// <summary>
    /// Interface to wrap the static ServiceProxy methods so we can inject any implementation into components that
    /// need ServiceProxy. This way we can inject a mock for unit testing.
    /// </summary>
    public interface IServiceProxyWrapper
    {
        TServiceInterface Create<TServiceInterface>(Uri serviceName) where TServiceInterface : IService;
        TServiceInterface Create<TServiceInterface>(Uri serviceName, ServicePartitionKey partitionKey) where TServiceInterface : IService;
    }
}