namespace proje9
{
    internal class Program
    {
        static void Main(string[] args)
        {       //ÖRN: Üç elemanlı bir diziye kullanıcı tarafından tam sayı değerleri atanan ve daha sonra bu atanan değerleri toplayıp sonucunu ekrana yazan konsol uygulamasının C# dilinde kodunu yazınız.
            try
            {
                int[] SayiDizisi = new int[3];
                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Sayı dizisinin {0}. elemanını giriniz : ", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }

                int Toplam = 0;

                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Toplam += SayiDizisi[i];
                }

                Console.WriteLine("Sayı dizisinin elemanları toplamı {0} 'dır.", Toplam);
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
