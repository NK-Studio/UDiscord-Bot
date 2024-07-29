namespace NKStudio.Discord
{
    [System.Serializable]
    public class Embed
    {
        public string title;
        public string description;
        public int color;

        public static Embed Create()
        {
            return new Embed();
        }
    }
}