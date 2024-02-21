using System;
using System.Collections.Generic;

namespace SampleDAL.DbModels;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public DateOnly? PublicationDate { get; set; }

    public int? CategoryId { get; set; }

    public int? AuthorId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Category? Category { get; set; }
}
