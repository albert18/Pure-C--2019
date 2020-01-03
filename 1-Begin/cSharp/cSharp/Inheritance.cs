using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    class Inheritance
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Inheritance()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Dennis Panjuta";
        }

        public Inheritance(string title, bool isPublic, string sendByUserName)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUserName);
        }
    }
}
