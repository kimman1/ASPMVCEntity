using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NW.Views.ViewModel
{
    public class ProductViewModel
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
    
        public string Description { get; set; }
       
        public decimal Price { get; set; }
    
        public string Color { get; set; }
       
        public string Producer { get; set; }
       
        public string Image { get; set; }
       
        public string Creator { get; set; }

        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //public IEnumerable<ProductViewModel> ProductViewModelList { get; set; }
    }
}