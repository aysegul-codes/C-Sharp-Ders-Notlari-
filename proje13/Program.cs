namespace proje13
{
    internal class Program
    {
        static void Main(string[] args)
        {       //ÖRN: Kullanıcı tarafından girilen bir metni ekrana tersten yazdıran konsol uygulamasının C# dilinde kodunu yazınız.
            

            try
            {
                Console.Write("Metni Giriniz: ");
                string Metin = Console.ReadLine();

                string TersMetin = "";
                for (int i = Metin.Length-1; i >=0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }

                Console.WriteLine("Girilen \"{0}\" metnin tersten yazılışı \"{1}\".",Metin, TersMetin );     // texsin içinde  \"{0}\" kullanmamızın sebebi "" içinde yazılmasını istediğimiz için.

            }

            catch(Exception ex)
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
