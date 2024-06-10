using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHPLesson08.Models
{
    public class NhpCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        // thuoc tinh quan he
        public virtual ICollection<NhpBook> NhpBooks { get; set; }
    }
}