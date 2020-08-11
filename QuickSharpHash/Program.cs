using System;
using System.IO;
using System.Security.Cryptography;

namespace QuickSharpHash
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Usage: hash.exe <file1> [<file2> <file3> <...>]");
                Environment.Exit(1);
            }

            foreach (var arg in args)
                Console.WriteLine(ComputeFileHash(arg));

            Console.WriteLine();
            Console.WriteLine("Done.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string ComputeFileHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return Convert.ToBase64String(sha256.ComputeHash(stream));
                }
            }
        }
    }
}
