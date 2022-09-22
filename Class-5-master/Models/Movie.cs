using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<string> Genres{ get; set; }
    }
}
