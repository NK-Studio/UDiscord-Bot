namespace NKStudio.Discord.Module
{
    public static class TitleExtension
    {
        /// <summary>
        /// Embed 인스턴스에 제목을 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="title">추가할 제목</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithTitle(this Embed embed, string title)
        {
            embed.Title = title;
            return embed;
        }
    }
}