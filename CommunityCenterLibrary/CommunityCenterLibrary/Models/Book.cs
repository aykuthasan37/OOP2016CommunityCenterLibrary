﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityCenterLibrary.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public virtual Client Client { get; set; }
    }
}