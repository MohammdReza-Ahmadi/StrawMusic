using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Users
{
    public class Comment
    {
        public int Id { get; set; }
        public string Tittel { get; set; }
        public string Text { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public int Status { get; set; }
        public string Rating { get; set; }
    }
}
