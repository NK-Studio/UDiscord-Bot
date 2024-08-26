namespace NKStudio.Discord.Module
{
    public class Footer
    {
        /// <summary>
        /// 푸터의 텍스트입니다.
        /// </summary>
        internal string Text;

        /// <summary>
        /// 푸터의 아이콘 URL입니다.
        /// </summary>
        internal string IconURL;

        /// <summary>
        /// 새로운 Footer 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="text">푸터의 텍스트</param>
        /// <returns>새로운 Footer 인스턴스</returns>
        public static Footer Create(string text = "")
        {
            var footer = new Footer();

            if (!string.IsNullOrEmpty(text)) 
                footer.Text = text;

            return footer;
        }
    }

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
        public static Footer SetText(this Footer footer, string text)
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
}