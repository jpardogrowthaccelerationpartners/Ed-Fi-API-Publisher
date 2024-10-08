// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Newtonsoft.Json.Linq;

namespace EdFi.Tools.ApiPublisher.Connections.Api.Processing.Target.Messages
{
    public class GetItemForDeletionMessage
    {
        /// <summary>
        /// Gets or sets the relative URL for the resource to be deleted.
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// Gets or sets the natural key values for the resource to be deleted on the target.
        /// </summary>
        public JToken KeyValues { get; set; }

        /// <summary>
        /// Gets or sets the source API's resource identifier for the resource that was deleted.
        /// </summary>
        /// <remarks>This is captured for informational purposes only.</remarks>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the cancellation token indicating whether delete processing should proceed.
        /// </summary>
        public CancellationToken CancellationToken { get; set; }
    }
}
