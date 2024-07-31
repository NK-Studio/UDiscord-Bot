using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace NKStudio.Discord
{
    public class DiscordBot
    {
        public string WebHookURL { get; set; }

        public Options Options;

        public static DiscordBot Create(string webhook)
        {
            var discordBot = new DiscordBot();
            discordBot.WebHookURL = webhook;
            return discordBot;
        }
        
        public UnityWebRequest CreateWebRequest(Options options)
        {
            var json = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(options.content))
                json["content"] = options.content;

            if (options.embeds != null)
            {
                var embedValue = new Dictionary<string, object>();

                if (!string.IsNullOrEmpty(options.embeds.title))
                    embedValue["title"] = options.embeds.title;

                if (!string.IsNullOrEmpty(options.embeds.description))
                    embedValue["description"] = options.embeds.description;

                if (options.embeds.color != 0)
                    embedValue["color"] = options.embeds.color;

                var embedArray = new List<object> { embedValue };
                json["embeds"] = embedArray;
            }

            var downloadHandler = new DownloadHandlerBuffer();
            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(MiniJSON.Json.Serialize(json)))
            {
                contentType = "application/json",
            };

            var request = new UnityWebRequest(WebHookURL, UnityWebRequest.kHttpVerbPOST, downloadHandler, uploadHandler);
            return request;
        }

    }
}