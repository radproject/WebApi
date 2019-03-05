using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoodleProject.WebApi.Models
{
    public class CreatePostBindingModel
    {
        public int ThreadID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }

        public CreatePostBindingModel(int ThreadID, int UserID, string Text)
        {
            this.ThreadID = ThreadID;
            this.UserID = UserID;
            this.Text = Text;
        }
    }

    public class UpdatePostBindingModel
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public UpdatePostBindingModel(int ID, string Text)
        {
            this.ID = ID;
            this.Text = Text;
        }
    }
}