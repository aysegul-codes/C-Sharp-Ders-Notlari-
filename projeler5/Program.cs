namespace projeler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN : Kullanıcı tarafından girilen pozitif bir tam sayının faktöriyelini alarak sonucunu ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız (ÖRN : 3  3 x 2 x 1 = 6).

            try
            {
                Console.WriteLine("Sayıyı giriniz: ");
                string Metin = Console.ReadLine();
                int Sayi = Convert.ToInt32(Metin);
                int Sonuc = 1;

                for (int i = 1; i <=Sayi; i++)
                {
                    Sonuc *= i;
                }
                Console.WriteLine("{0} sayısının faktöriyeli {1} 'dir.", Sayi, Sonuc);
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
