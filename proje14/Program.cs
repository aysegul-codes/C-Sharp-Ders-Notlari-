namespace proje14
{
    internal class Program
    {
        static void Main(string[] args)
        {   // ÖRN:kullanıcı tarafından girilen bir metnin palindrom olup olmadığını bularak ekrana
            // “Palindrom” ya da “Palindrom değil” yazan konsol uygulamasının C# dilinde kodunu yazınız.
            try
            {
                Console.Write("Metni Giriniz: ");
                string Metin = Console.ReadLine();

                string TersMetin = "";
                for (int i = Metin.Length - 1; i >= 0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }

                if (Metin == TersMetin)
                {
                Console.WriteLine("Girilen \"{0}\" metnin tersten yazılışı \"{1}\" olduğu için girilen metin polindrom'dur.", Metin, TersMetin);

                }
 
                else
                {
                    Console.WriteLine("Girilen \"{0}\" metnin tersten yazılışı \"{1}\" olduğu için girilen metin polindrom değildir.", Metin, TersMetin);

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
