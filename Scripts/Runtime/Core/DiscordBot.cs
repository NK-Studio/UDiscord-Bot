using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace NKStudio.Discord
{
    public class DiscordBot
    {
        private string WebHookURL { get; set; }
        public Options Options;

        /// <summary>
        /// 주어진 웹훅 URL을 사용하여 새로운 DiscordBot 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="webhook">Discord 웹훅 URL</param>
        /// <returns>새로운 DiscordBot 인스턴스</returns>
        public static DiscordBot Create(string webhook)
        {
            var discordBot = new DiscordBot();
            discordBot.WebHookURL = webhook;
            
            return discordBot;
        }

        /// <summary>
        /// 주어진 옵션을 사용하여 UnityWebRequest를 생성합니다.
        /// </summary>
        /// <param name="options">Discord 메시지 옵션</param>
        /// <returns>생성된 UnityWebRequest</returns>
        public UnityWebRequest CreateWebRequest(Options options)
        {
            var jsonDictionary = new Dictionary<string, object>();

            // Options
            if (!string.IsNullOrEmpty(options.Content))
                jsonDictionary["content"] = options.Content;

            if (!string.IsNullOrEmpty(options.Username))
                jsonDictionary["username"] = options.Username;

            if (!string.IsNullOrEmpty(options.AvatarUrl))
                jsonDictionary["avatar_url"] = options.AvatarUrl;

            // Embeds
            if (options.Embeds != null)
            {
                // Embeds
                var embedValue = new Dictionary<string, object>();

                // Title
                if (!string.IsNullOrEmpty(options.Embeds.title))
                    embedValue["title"] = options.Embeds.title;

                // URL
                if (!string.IsNullOrEmpty(options.Embeds.URL))
                    embedValue["url"] = options.Embeds.URL;

                // Description
                if (!string.IsNullOrEmpty(options.Embeds.Description))
                    embedValue["description"] = options.Embeds.Description;

                // Color
                if (options.Embeds.Color != 0)
                    embedValue["color"] = options.Embeds.Color;

                // TTS
                jsonDictionary["tts"] = options.tts;
                
                // Fields
                var embedArray = new List<object> { embedValue };
                jsonDictionary["embeds"] = embedArray;

                // Footer
                if (options.Embeds.Footer != null)
                {
                    var footerValue = new Dictionary<string, object>();
                    if (!string.IsNullOrEmpty(options.Embeds.Footer.Text))
                        footerValue["text"] = options.Embeds.Footer.Text;

                    if (!string.IsNullOrEmpty(options.Embeds.Footer.IconURL))
                        footerValue["icon_url"] = options.Embeds.Footer.IconURL;

                    embedValue["footer"] = footerValue;
                }

                // Author
                if (options.Embeds.Author != null)
                {
                    var authorValue = new Dictionary<string, object>();
                    if (!string.IsNullOrEmpty(options.Embeds.Author.Name))
                        authorValue["name"] = options.Embeds.Author.Name;

                    if (!string.IsNullOrEmpty(options.Embeds.Author.URL))
                        authorValue["url"] = options.Embeds.Author.URL;

                    if (!string.IsNullOrEmpty(options.Embeds.Author.IconURL))
                        authorValue["icon_url"] = options.Embeds.Author.IconURL;

                    embedValue["author"] = authorValue;
                }

                // Image
                if (!string.IsNullOrEmpty(options.Embeds.ImageURL))
                {
                    var imageValue = new Dictionary<string, object>();
                    imageValue["url"] = options.Embeds.ImageURL;
                    embedValue["image"] = imageValue;
                }

                // Thumbnail
                if (!string.IsNullOrEmpty(options.Embeds.ThumbnailURL))
                {
                    var thumbnailValue = new Dictionary<string, object>();
                    thumbnailValue["url"] = options.Embeds.ThumbnailURL;
                    embedValue["thumbnail"] = thumbnailValue;
                }
            }

            string json = MiniJSON.Json.Serialize(jsonDictionary);
            var downloadHandler = new DownloadHandlerBuffer();
            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json));
            uploadHandler.contentType = "application/json";

            var request =
                new UnityWebRequest(WebHookURL, UnityWebRequest.kHttpVerbPOST, downloadHandler, uploadHandler);
            return request;
        }
    }
}