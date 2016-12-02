using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FesLibrary.Models
{
    [Table("items")]
    public class CatalogueItem
    {
        public long ID { get; set; }
        public string Title {get; set;}
        public string Authors { get; set; }
        public string Status { get; set; }
        public string Borrower { get; set; }
        public string DueDate { get; set; }
    }
}