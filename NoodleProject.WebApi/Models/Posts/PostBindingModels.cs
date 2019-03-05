using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoodleProject.WebApi.Models
{
    public class PostBindingModel
    {
        public int ThreadID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }

        public PostBindingModel(int ThreadID, int UserID, string Text)
        {
            this.ThreadID = ThreadID;
            this.UserID = UserID;
            this.Text = Text;
        }
    }
}