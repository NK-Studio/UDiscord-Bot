namespace NKStudio.Discord
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
            footer.Text = text;
            return footer;
        }
    }
}