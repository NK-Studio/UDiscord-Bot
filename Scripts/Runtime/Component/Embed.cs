namespace NKStudio.Discord
{
    [System.Serializable]
    public class Embed
    {
        /// <summary>
        /// 임베드의 제목입니다.
        /// </summary>
        internal string title;
        
        /// <summary>
        /// 임베드의 설명입니다.
        /// </summary>
        internal string Description;
        
        /// <summary>
        /// 임베드의 색상입니다.
        /// </summary>
        internal int Color;
        
        /// <summary>
        /// 임베드의 저자 정보입니다.
        /// </summary>
        internal Author Author;
        
        /// <summary>
        /// 임베드의 푸터 정보입니다.
        /// </summary>
        internal Footer Footer;
        
        /// <summary>
        /// 임베드의 이미지 URL입니다.
        /// </summary>
        internal string ImageURL;
        
        /// <summary>
        /// 임베드의 URL입니다.
        /// </summary>
        internal string URL;
        
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
}