namespace NKStudio.Discord.Module
{
    public static class ImageExtension
    {
        /// <summary>
        /// Embed 인스턴스에 이미지를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="path">이미지 경로</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithImage(this Embed embed, string path)
        {
            embed.Image = path;
            return embed;
        }
    }
}