using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relationship_deneme.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Bookname { get; set; }
        public string PageCount { get; set; }
      
        public int AuthorId { get; set; }
        public Author Author { get; set; }


        public Vote Vote{ get; set; }
        public List<Page> Pages { get; set; }
    }
}
