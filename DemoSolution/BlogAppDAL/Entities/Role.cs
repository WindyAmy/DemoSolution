using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogAppDAL.Entities
{
   public partial class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }
    }
}
