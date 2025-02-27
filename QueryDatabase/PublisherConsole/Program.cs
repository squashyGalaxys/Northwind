using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using PubContext _context = new();

var nyAuthors = new List<Author>
{
        new Author { FirstName = "Rita",LastName="Olsson"},
        new Author { FirstName = "Sofia", LastName = "Smith" },
        new Author { FirstName = "Ursula", LastName = "Levin" },
        new Author { FirstName = "Harry", LastName = "Howey" },
        new Author { FirstName = "Isabelle", LastName = "Allie" }
};

GetAuthors();
//QueryFilters();
//FindIt();
//AddSomeMoreAuthors();
//SkipAndTakeAuthors();
Console.WriteLine("__________________________________________________");
//SortAuthors();
//QueryAggreagate();
//RetriveAndUpdateAuthor();
//RetriveAndUpdateMultipleAuthor();
//VariousOperations();
//DeleteAnAuthor();
InsertMultipleAuthors();
InsertMultipleAuthorsPassedIn(nyAuthors);

void InsertMultipleAuthorsPassedIn(List<Author> nyAuthors)
{
    _context.Authors.AddRange(nyAuthors);
    _context.SaveChanges();
}

void InsertMultipleAuthors()
{
    var newAuthors = new List<Author>
    {
        new Author { FirstName = "Dusan", LastName = "Kicanovic" },
        new Author { FirstName = "Nevena", LastName = "Radmilovic" },
        new Author { FirstName = "Jovan", LastName = "Cvijic" },
        new Author { FirstName = "Stefan", LastName = "Hvar" }
    };
    _context.Authors.AddRange(newAuthors);
    _context.SaveChanges();

}

GetAuthors();

void DeleteAnAuthor()
{
    var extraNR = _context.Authors.Find(3);

    if (extraNR != null)
    {
        _context.Authors.Remove(extraNR);
        _context.SaveChanges();
    }
  
}

void VariousOperations()
{
    var author = _context.Authors.Find(2); //Detta kommer att returnera Nevena Radmilovic
    author.LastName = "Kicanovic";

    var newAuthor = new Author { FirstName = "Dan", LastName = "Alvsson" };
    _context.Authors.Add(newAuthor);

    _context.SaveChanges();
}

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
