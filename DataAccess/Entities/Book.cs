﻿using DataAccess.Entities.Base;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Book : AuditableEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Rate { get; set; }
        public string ImageSource { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<BookTransaction> BookTransactions { get; set; }
        public bool IsBorrowed { get; set; }
        public bool InGoodCondition { get; set; }
        public bool IsPainted { get; set; }
        public int СlickCount { get; set; }

        public Book()
        {
            Comments = new List<Comment>();
            BookTransactions = new List<BookTransaction>();
        }
    }
}