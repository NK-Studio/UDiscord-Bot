using System.Collections.Generic;
using System.Text;
using NKStudio.Discord.Module;
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
                if (options.Embeds.Title != null)
                    embedValue["title"] = options.Embeds.Title;

                // URL
                if (!string.IsNullOrEmpty(options.Embeds.URL))
                    embedValue["url"] = options.Embeds.URL;

                // Description
                if (!string.IsNullOrEmpty(options.Embeds.Description))
                    embedValue["description"] = options.Embeds.Description;
                
                // Timestamp
                if (options.Embeds.Timestamp != null)
                {
                    var format = options.Embeds.Timestamp.Format;
                    
                    if (string.IsNullOrEmpty(format)) 
                        format = "yyyy-MM-ddTHH:mm:ssZ";
                    
                    embedValue["timestamp"] = options.Embeds.Timestamp.Time.ToString(format);
                }

                // Color
                if (options.Embeds.Color != null)
                    embedValue["color"] = options.Embeds.Color.Value;

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
                if (options.Embeds.Image != null)
                {
                    var imageValue = new Dictionary<string, object>();
                    if (!string.IsNullOrEmpty(options.Embeds.Image))
                        imageValue["url"] = options.Embeds.Image;

                    embedValue["image"] = imageValue;
                }

                if (options.Embeds.Video != null)
                {
                    var videoValue = new Dictionary<string, object>();

                    if (!string.IsNullOrEmpty(options.Embeds.Video.URL))
                        videoValue["url"] = options.Embeds.Video.URL;

                    if (options.Embeds.Video.Width != null)
                        videoValue["width"] = options.Embeds.Video.Width;

                    if (options.Embeds.Video.Height != null)
                        videoValue["height"] = options.Embeds.Video.Height;

                    embedValue["video"] = videoValue;
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

    public static class DiscordBotExtensions
    {
        /// <summary>
        /// DiscordBot 인스턴스에 메시지 내용을 설정합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        /// <param name="content">메시지 내용</param>
        /// <returns>업데이트된 DiscordBot 인스턴스</returns>
        public static DiscordBot WithContent(this DiscordBot discordBot, string content)
        {
            discordBot.Options.Content = content;
            return discordBot;
        }

        /// <summary>
        /// DiscordBot 인스턴스에 사용자 이름을 설정합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        /// <param name="username">사용자 이름</param>
        /// <returns>업데이트된 DiscordBot 인스턴스</returns>
        public static DiscordBot WithUsername(this DiscordBot discordBot, string username)
        {
            discordBot.Options.Username = username;
            return discordBot;
        }

        /// <summary>
        /// DiscordBot 인스턴스에 아바타 URL을 설정합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        /// <param name="avatarUrl">아바타 URL</param>
        /// <returns>업데이트된 DiscordBot 인스턴스</returns>
        public static DiscordBot WithAvatarURL(this DiscordBot discordBot, string avatarUrl)
        {
            discordBot.Options.AvatarUrl = avatarUrl;
            return discordBot;
        }

        /// <summary>
        /// DiscordBot 인스턴스에 TTS 옵션을 설정합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        /// <param name="tts">TTS 옵션</param>
        /// <returns>업데이트된 DiscordBot 인스턴스</returns>
        public static DiscordBot WithTTS(this DiscordBot discordBot, bool tts)
        {
            discordBot.Options.tts = tts;
            return discordBot;
        }

        /// <summary>
        /// DiscordBot 인스턴스를 사용하여 메시지를 전송합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        public static void Send(this DiscordBot discordBot)
        {
            var request = discordBot.CreateWebRequest(discordBot.Options);
            request.SendWebRequest();
        }
    }
}