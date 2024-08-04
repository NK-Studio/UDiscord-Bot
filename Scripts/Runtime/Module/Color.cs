using UnityEngine;

namespace NKStudio.Discord.Module
{
    public static class ColorExtension
    {
        /// <summary>
        /// Embed 인스턴스에 컬러를 추가합니다. [Requires: Title or Description]
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="color">컬러 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed AddColor(this Embed embed, Color32 color)
        {
            embed.Color = ToColorCode(color);
            return embed;
        }

        /// <summary>
        /// Unity 색상을 Discord 색상으로 변환합니다.
        /// </summary>
        private static int ToColorCode(Color32 color)
        {
            return color.r * 256 * 256 + color.g * 256 + color.b;
        }
    }
}