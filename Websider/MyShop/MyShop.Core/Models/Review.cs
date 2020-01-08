using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Core.Models
{
    public class Review : BaseEntity
    {
        [DataType(DataType.MultilineText)]
        public string ReviewText { get; set; }
        [Range(0, 5)]
        public decimal Rating { get; set; }
        public string CustomerName { get; set; }
        public string ProductId { get; set; }
    }
}
