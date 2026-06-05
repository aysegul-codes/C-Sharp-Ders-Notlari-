namespace proje19
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Kullancı tarafından girilen sayır sayısı kadar her satırda bir fazla * sembolu ekleyerek
           // ekran yazan konsol uygulamasını C# dilinde kodu yazınız.

            try
            {
                Console.Write("Satır Sayısını Giriniz:");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                string Sonuc = string.Empty;
                for (int i = 0; i < Sayi; i++)
                {
                    Sonuc += "*";
                    Console.WriteLine(Sonuc);
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

    

   


     
