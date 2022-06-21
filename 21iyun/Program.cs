using System;

namespace _21iyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book()
            {
                Name = "Siddharta",
                AuthorName = "Herman Hesse",
                PageCount = 103
            };
            Book book1 = new Book()
            {
                Name = "Death on the Nile",
                AuthorName = "Aghata Christie",
                PageCount = 96
            };
            library.AddBook(book);
            library.AddBook(book1);

            foreach (var item in library.FindAllBooksByName("idd"))
            {
                Console.WriteLine(item.Name+" "+ item.AuthorName);
            }
            library.RemoveAllBooksByName("Death");
            foreach (var item in library.bookList()
)
            {
                Console.WriteLine(item.Name);
            }

            


        }
    }
}
