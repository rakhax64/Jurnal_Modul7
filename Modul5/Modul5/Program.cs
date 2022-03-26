using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{


    class SayaTubeUser
    {
        private int id;
        private String Username;

        private List<SayaTubeVideo> uploadedVideos;
        public SayaTubeUser(string Username)
        {



        }

        public int GetTotalVideoPlayCoun()
        {


        }

        public void AddVideo(SayaTubeVideo)
        {


        }

        public void PrintAllVideoPlaycount()
        {



        }
    }
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;

        }

        public void IncreasePlayCount(int n)
        {
            if (n <= 10000000)
            {
                for (playCount = 0; playCount <= n; playCount++)
                {

                }
                int z = 0;
                try
                {
                    z = checked(n + 10);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Check : " + e.ToString());
                    Console.WriteLine("Melebihi batas input");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}