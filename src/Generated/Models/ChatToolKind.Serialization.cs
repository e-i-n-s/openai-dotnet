// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Chat
{
    internal static partial class ChatToolKindExtensions
    {
        public static string ToSerialString(this Chat.ChatToolKind value) => value switch
        {
            Chat.ChatToolKind.Function => "function",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChatToolKind value.")
        };

        public static Chat.ChatToolKind ToChatToolKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "function"))
            {
                return Chat.ChatToolKind.Function;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChatToolKind value.");
        }
    }
}
