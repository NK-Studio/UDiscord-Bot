using NKStudio.Discord.Module;

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

            if (!string.IsNullOrEmpty(url)) 
                video.URL = url;

            return video;
        }
    }

    public static class VideoExtensions
    {
        /// <summary>
        /// [Experimental] Embed 인스턴스에 비디오를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="video">비디오 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithVideo(this Embed embed, Experimental.Video video)
        {
            embed.Video = video;
            return embed;
        }

        /// <summary>
        /// 비디오 인스턴스에 URL을 설정합니다.
        /// </summary>
        /// <param name="video">비디오 인스턴스</param>
        /// <param name="url">비디오 URL</param>
        /// <returns>업데이트된 비디오 인스턴스</returns>
        public static Video WithURL(this Video video, string url)
        {
            video.URL = url;
            return video;
        }

        /// <summary>
        /// 비디오 인스턴스에 너비를 설정합니다.
        /// </summary>
        /// <param name="video">비디오 인스턴스</param>
        /// <param name="width">비디오 너비</param>
        /// <returns>업데이트된 비디오 인스턴스</returns>
        public static Video WithWidth(this Video video, int width)
        {
            video.Width = width;
            return video;
        }

        /// <summary>
        /// 비디오 인스턴스에 높이를 설정합니다.
        /// </summary>
        /// <param name="video">비디오 인스턴스</param>
        /// <param name="height">비디오 높이</param>
        /// <returns>업데이트된 비디오 인스턴스</returns>
        public static Video WithHeight(this Video video, int height)
        {
            video.Height = height;
            return video;
        }
    }
}