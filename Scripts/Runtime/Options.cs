using System;

namespace NKStudio.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params
    /// </summary>
    [Serializable]
    public struct Options
    {
        /// <summary>
        /// Overrides the username of the webhook. Recommended to leave blank. (optional)
        /// </summary>
        public string username;

        /// <summary>
        /// Message text. Recommended to use embeds instead. (optional)
        /// </summary>
        public string content;

        /// <summary>
        /// Embedded messages. (optional)
        /// </summary>
        public Embed embeds;
    }
}