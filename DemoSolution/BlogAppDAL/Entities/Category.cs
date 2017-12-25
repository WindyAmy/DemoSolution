using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogAppDAL.Entities
{
    public partial class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
    }
}