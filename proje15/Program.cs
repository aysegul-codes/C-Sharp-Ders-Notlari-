namespace proje15
{
    internal class Program
    {
        static void Main(string[] args)
        {       //ÖRN: Kullanıcı tarafından girilen bir metnin ilk harfinden başlayarak her satırda bir fazla harfini yazan
                //konsol uygulamasının C# dilinde kodunu yazınız.

            try
          {
              Console.Write("Metni Giriniz : ");
              string Metin = Console.ReadLine();

              string Sonuc = "";

              for (int i = 0; i < Metin.Length; i++)
              {
                     Sonuc += Metin[i].ToString();
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
