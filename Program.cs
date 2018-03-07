using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace undertsand_loops
{
    class Program
    {
        static void Main(string[] args)
        {
           

            worker isci = new worker();
            isci.Name = "Cavidan";
            isci.SurName = "Ekberov";
            isci.maas = 1000;
            Console.WriteLine("Iscinin Gun Sayisini Daxil Edin");
            isci.gunSayisi = Convert.ToInt32(Console.ReadLine());
            isci.bonusHesabla();

        }

    }

    class worker
    {
        public string Name;
        public string SurName;
        public int maas;
        public int gunSayisi;
        public int bonus;
        public int elaveGun;
        public int eksiyGun;

        public void bonusHesabla()
        {
           

                if (gunSayisi > 30)

                    {
                        elaveGun = gunSayisi - 30;
                        bonus = elaveGun * 100;
                        Console.WriteLine(Name + " " + SurName + ": " + " Elave Iwlediyi Ucun Iscinin Alacaqi Mass " + (this.maas + bonus));
                    }

                else if (gunSayisi == 30)

                    {
                         Console.WriteLine(Name + " " + SurName + ": " + " Eksik ve Elave Olmadigi Ucun " + (this.maas));
                    }

                 else

                    {
                        eksiyGun = 30 - gunSayisi;
                        bonus = eksiyGun * 50;
                        Console.WriteLine(Name + " " + SurName + " " + " Eksik Iwlediyi Ucun Iscinin Alacaqi Maas " + (this.maas - bonus));
                    }
             
           
        }
    }
}
