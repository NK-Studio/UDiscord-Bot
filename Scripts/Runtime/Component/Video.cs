namespace NKStudio.Discord.Experimental
{
    /// <summary>
    /// 실험적인 비디오 클래스입니다.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// 비디오 URL입니다.
        /// </summary>
        public string URL;
        
        /// <summary>
        /// 비디오의 너비입니다.
        /// </summary>
        public int? Width;
        
        /// <summary>
        /// 비디오의 높이입니다.
        /// </summary>
        public int? Height;
        
        /// <summary>
        /// 비디오 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="url">비디오 URL (기본값: 빈 문자열)</param>
        /// <returns>생성된 비디오 인스턴스</returns>
        public static Video Create(string url = "")
        {
            var video = new Video();
            video.URL = url;
            return video;
        }
    }
}