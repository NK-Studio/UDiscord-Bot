namespace NKStudio.Discord.Module
{
    public static class URLExtension
    {
        /// <summary>
        /// Embed 인스턴스에 URL을 설정합니다. [Requires: Title]
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="url">URL</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithURL(this Embed embed, string url)
        {
            embed.URL = url;
            return embed;
        }
    }
}