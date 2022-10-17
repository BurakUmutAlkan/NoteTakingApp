using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Data.Entities
{
    [Table("Notes")]
    public class Note
    {
        public Note()
        {
            CreationTime = DateTime.Now;
            ModifiedTime = DateTime.Now;
            CategoryID = null;
        }

        [Key]
        public int ID { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset? ModifiedTime { get; set; }

        public Category Category { get; set; }
    }
}
