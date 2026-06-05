namespace PROJE21
{
    using System.Threading;
    internal class Program
    {
        static void Main(string[] args)
        {       //ÖRN : "\", "|", "-" ve "/" sembollerini kullanarak pervane etkisi gösteren (toplamda 100 defa dönen)
                //bir animasyon yapılmak istenmektedir.
                //Bunun için konsol uygulamasında gerekli olan C# kodunu yazınız.
            try
            {
                int DelayTime = 100;
                for (int i = 1; i <= 100; i++)
                {
                    Console.Clear();
                    Console.WriteLine("                    -");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    |");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    /");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    -");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    |");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    -");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    \\");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("                    |");
                    Thread.Sleep(DelayTime);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }

    }
}

