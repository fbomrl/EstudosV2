using System;
using System.IO;
using System.Collections.Generic;

namespace _132_133_134_135_BlUsing_StreamWriter_Directory_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            #region USING BLOCK - Aula 132
            //Sintaxe simplificada que garante que objetos IDisposable serão fechados.

            //Objetos IDisposable NÃO são gerenciados pelo CLR (Common Language Runtime). Eles precisam ser manualmente fechados.
            //        Exemplos: Font, FileStream, StreamReader, StreamWriter.
            Console.WriteLine("AULA 132");
            Console.WriteLine("--------");
            string path = @"C:\users\fabioms\Desktop\file1.txt";

            try
            {
                ////tudo q for incluido nessa instância bloco será automaticamente fechado. Pode "cascatear" blocos using.
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //using (StreamReader sr = new StreamReader(fs))
                //{
                //    while (!sr.EndOfStream)
                //    {
                //        string line = sr.ReadLine();
                //        Console.WriteLine(line);
                //    }
                //}
                //}

                //Simplificando... 
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            #endregion

            #region STREAMWRITER - Aula 133

            //    É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream).

            //    Suporte a dados no formato de texto.

            //    Instantiation:
            //-Several constructors.
            //-File/FileInfo.
            //    -CreateText(path).
            //    -AppendText(String).
            Console.WriteLine("AULA 133");
            Console.WriteLine("--------");
            string sourcePath = @"C:\users\fabioms\Desktop\file1.txt";
            string targetPath = @"C:\users\fabioms\Desktop\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            #endregion

            #region DIRECTORY, DIRECTORYINFO - Aula 134

            //    Namespace System.IO

            //    Operações com pastas(create, enumerate, get files, etc).

            //    Directory
            //-Static members (simple, but performs security check for each operation).
            //    DirectoryInfo

            //-Instance members

            //    Demo
            //-Vamos listar as pastas a partir de uma pasta informada;
            //-Vamos listar os arquivos a partir de uma pasta informada;
            //-Vamos criar uma pasta;

            Console.WriteLine("AULA 134");
            Console.WriteLine("--------");

            string path134 = @"c:\users\fabioms\desktop\myfolder";

            try
            {

                //Pegar todas as subpastas a partir da pasta original.
                //obs: *.*, sendo qualquer nome de arquivo e qualquer extensão
                //Pode usar "var" ao invés de "IEnumerable<string> para simplificar ..."
                IEnumerable<string> folders = Directory.EnumerateDirectories(path134, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                //Para arquivos na pasta e subpastas,
                var files = Directory.EnumerateFiles(path134, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                //Para criar pastas
                //Directory.CreateDirectory(path134 + "\\newfolder");
                //OU
                Directory.CreateDirectory(path134 + @"\newfolder");
                //OU sem concatenar e colocar o caminho completo.

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            #endregion

            #region PATH - Aula 135

                //Namespace System.IO

                //Realiza operações com strings que contém informações de arquivos ou pastas.

            Console.WriteLine("AULA 135");
            Console.WriteLine("--------");

            string path135 = @"c:\users\fabioms\desktop\myfolder\file1.txt";


            //Mostra o caractere de separação.
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            //Caractere para separar entre paths diferente.
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            //Coleta todo o caminho até a pasta, sem mostrar os arquivos.
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path135));

            //Função para coletar o nome do arquivo.
            Console.WriteLine("GetFileName: " + Path.GetFileName(path135));

            //Função para coletar o nome do arquivo sem a extensão
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path135));

            //Função para pegar apenas a extensão do arquivo.
            Console.WriteLine("GetExtension: " + Path.GetExtension(path135));

            //Função que pega todo o caminho do arquivo.
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path135));

            //Função para pegar as pastas temporária do sistema na qual eu posso manipular dados temporários de aplicações.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            
            Console.WriteLine();
            #endregion

            Console.ReadLine();
        }
    }
}
