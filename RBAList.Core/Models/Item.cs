using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBAList.Core.Models
{
    public class Item
    {

        public Item()
        {
            Name = string.Empty;
            Description = string.Empty;
            UserId = string.Empty;            

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public double? AskingPrice { get; set; }
        public double? RetailPrice { get; set; }  
        public bool Sold { get; set; }
        public int? ImageId { get; set; }
        public string UserId { get; set; }

    }
}