using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHPLesson08.Models
{
    public class NhpBook
    {

        [Key]
        public int NhpBookId { get; set; }
        public string NhpTitle { get; set; }
        public string  NhpAuthor { get; set; }
        public int NhpYear { get; set; }
        public string NhpPublisher { get; set; }
        public string NhpPicture { get; set; }
        public int NhpCategoryId { get; set; }
    }
}