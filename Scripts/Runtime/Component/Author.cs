namespace NKStudio.Discord
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
            author.Name = name;
            return author;
        }
    }
}