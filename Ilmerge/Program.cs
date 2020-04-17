using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilmerge
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\ander\source\repos\cristianohij\IntegrosCS\packages\ILMerge.3.0.29\tools\net452";
            string ignorar = "System.Compiler.dll";
            // tenho que tirar o System.Compiler.dll , faz parte do Ilmerge
            FileInfo arquivo;
            StringBuilder str = new StringBuilder();
            str.Append("ilmerge.exe /target:winexe /allowDup /out:relatoriointegros.exe RelatorioReports.exe ");

            // Ler todos os arquivos de um determinado caminho

            string[] arquivos = Directory.GetFiles(caminho, "*.dll");

            foreach (var item in arquivos)
            {
                arquivo = new FileInfo(item);
                Console.WriteLine(arquivo.Name);

                if (arquivo.Name != ignorar)
                {
                    str.Append(arquivo.Name + " "); 
                }
            }

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
