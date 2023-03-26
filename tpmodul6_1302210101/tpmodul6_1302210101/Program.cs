// See https://aka.ms/new-console-template for more information
using tpmodul6_1302210101;

SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Maximus");
Console.WriteLine("Masukkan Berapa Kali Video Akan Dimainkan: ");
int play = Convert.ToInt32(Console.ReadLine());
video.IncreasePlayCount(play);
video.PrintVideoDetails();

