using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_more_about_OOP
{
    class Program
    {
        public interface INotification
        {
            void showNotification();
            string getDate();
        }

        public class Notification : INotification
        {
            private string sender;
            private string message;
            private string date;

            public Notification()
            {
                sender = "Admin";
                message = "Whats Up?";
                date = " ";
            }

            public Notification(string mySender, string myMessage, string myDate)
            {
                sender = mySender;
                message = myMessage;
                date = myDate;
            }

            public string getDate()
            {
                return date;
            }

            public void showNotification()
            {
                Console.WriteLine("Message {0} {1} {2}", message,sender,date);
            }
        }

        static void Main(string[] args)
        {
            #region Inheritance
            //Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            //Console.WriteLine(post1.ToString());

            //ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta",
            //    "https://images.com/shoes", true);

            //VideoPost videoPost1 = new VideoPost("FailVideo", "Denis Panjuta",
            //    "https://video.com/failvideo", true, 10);

            //Console.WriteLine(imagePost1.ToString());
            //Console.WriteLine(videoPost1.ToString());

            //videoPost1.Play();
            //Console.WriteLine("Press any key to stop the video!");
            //Console.ReadKey();
            //videoPost1.Stop();
            //Console.ReadLine(); 
            #endregion

            #region Interfaces
            Notification n = new Notification("me", "Something", "Some datee");
            n.showNotification();


            Console.ReadLine();
            #endregion
        }
    }
}
