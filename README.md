# Lab08-Phil’s-Lending-Library
## Summary
The "Phil's Lending Library" project is a C# library that provides classes to manage a lending library system. managing  book collection and keep track of borrowed books.
## Visuals
Here's a visual representation of how the "Phil's Lending Library" can be used:                                                   
       
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
        
## Usage
To use the "Phil's Lending Library" in your C# project, follow these steps:

Download or clone the project from the repository.             
Add a reference to the "Phil's Lending Library" project in your C# project.         
Create an instance of the Library class to manage your lending library system.          
Use the Add method to add books to the library.
Use the Borrow method to borrow books from the library.
Create an instance of the Backpack<T> class to hold borrowed items.
Use the Pack method to add items to the backpack.
Use the Unpack method to remove items from the backpack.
Use the Return method to return borrowed items to the library.