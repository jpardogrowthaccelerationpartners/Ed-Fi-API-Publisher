// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Tools.ApiPublisher.Connections.Api.Processing.Target.Messages;
using EdFi.Tools.ApiPublisher.Core.Processing;

namespace EdFi.Tools.ApiPublisher.Connections.Api.Processing.Target.Initiators;

public class UpsertPublishingStageInitiator : IPublishingStageInitiator
{
    private readonly IStreamingResourceProcessor _streamingResourceProcessor;
    private readonly IProcessingBlocksFactory<PostItemMessage> _processingBlocksFactory;

    public UpsertPublishingStageInitiator(IStreamingResourceProcessor streamingResourceProcessor, IProcessingBlocksFactory<PostItemMessage> processingBlocksFactory)
    {
        _streamingResourceProcessor = streamingResourceProcessor;
        _processingBlocksFactory = processingBlocksFactory;
    }

    public IDictionary<string, StreamingPagesItem> Start(ProcessingContext processingContext, CancellationToken cancellationToken)
    {
        return _streamingResourceProcessor.Start(
            _processingBlocksFactory.CreateProcessingBlocks,
            _processingBlocksFactory.CreateProcessDataMessages,
            processingContext,
            cancellationToken);
    }
}
