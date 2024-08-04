using UnityEngine;

namespace NKStudio.Discord
{
    public static class ColorUtils
    {
        /// <summary>
        /// Unity 색상을 Discord 색상으로 변환합니다.
        /// </summary>
        public static int ToColorCode(Color32 color)
        {
            return color.r * 256 * 256 + color.g * 256 + color.b;
        }

        /// <summary>
        /// HTML 색상을 Discord 색상으로 변환합니다.
        /// </summary>
        public static int ToColorCode(string htmlColor)
        {
            var color = ParseHtmlString(htmlColor, Color.magenta);
            return ToColorCode(color);
        }

        /// <summary>
        /// HTML 색상 문자열을 Unity 색상으로 파싱합니다.
        /// </summary>
        /// <param name="htmlColor">파싱할 HTML 색상 문자열입니다.</param>
        /// <param name="fallback">파싱에 실패할 경우 사용할 기본 색상입니다.</param>
        /// <returns>파싱된 Unity 색상 또는 파싱 실패 시 기본 색상입니다.</returns>
        private static Color ParseHtmlString(string htmlColor, Color fallback)
        {
            if (ColorUtility.TryParseHtmlString(htmlColor, out Color color))
                return color;

            return fallback;
        }
    }
}