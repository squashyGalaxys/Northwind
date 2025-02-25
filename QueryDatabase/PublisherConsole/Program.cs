using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using PubContext _context = new();

GetAuthors();
//QueryFilters();
//FindIt();
//AddSomeMoreAuthors();
//SkipAndTakeAuthors();
Console.WriteLine("__________________________________________________");
//SortAuthors();
//QueryAggreagate();
//RetriveAndUpdateAuthor();
RetriveAndUpdateMultipleAuthor();

void RetriveAndUpdateMultipleAuthor()
{
    var KicanovicAuthors = _context.Authors
        .Where(a => a.LastName == "Kicanovic").ToList();
    foreach(var author in KicanovicAuthors)
    {
        author.LastName = "Radmilovic";
    }
    _context.SaveChanges();
}

void RetriveAndUpdateAuthor()
{
    var author = _context.Authors
        .FirstOrDefault(a => a.FirstName == "Dusan" && a.LastName == "Kicanovic");

    if (author != null)
    {
        author.LastName = "Radmilovic";
        _context.SaveChanges();
    }

}

void QueryAggreagate()
{
    var author = _context.Authors
        .OrderBy(a => a.FirstName)
        .FirstOrDefault(a => a.LastName == "Kicanovic");
}

void SortAuthors()
{
    //var authorsByLastName = _context.Authors
    //    .OrderBy(a => a.LastName)
    //    .ThenBy(a => a.FirstName).ToList();
    //authorsByLastName.ForEach(a => Console.WriteLine(a.LastName + " " + a.FirstName));

    var authorsDescending = _context.Authors
        .OrderByDescending(a => a.LastName)
        .ThenByDescending(a => a.FirstName).ToList();
    Console.WriteLine("*Descending Last and First Name*");
    authorsDescending.ForEach(a => Console.WriteLine(a.LastName + " " + a.FirstName));

}

void SkipAndTakeAuthors()
{
    var groupSize = 3;
    for (var i = 0; i < 5; i++)
    {
        var authors = _context.Authors.Skip(i * groupSize).Take(groupSize).ToList();
        Console.WriteLine("=============");
        Console.WriteLine("Group " + (i + 1));
        Console.WriteLine("=============");
        foreach (var author in authors)
        {
            Console.WriteLine(author.FirstName + " " + author.LastName);
        }
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
