using PublisherData;
using PublisherDomain;

using (PubContext context=new PubContext())
{
    context.Database.EnsureCreated();
}

GetAuthors();
AddAuthor();
GetAuthors();


void AddAuthorWithBook()
{
    using (PubContext context = new PubContext())
    {
        Author author = new Author
        {
            FirstName = "Mozart",
            LastName = "La Para"
        };
        Book book = new Book
        {
            Title = "El Papa del Rap",
            Author = author
        };
        author.Books.Add(book);
        context.Authors.Add(author);
        context.SaveChanges();
    }
}

void AddAuthorWithBooks()
{
    using (PubContext context = new PubContext())
    {
        Author author = new Author
        {
            FirstName = "Ludwig",
            LastName = "Van Bethoven"
        };
        Book book1 = new Book
        {
            Title = "1era sinfonia",
            Author = author
        };
        Book book2 = new Book
        {
            Title = "5ta sinfonia",
            Author = author
        };
        author.Books.Add(book1);
        author.Books.Add(book2);
        context.Authors.Add(author);
        context.SaveChanges();
    }
}

    void AddAuthor()
{
    using (PubContext context = new PubContext())
    {
        Author author = new Author
        {
            FirstName = "Ludwig",
            LastName = "Van Bethoven"
        };
        context.Authors.Add(author);
        context.SaveChanges();
    }
}


void GetAuthors()
{
    using (PubContext context = new PubContext())
    {
        var authors = context.Authors.ToList();
        foreach (var author in authors)
        {
            Console.WriteLine(author.FirstName + " " + author.LastName);
        }
    }
}