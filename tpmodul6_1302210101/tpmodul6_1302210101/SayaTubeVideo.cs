using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210101
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title) {
            Random random = new Random();
            this.id = random.Next(100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int play) {
            this.playCount = play;
        }

        public void PrintVideoDetails() {
            Console.WriteLine("ID\t\t:"+id);
            Console.WriteLine("Judul\t\t:"+title);
            Console.WriteLine("Jumlah Diputar\t:"+playCount);
        }
    }
}
