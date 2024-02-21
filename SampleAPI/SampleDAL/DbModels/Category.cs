﻿using System;
using System.Collections.Generic;

namespace SampleDAL.DbModels;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
