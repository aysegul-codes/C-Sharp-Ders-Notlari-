namespace proje16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan bir metnin her bir karakterini döngü ile işleyerek,
            //her adımda o ana kadar olan kısmın tersini ve düzünü yan yana yazdıran C# kodunu yazınız."
            try
            {
               
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string Sonuc = "";
                string sonuc2 = "";

               
                for (int i = 0; i < Metin.Length; i++)
                {
                    
                    Sonuc = Sonuc + Metin[i];
                    sonuc2 = Metin[i] + sonuc2;
                    Console.WriteLine(sonuc2 + " " + Sonuc);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                
                Console.WriteLine("\nÇıkmak için bir tuşa basın...");
                Console.ReadKey();
            }

        }
    }
}
