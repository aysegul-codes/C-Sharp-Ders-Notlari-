namespace proje8
{
    internal class Program
    {
        static void Main(string[] args)
        {           // ÖRN: 1 ile 10 arasındaki sayılardan (bu sayılar dahil) 3’e veya 5’e tam bölünen sayıları bularak araya boşluk koyup ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız.
            try
            {
                string Sonuc = "";
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        Sonuc += i.ToString() + " ";
                    }
                }

                Console.WriteLine("1 ile 10 arasındaki 3'e veya 5'e tam bölünen sayılar : {0}", Sonuc.Trim());
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

