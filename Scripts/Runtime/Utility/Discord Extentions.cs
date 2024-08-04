namespace NKStudio.Discord
{
    #region DiscordBotExtensions

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

    #endregion

    #region EmbedExtensions

    public static class EmbedExtensions
    {
        /// <summary>
        /// DiscordBot 인스턴스에 Embed를 추가합니다.
        /// </summary>
        /// <param name="discordBot">DiscordBot 인스턴스</param>
        /// <param name="embed">Embed 인스턴스</param>
        /// <returns>업데이트된 DiscordBot 인스턴스</returns>
        public static DiscordBot AddEmbed(this DiscordBot discordBot, Embed embed)
        {
            discordBot.Options.Embeds = embed;
            return discordBot;
        }

        /// <summary>
        /// Embed 인스턴스에 제목을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="title">제목</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithTitle(this Embed embed, string title)
        {
            embed.title = title;
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 설명을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="description">설명</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithDescription(this Embed embed, string description)
        {
            embed.Description = description;
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 색상을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="color">색상</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed SetColor(this Embed embed, int color)
        {
            embed.Color = color;
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 색상을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="color">색상 문자열</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed SetColor(this Embed embed, string color)
        {
            embed.Color = ColorUtils.ToColorCode(color);
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 색상을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="color">UnityEngine.Color32 색상</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed SetColor(this Embed embed, UnityEngine.Color32 color)
        {
            embed.Color = ColorUtils.ToColorCode(color);
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 이미지 URL을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="imageURL">이미지 URL</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithImageURL(this Embed embed, string imageURL)
        {
            embed.ImageURL = imageURL;
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 URL을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="url">URL</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithURL(this Embed embed, string url)
        {
            embed.URL = url;
            return embed;
        }

        /// <summary>
        /// Embed 인스턴스에 썸네일 URL을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="thumbnailURL">썸네일 URL</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithThumbnailURL(this Embed embed, string thumbnailURL)
        {
            embed.ThumbnailURL = thumbnailURL;
            return embed;
        }
    }

    #endregion

    #region FooterExtensions

    public static class FooterExtensions
    {
        /// <summary>
        /// Embed 인스턴스에 Footer를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="footer">Footer 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed AddFooter(this Embed embed, Footer footer)
        {
            embed.Footer = footer;
            return embed;
        }

        /// <summary>
        /// Footer 인스턴스에 텍스트를 설정합니다.
        /// </summary>
        /// <param name="footer">Footer 인스턴스</param>
        /// <param name="text">텍스트</param>
        /// <returns>업데이트된 Footer 인스턴스</returns>
        public static Footer WithText(this Footer footer, string text)
        {
            footer.Text = text;
            return footer;
        }

        /// <summary>
        /// Footer 인스턴스에 아이콘 URL을 설정합니다.
        /// </summary>
        /// <param name="footer">Footer 인스턴스</param>
        /// <param name="iconURL">아이콘 URL</param>
        /// <returns>업데이트된 Footer 인스턴스</returns>
        public static Footer WithIconURL(this Footer footer, string iconURL)
        {
            footer.IconURL = iconURL;
            return footer;
        }
    }

    #endregion

    #region AuthorExtensions

    public static class AuthorExtensions
    {
        /// <summary>
        /// Embed 인스턴스에 Author를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="author">Author 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed AddAuthor(this Embed embed, Author author)
        {
            embed.Author = author;
            return embed;
        }

        /// <summary>
        /// Author 인스턴스에 이름을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="name">이름</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author WithName(this Author author, string name)
        {
            author.Name = name;
            return author;
        }

        /// <summary>
        /// Author 인스턴스에 URL을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="url">URL</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author WithURL(this Author author, string url)
        {
            author.URL = url;
            return author;
        }

        /// <summary>
        /// Author 인스턴스에 아이콘 URL을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="iconURL">아이콘 URL</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author WithIconURL(this Author author, string iconURL)
        {
            author.IconURL = iconURL;
            return author;
        }
    }

    #endregion
}