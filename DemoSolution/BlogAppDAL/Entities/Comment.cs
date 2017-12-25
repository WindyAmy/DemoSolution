using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogAppDAL.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
    }
}