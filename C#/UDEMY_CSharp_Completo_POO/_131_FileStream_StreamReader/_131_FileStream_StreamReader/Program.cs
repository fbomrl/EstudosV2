using System;
using System.IO;

namespace _131_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FILESTREAM

            //    Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.

            //    Suporte binário.

            //    Instanciação
            //-Vários construtores.
            //-File/FileInfo.

            #endregion

            #region STREAMREADER

            //    É uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream).

            //    Suporte a dados no formato de texto.

            //    Instanciação:
            //-Vários construtores.
            //-File/FileInfo.

            #endregion
                         
            string path = @"C:\Users\fabioms\Desktop\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //Essa é uma forma de chamar, a outra é utilizando o File.
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) 
                    sr.Close();
                //if (fs != null)
                //    fs.Close();
            }

            Console.ReadLine();
        }
    }
}
