using EFCore1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        
    }
}
