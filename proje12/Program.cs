namespace proje12
{
    internal class Program
    {
        public static object? Sayi { get; private set; }

        static void Main(string[] args)
        {
            // 1'e ve kendisinden başka hiçbir sayıya tam olarak bölünmeyen  sayılara asal sayı denir.
            // BUNA GÖRE kullanıcı tarafından girilen bir sayının asal sayı olup olmadığını bularak ekrana "ASALDIR" ya da "ASAL DEĞİLDİR"
            // Yazan konsol uygulamasını C# dilinde kodu yazınız.
            // NOT:   Kullanıcı 2 'den büyük (3 ve yukarı) sayı girmektedir.

            try
            {
                Console.WriteLine("Sayıyı giriniz : ");
                string Metin = Console.ReadLine();
                int Sayi = Convert.ToInt32(Metin);

                bool AsalMİ = true;

                for (int i = 2; i < Sayi; i++)
                {
                    if (Sayi % i == 0)
                    {
                        AsalMİ = false;
                    }
                }
                if (AsalMİ == true)
                {
                    Console.WriteLine("{0} sayısı asaldır.", Sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal değildir.", Sayi);

                }
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
