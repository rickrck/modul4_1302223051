public class Program
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka };

    public string getKodeBuah(NamaBuah namaBuah)
    {
        string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        return kodeBuah[(int)namaBuah];

    }

    static void Main()
    {
        Program objNamaBuah = new Program();
        Console.WriteLine("Nama Buah\t\tKode Buah");
        foreach (Program.NamaBuah namaBuah in Enum.GetValues(typeof(Program.NamaBuah)))
        {
            string kodeBuah = objNamaBuah.getKodeBuah(namaBuah);
            Console.WriteLine(namaBuah + "    \t\t" + kodeBuah);
        }
    }
}
