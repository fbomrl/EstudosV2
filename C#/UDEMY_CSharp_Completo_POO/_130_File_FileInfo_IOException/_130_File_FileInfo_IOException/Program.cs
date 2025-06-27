using System;
using System.IO;

namespace _130_File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FILE, FILEINFO - Aula 130
            //    Namespace System.IO.

            //    Realiza operações com arquivos (Create, Copy, Delete, Move, Open, Etc.) e ajuda na criação de objetos FileStream.

            //    File
            //Static members (simples, mas realiza verificação de segurança para cada operação).

            //    FileInfo
            //Instance members.
            #endregion

            #region IOEXCEPTION - Aula 130
            //    Namespace System.IO.

            //    IOEXCEPETION
            //-DirectoryNotFoundException
            //-DriveNotFoundException
            //-EndOfStreamException
            //-FileLoadException
            //-FileNotFoundException
            //-PathTooLongException
            //-PipeException
            #endregion

            string sourcePath = @"C:\Users\fabioms\Desktop\file1.txt";
            string targetPath = @"C:\Users\fabioms\Desktop\file2.txt";

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
