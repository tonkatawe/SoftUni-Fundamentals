using System;
using System.Text;
namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int bourderStart = 0;
            int bourderEnd = 0;
            int counter = 0;
            string fileName = string.Empty;
            string fileExtension = string.Empty;

            for (int i = 0; i < filePath.Length; i++)
            {
                if (filePath[i] == '\\')
                {
                    bourderStart = i;
                }
                else if (filePath[i] == '.')
                {
                    bourderEnd = i;
                }
            }
            for (int i = bourderStart + 1; i < bourderEnd; i++)
            {
                fileName += filePath[i];
            }
            for (int i = bourderEnd + 1; i <= filePath.Length - 1; i++)
            {
                fileExtension += filePath[i];
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }

}
