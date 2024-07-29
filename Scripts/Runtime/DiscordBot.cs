using System.Text;
using Newtonsoft.Json.Linq;
using UnityEngine;
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
            JObject embedValue = new JObject();
            JArray embedArray = new JArray();
            JObject json = new JObject();
        
            if (!string.IsNullOrEmpty(options.content))
                json.Add("content", options.content);
        
            if (options.embeds != null)
            {
                if (!string.IsNullOrEmpty(options.embeds.title))
                    embedValue.Add("title", options.embeds.title);
        
                if (!string.IsNullOrEmpty(options.embeds.description))
                    embedValue.Add("description", options.embeds.description);
        
                if (options.embeds.color != 0)
                    embedValue.Add("color", options.embeds.color);
        
                embedArray.Add(embedValue);
        
                json.Add("embeds", embedArray);
            }
        
            var downloadHandler = new DownloadHandlerBuffer();
            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json.ToString()))
            {
                contentType = "application/json",
            };
        
            var request =
                new UnityWebRequest(WebHookURL, UnityWebRequest.kHttpVerbPOST, downloadHandler, uploadHandler);
            return request;
        }
    }
}