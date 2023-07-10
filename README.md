# Lab08-Phil’s-Lending-Library
## Summary
The "Phil's Lending Library" project is a C# library that provides classes to manage a lending library system. managing  book collection and keep track of borrowed books.
## Visuals
Here's a visual representation of how the "Phil's Lending Library" can be used:                                                   
       
          // Create a library and add some books
    Library library = new Library();
    library.Add("Book 1", "Author 1", "Last Name 1", 200);
    library.Add("Book 2", "Author 2", "Last Name 2", 150);

      // Borrow a book from the library
    Book borrowedBook = library.Borrow("Book 1");

    // Pack the borrowed book into a backpack
    Backpack<Book> backpack = new Backpack<Book>();
    backpack.Pack(borrowedBook);

    // Unpack the book from the backpack
    Book unpackedBook = backpack.Unpack(0);

    // Return the book to the library
    library.Return(unpackedBook);

        
## Usage
To use the "Phil's Lending Library" in your C# project, follow these steps:

- Download or clone the project from the repository.             
- Add a reference to the "Phil's Lending Library" project in your C# project.         
- Create an instance of the Library class to manage your lending library system.

        Library library = new Library();

- Use the Add method to add books to the library.

      library.Add("Book 1", "Author 1", "Last Name 1", 200);
      library.Add("Book 2", "Author 2", "Last Name 2", 150);

- Use the Borrow method to borrow books from the library.
 
      Book borrowedBook = library.Borrow("Book 1");

- Create an instance of the Backpack<T> class to hold borrowed items.
       
       Backpack<Book> backpack = new Backpack<Book>();

- Use the Pack method to add items to the backpack.

       backpack.Pack(borrowedBook);

- Use the Unpack method to remove items from the backpack.


      Book unpackedBook = backpack.Unpack(0);

       
- Use the Return method to return borrowed items to the library.

        library.Return(unpackedBook);


 By following these steps, you can effectively utilize Phil's Lending Library to manage a lending library system, including adding books, borrowing books, returning books, and packing/unpacking items in a backpack.


## Additional Details
- The Library class implements the ILibrary interface, providing methods to manage books in the library, including adding, borrowing, and returning books.
- The Backpack<T> class implements the IBag<T> interface, allowing the packing and unpacking of items in the backpack.
- The Library class internally uses a dictionary to store books, while the Backpack<T> class uses a list to store items.
- Books in the library can be borrowed by their title, and items in the backpack can be unpacked based on the specified index.
- The provided example demonstrates a basic usage of Phil's Lending Library, but you can customize it further to suit your specific requirements.
 
 ----------------
## In Conclusion 
*The library system should handle adding books, borrowing books, returning books, packing items into the backpack, and unpacking items from the backpack.*
