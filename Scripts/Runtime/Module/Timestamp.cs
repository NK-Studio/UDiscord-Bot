using System;

namespace NKStudio.Discord.Module
{
    public class Timestamp
    {
        /// <summary>
        /// 타임스탬프입니다.
        /// </summary>
        internal DateTime Time;

        /// <summary>
        /// 타임스탬프 형식입니다.
        /// </summary>
        internal string Format = "yyyy-MM-ddTHH:mm:ssZ";

        /// <summary>
        /// 새로운 Timestamp 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="dateTime">타임스탬프를 설정할 DateTime 값 (기본값: DateTime.UtcNow)</param>
        /// <returns>새로운 Timestamp 인스턴스</returns>
        public static Timestamp Create(DateTime dateTime = default)
        {
            var timestamp = new Timestamp();
            timestamp.Time = dateTime == default ? DateTime.UtcNow : dateTime;
            return timestamp;
        }
    }

    public static class TimestampExtension
    {
        /// <summary>
        /// Embed 인스턴스에 타임스탬프를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="timestamp">추가할 Timestamp 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed AddTimestamp(this Embed embed, Timestamp timestamp)
        {
            embed.Timestamp = timestamp;
            return embed;
        }

        /// <summary>
        /// Timestamp 인스턴스의 형식을 설정합니다.
        /// </summary>
        /// <param name="timestamp">Timestamp 인스턴스</param>
        /// <param name="format">설정할 형식 (기본값: "yyyy-MM-ddTHH:mm:ssZ")</param>
        /// <returns>업데이트된 Timestamp 인스턴스</returns>
        public static Timestamp WithFormat(this Timestamp timestamp, string format = "yyyy-MM-ddTHH:mm:ssZ")
        {
            timestamp.Format = format;
            return timestamp;
        }
    }
}