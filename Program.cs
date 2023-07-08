namespace Lab08_Phil_s_Lending_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibrary library = new Library();
            library.Add("cooking", "manal", "alalem", 200);
            library.Add("animals", "john", "max", 150);
            library.Add("the rech dad and the poor dad", "alex", "jonshon", 300);
            Console.WriteLine(" our library contain the following books\n ");
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}\n");
            }
            Console.WriteLine("----------------------------------------------------------------- ");
            Book borrowedBook = library.Borrow("cooking");
            Console.WriteLine($"You Borrowed : {borrowedBook.Title}\n");
            Console.WriteLine(" our library now contain the following books\n ");
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}\n");
            }


            IBag<Book> backpack = new Backpack<Book>();
            backpack.Pack(borrowedBook);
            Console.WriteLine($"{borrowedBook.Title} packed into backpack\n.");

            
            Book unpackedBook = backpack.Unpack(0);
            Console.WriteLine($"Unpacked book: {unpackedBook.Title}\n");

            // Return the book to the library
            library.Return(unpackedBook);
            Console.WriteLine($"Thanks for returning {unpackedBook.Title} book  to the library.\n");
            Console.WriteLine("----------------------------------------------------------------- ");
            // Borrow a secound book
            Book borrowedBook2 = library.Borrow("animals");
            Console.WriteLine($"You Borrowed : {borrowedBook2.Title}\n");
            Console.WriteLine(" our library now contain the following books\n ");
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}\n");
            }
            Console.WriteLine("----------------------------------------------------------------- ");
            // Pack the borrowed book into a backpack
            IBag<Book> backpack2 = new Backpack<Book>();
            backpack2.Pack(borrowedBook2);
            Console.WriteLine($"{borrowedBook2.Title} packed into backpack.\n");
            
            // Unpack the book from the backpack
            Book unpackedBook2 = backpack2.Unpack(0);
            Console.WriteLine($"Unpacked book: {unpackedBook2.Title}\n");

            // Return the book to the library
            library.Return(unpackedBook2);
            Console.WriteLine($"Thanks for returning {unpackedBook2.Title} book  to the library.\n");
        }
    }
    }
