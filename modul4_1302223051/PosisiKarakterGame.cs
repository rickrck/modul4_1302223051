using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223051
{
    internal class PosisiKarakterGame
    {
        enum Posisi { Jongkok, Berdiri, Tengkurap, Terbang };
        enum Tombol { TombolW, TombolS, TombolX };

        public static void Main()
        {
            Console.Write("Tekan Tombol");

            string perintah = Console.ReadLine();
            PosisiKarakterGame.Posisi posisi = PosisiKarakterGame.Posisi.Berdiri;

            while (perintah != "")
            {
                switch(posisi)
                {
                    /**case PosisiKarakterGame.Posisi.Berdiri:
                        if (perintah == "W")
                        {
                            posisi = Posisi.Terbang;
                        }
                */} 
            }
        }
    }
}
