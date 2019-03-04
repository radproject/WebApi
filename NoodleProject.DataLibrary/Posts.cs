using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoodleProject.DataLibrary
{
    class Posts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("associatedThread")]
        public int ThreadID { get; set; }
        [ForeignKey("associatedUser")]
        public int UserID { get; set; }
        [Display(Name = "Text")]
        public string Text { get; set; }
        [Display(Name = "Time stamp")]
        public int TimeStamp { get; set; }

        public virtual Thread associatedThread { get; set; }
        /*public virtual User associatedUser { get; set; }*/


    }
}
