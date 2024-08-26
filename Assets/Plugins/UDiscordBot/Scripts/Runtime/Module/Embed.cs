namespace NKStudio.Discord.Module
{
    [System.Serializable]
    public class Embed
    {
        /// <summary>
        /// 임베드의 제목입니다.
        /// </summary>
        internal string Title;

        /// <summary>
        /// 임베드의 설명입니다.
        /// </summary>
        internal string Description;

        /// <summary>
        /// 임베드의 색상입니다.
        /// </summary>
        internal int? Color;

        /// <summary>
        /// 임베드의 저자 정보입니다.
        /// </summary>
        internal Author Author;

        /// <summary>
        /// 임베드의 푸터 정보입니다.
        /// </summary>
        internal Footer Footer;

        /// <summary>
        /// 임베드의 비디오 정보입니다.
        /// </summary>
        internal Experimental.Video Video;

        /// <summary>
        /// 임베드의 이미지 URL입니다.
        /// </summary>
        internal string Image;

        /// <summary>
        /// 임베드의 URL입니다.
        /// </summary>
        internal string URL;

        internal Timestamp Timestamp;

        /// <summary>
        /// 임베드의 썸네일 URL입니다.
        /// </summary>
        internal string ThumbnailURL;

        /// <summary>
        /// 새로운 Embed 인스턴스를 생성합니다.
        /// </summary>
        /// <returns>새로운 Embed 인스턴스</returns>
        public static Embed Create()
        {
            return new Embed();
        }
    }

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
        /// Embed 인스턴스에 설명을 설정합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="description">설명</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed AddDescription(this Embed embed, string description)
        {
            embed.Description = description;
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
}