namespace projeler3
{
    internal class Program
    {
        static void Main(string[] args)
        {      //ÖRN : 1 ile 10 arasındaki sayıların (bu sayılar dahil) toplamını bulup sonucu ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız.


            try
            {
                int Sonuc = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Sonuc += i;
                }
                Console.WriteLine("1 ile 10 arasındaki sayıların toplamı {0}", Sonuc);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
