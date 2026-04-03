namespace proje7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖRN : Kullanıcı tarafından girilen pozitif bir tam sayının kendisi kadar kuvvetini alarak sonucunu ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız (ÖRN : 3  3 x 3 x 3 = 27).

            try
            {
                Console.Write("Sayıyı Giriniz : ");
                string Metin = Console.ReadLine();
                int Sayi = Convert.ToInt32(Metin);
                int Sonuc = 1;

                for (int i = 1; i <= Sayi; i++)
                {
                    Sonuc *= Sayi;
                }

                Console.WriteLine("{0} sayısının kendisi kadar kuvveti {1} 'dir.", Sayi, Sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
