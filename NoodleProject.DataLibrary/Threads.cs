using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoodleProject.DataLibrary
{
    class Threads
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Title name")]
        public string Title { get; set; }
        [Display(Name = "Creation date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }
        [ForeignKey("associatedUser")]
        public int userID { get; set; }

        //public virtual ICollection<User> assiociatedUser { get; set; }
    }
}
