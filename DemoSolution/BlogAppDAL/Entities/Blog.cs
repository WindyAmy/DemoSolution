using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogAppDAL.Entities
{
    public partial class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}