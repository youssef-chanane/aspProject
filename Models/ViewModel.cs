using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_ASP.Net.Models
{
    public class ViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public IEnumerable<Product> BestOffers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        
    }
}