// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseTextContentPart : ConversationContentPart
    {
        internal InternalRealtimeResponseTextContentPart(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Type = ConversationContentPartKind.Text;
            Text = text;
        }

        internal InternalRealtimeResponseTextContentPart(ConversationContentPartKind type, IDictionary<string, BinaryData> serializedAdditionalRawData, string text) : base(type, serializedAdditionalRawData)
        {
            Text = text;
        }

        internal InternalRealtimeResponseTextContentPart()
        {
        }

        public string Text { get; }
    }
}