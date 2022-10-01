namespace Second
{
    public class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Name = "Макар";
            Content content = new Content();
            content.Info = "Проза";
            Title title = new Title();
            title.Name = "Бавовна";
            Book book = new Book(author.Name, content.Info, title.Name);
            Console.WriteLine(book.Show());
        }

    }
}