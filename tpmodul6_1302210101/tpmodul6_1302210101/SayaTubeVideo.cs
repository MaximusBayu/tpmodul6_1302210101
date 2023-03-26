using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

            Contract.Requires(this.title != null, "Judul video tidak boleh kosong");
            Contract.Requires(this.title.Length <= 100, "Judul video maksimal 100 karakter");
            Random random = new Random();
            this.id = random.Next(100000);
            this.title = title;
            this.playCount = 0;
            
        }
        
        public void IncreasePlayCount(int play) {
            Contract.Requires(playCount >= 0 && playCount <= 10000000, "Input 0 hingga 10.000.000");
            try
            {
                checked
                {
                    this.playCount += play;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails() {
            Console.WriteLine("ID\t\t:"+id);
            Console.WriteLine("Judul\t\t:"+title);
            Console.WriteLine("Jumlah Diputar\t:"+playCount);
        }
    }
}
