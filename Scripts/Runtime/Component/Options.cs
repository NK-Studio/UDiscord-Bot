
namespace NKStudio.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params
    /// </summary>
    public struct Options
    {
        /// <summary>
        /// 메시지 텍스트. (선택 사항)
        /// </summary>
        internal string Content;
        
        /// <summary>
        /// 웹훅의 사용자 이름을 재정의합니다. (선택 사항)
        /// </summary>
        internal string Username;

        /// <summary>
        /// 아바타 URL. (선택 사항)
        /// </summary>
        internal string AvatarUrl;

        /// <summary>
        /// 텍스트 음성 변환 여부. (선택 사항)
        /// </summary>
        internal bool tts;
        
        /// <summary>
        /// 임베드 메시지. (선택 사항)
        /// </summary>
        internal Embed Embeds;
    }
}