namespace projeler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN : 1 ile 10 arasındaki (bu sayılar dahil) tek sayıların toplamını bulup sonucu ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız.

            try
            {
                int Sonuc = 0;
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        Sonuc += i;
                    }
                    
                }

                  Console.WriteLine("1 ile 10 arasındakı tek sayıların toplamı {0}'dır.",Sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
