namespace proje_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki kod, metin dosyasını açmak, okumak ve kapatmak için StreamReader sınıfını kullanır.
            // Dosyayı otomatik olarak açmak için bir metin dosyasının yolunu StreamReader nesnesine tanımlayabilirsiniz.
            // ReadLine yöntemi, her metin satırını okur ve okudukça dosya işaretçisini sonraki satıra geçirir.
            // ReadLine yöntemi dosyanın sonuna ulaştığında boş bir değer döndürür.

            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Sample.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }
    }
}
