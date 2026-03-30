namespace projeler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SAYI1;
            int SAYI2;
            string METİN1;
            string METİN2;
            int SONUC;

            Console.Write("1. Sayıyı Giriniz:");
            METİN1 = Console.ReadLine();
            SAYI1 = Convert.ToInt32(METİN1);

            Console.Write("2. Sayıyı Giriniz:");
            METİN2 = Console.ReadLine();
            SAYI2 = Convert.ToInt32(METİN2);

            SONUC = SAYI1 + SAYI2;
            Console.WriteLine(SONUC.ToString());


        }
    }
}
