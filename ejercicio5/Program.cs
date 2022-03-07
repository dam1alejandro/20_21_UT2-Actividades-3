using System;
using System.IO;
using System.Text;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            FileStream fs = new FileStream("datos.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
            
            do
            {   
                Console.WriteLine("Tecla: ");
                cki = Console.ReadKey();
                bw.Write(cki.ToString());
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            bw.Close();
        }
    }
}
