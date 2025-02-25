using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using PubContext _context = new();

//GetAuthors();
//QueryFilters();
//FindIt();
//AddSomeMoreAuthors();
SkipAndTakeAuthors();

void SkipAndTakeAuthors()
{
    var groupSize = 2;
    for (var i = 0; i < 9; i++)
    {
        var authors = _context.Authors.Skip(i * groupSize).Take(groupSize).ToList();
    }
}

void AddSomeMoreAuthors()
{
    _context.Authors.Add(new Author { FirstName = "Rastko", LastName = "Jovic"});
    _context.Authors.Add(new Author { FirstName = "Dusan", LastName = "Kicanovic" });
    _context.Authors.Add(new Author { FirstName = "Jovan", LastName = "Cvijic" });
    _context.Authors.Add(new Author { FirstName = "Stefan", LastName = "Hvar" });

    _context.SaveChanges();
}

void FindIt()
{
    var authorIdTwo = _context.Authors.Find(2);
}

void QueryFilters()
{
    //var firstname = "William";
    //var authors = _context.Authors.Where(a => a.FirstName == firstname).ToList();
    var filter = "K%";
    var authors = _context.Authors.Where(a => EF.Functions.Like(a.LastName, filter)).ToList();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}
