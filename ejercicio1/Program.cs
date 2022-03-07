using System;
using System.IO;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta=default;
            int i = 0;
            Console.Write("Introduce la ruta del archivo: ");
            ruta = Console.ReadLine();

            FileStream fichero = File.Create(ruta);
            //Encoding.UTF()
            char[] cadena = new char[]{'h','o' ,'l', 'a', 'm', 'u', 'n', 'd', 'o' ,'c', 'r', 'u', 'e', 'l'}; 
            byte[] cadenaByte = new byte[cadena.Length];
            foreach(char c in cadena)
            {
                cadenaByte[i++] = (byte)c;
            }

            fichero.Write(cadenaByte);

            fichero.Position = 0; //Lo suyo es abrir y cerrar el fichero
            while(fichero.Position < fichero.Length)
            {
                Console.Write((char)fichero.ReadByte());
            }
            fichero.Close();
        
        }
    }
}
