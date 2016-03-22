﻿// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1;

namespace Google.Storage.V1
{
    /// <summary>
    /// Options for <c>DeleteObject</c> operations.
    /// </summary>
    public class DeleteObjectOptions
    {
        public long? Generation { get; set; }

        internal void ModifyRequest(ObjectsResource.DeleteRequest request)
        {
            if (Generation != null)
            {
                request.Generation = Generation;
            }
        }
    }
}