namespace NKStudio.Discord
{
    public static class DiscordBotUtility
    {
        public static DiscordBot SetWebhook(this DiscordBot discordBot, string webhook)
        {
            discordBot.WebHookURL = webhook;
            return discordBot;
        }
        
        public static DiscordBot WithContent(this DiscordBot discordBot, string content)
        {
            discordBot.Options.content = content;
            
            return discordBot;
        }
        
        public static DiscordBot SetUsername(this DiscordBot discordBot, string username)
        {
            discordBot.Options.username = username;
            
            return discordBot;
        }
        
        public static Embed WithTitle(this Embed embed, string title)
        {
            embed.title = title;
            return embed;
        }
        
        public static Embed WithDescription(this Embed embed, string description)
        {
            embed.description = description;
            return embed;
        }
        
        public static Embed SetColor(this Embed embed, int color)
        {
            embed.color = color;
            return embed;
        }
        
        public static Embed SetColor(this Embed embed, string color)
        {
            embed.color = ColorUtils.ToColorCode(color);
            return embed;
        }
        
        public static Embed SetColor(this Embed embed, UnityEngine.Color32 color)
        {
            embed.color = ColorUtils.ToColorCode(color);
            return embed;
        }

        public static DiscordBot AddEmbed(this DiscordBot discordBot, Embed embed)
        {
            discordBot.Options.embeds = embed;
            return discordBot;
        }
        
        public static void Send(this DiscordBot discordBot)
        {
            var request = discordBot.CreateWebRequest(discordBot.Options);
            request.SendWebRequest();
        }
    }
}