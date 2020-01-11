using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relationship_deneme.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BookVote { get; set; }
        public int Count { get; set; }
    }
}
