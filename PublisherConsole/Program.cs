using PublisherData;
using PublisherDomain;

using (PubContext context=new PubContext())
{
    context.Database.EnsureCreated();
}

GetAuthors();
AddAuthor();
GetAuthors();

void AddAuthor()
{
    using (PubContext context = new PubContext())
    {
        Author author = new Author
        {
            FirstName = "Mozart",
            LastName = "La Para"
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