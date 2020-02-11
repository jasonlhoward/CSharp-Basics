using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"c:\deletethis\folder1");

            //var files = Directory.GetFiles(@"d:Downloads", "*.*", SearchOption.TopDirectoryOnly);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            //var directories = Directory.GetDirectories(@"d:Downloads", "*.*", SearchOption.AllDirectories);
            //foreach (var directory in directories)
            //    Console.WriteLine(directory);

            //Directory.Exists(@"c:\deletethis\folder1");

            //var directoryInfo = new DirectoryInfo("...");
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();
            ///etc...
            ///

            var path = @"D:\Downloads\Win10\Packages\Apps\VulkanRT64\VulkanRT.msi";

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));

        }
    }
}
