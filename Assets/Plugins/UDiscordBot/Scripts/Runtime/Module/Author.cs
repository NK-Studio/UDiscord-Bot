namespace NKStudio.Discord.Module
{
    public class Author
    {
        /// <summary>
        /// 저자의 이름입니다.
        /// </summary>
        internal string Name;

        /// <summary>
        /// 저자의 URL입니다.
        /// </summary>
        internal string URL;

        /// <summary>
        /// 저자의 아이콘 URL입니다.
        /// </summary>
        internal string IconURL;

        /// <summary>
        /// 새로운 Author 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="name">저자의 이름</param>
        /// <returns>새로운 Author 인스턴스</returns>
        public static Author Create(string name = "")
        {
            var author = new Author();

            if (!string.IsNullOrEmpty(name)) 
                author.Name = name;
            
            return author;
        }
    }

    public static class AuthorExtension
    {
        /// <summary>
        /// Embed 인스턴스에 Author를 추가합니다.
        /// </summary>
        /// <param name="embed">Embed 인스턴스</param>
        /// <param name="author">Author 인스턴스</param>
        /// <returns>업데이트된 Embed 인스턴스</returns>
        public static Embed WithAuthor(this Embed embed, Author author)
        {
            embed.Author = author;
            return embed;
        }

        /// <summary>
        /// Author 인스턴스에 이름을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="name">이름</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author SetName(this Author author, string name)
        {
            author.Name = name;
            return author;
        }

        /// <summary>
        /// Author 인스턴스에 URL을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="url">URL</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author WithURL(this Author author, string url)
        {
            author.URL = url;
            return author;
        }

        /// <summary>
        /// Author 인스턴스에 아이콘 URL을 설정합니다.
        /// </summary>
        /// <param name="author">Author 인스턴스</param>
        /// <param name="iconURL">아이콘 URL</param>
        /// <returns>업데이트된 Author 인스턴스</returns>
        public static Author WithIconURL(this Author author, string iconURL)
        {
            author.IconURL = iconURL;
            return author;
        }
    }
}