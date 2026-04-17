namespace proje11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖRN:Kullanıcı tarafından girilen bir metnin her bir kelmisenin baş harfını alarak araya nokta koyup kısaltmasını ekrana yazdıran konsol uygulamasının C# dilinde kodu yazınız.

            try
            {
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string[] kelimeDizisi = Metin.Split(' ');

                string Kisaltma = "";

                foreach (string kelime in kelimeDizisi)
                {
                    Kisaltma += kelime[0].ToString() + ".";
                }

                Console.WriteLine(Kisaltma.ToUpper());
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
