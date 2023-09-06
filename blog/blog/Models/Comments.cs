using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blog
{
    public class Comments
    {
        public int Id { get; set; }
        public string Tittel { get; set; }
        public string Text { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public int Status { get; set; }
        public int Rating { get; set; }
    }
}
