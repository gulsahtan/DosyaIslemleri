using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string dosyaYolu = "C:\\KlasorAdim\\dosyam.txt";
            //string dosyaYolu2 = @"C:\KlasorAdim\dosyam.txt";
            ////Console.WriteLine(dosyaYolu);
            ////Console.WriteLine(dosyaYolu2);

            //string klasorYolu = @"C:\KlasorAdim";
            //string dosyaYolu3 = "Notlar.txt";

            //string tamDosyaYolu = Path.Combine(klasorYolu, dosyaYolu3);

            ////Console.WriteLine(tamDosyaYolu);

            //Console.WriteLine(Path.GetFileName(tamDosyaYolu));
            //Console.WriteLine(Path.GetExtension(tamDosyaYolu));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(tamDosyaYolu));
            //Console.WriteLine(Path.GetDirectoryName(tamDosyaYolu));


            //string belgeler = Environment.GetFolderPath(
            //    Environment.SpecialFolder.MyDocuments
            //    );
            //string klasorYolu1 = Path.Combine(belgeler, "BelgelerKlasorum");
            //string dosyaYolu4 = Path.Combine(klasorYolu1, "Notlar.docx");


            string klasor = @"C:\NesneTabanliProgramlama";


            if (Directory.Exists(klasor))
            {

            }
            else
            {
                Directory.CreateDirectory(klasor);

            }

            string dosyaYolu = @"C:\NesneTabanliProgramlama\Notlar.txt";

            using (FileStream dosya = File.Create(dosyaYolu))
            {
                Console.WriteLine("Dosya oluştu");
            }

            File.WriteAllText(dosyaYolu, "Gülşah - 65");
            File.AppendAllText(dosyaYolu, "\nAyşe - 90");
            File.AppendAllText(dosyaYolu,Environment.NewLine+ "Ahmet - 70");

            string icerik =File.ReadAllText(dosyaYolu);
            Console.WriteLine(icerik);

            string[] icerikler= File.ReadAllLines(dosyaYolu);

            foreach (string line in icerikler)
            {
                Console.WriteLine(line);
            }




        }
    }
}
