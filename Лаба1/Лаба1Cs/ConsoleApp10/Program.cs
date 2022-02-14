using System;
using System.IO;

namespace ConsoleApp10
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"";
            string input = "";
            string str = "";
            while (str != "endl")
            {
                str = Console.ReadLine();
                if (str != "endl")
                    input += str + "\n";
            }
            FileWrite($"{path}untitled.txt", input.Trim('\n'));
            string text = FileRead($"{path}untitled.txt");

            string[] txtArr = text.Split("\n");
            string text1 = "";
            string text2 = "";
            for (int i = 0; i < txtArr.Length; i++)
            {
                if (i % 2 == 0)
                    text1 += txtArr[i] + "\n";
                else
                    text2 += txtArr[i] + "\n";
            }


            FileWrite($"{path}note1.txt", text1);
            FileWrite($"{path}note2.txt", text2);

            FileOut($"{path}untitled.txt");
            FileOut($"{path}note1.txt");
            FileOut($"{path}note2.txt");

            FileAlphSort($"{path}note1.txt");
            FileOut($"{path}note1.txt");
            FileWordSort($"{path}note2.txt");
            FileOut($"{path}note2.txt");


        }

        static void FileAlphSort(string path)
        {
            string text = FileRead(path);
            string[] textArr = text.Split("\n");
            for (int i = 0; i < textArr.Length; i++)
            {
                char[] arrChars = textArr[i].ToCharArray();
                Array.Sort(arrChars);
                textArr[i] = string.Join("", arrChars);
            }
            text = string.Join("\n", textArr);
            FileWrite(path, text);
        }
        
        static void FileWordSort(string path)
        {
            
            string text = FileRead(path);
            

            string[] textArr = text.Split("\n");
            int n;
            Console.WriteLine();
            Console.Write("Введите кол-во строк для сортировки: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n > textArr.Length);
            for (int i = 0; i < n; i++)
            {
                string[] ss = textArr[i].Split(" ");
                Array.Sort(ss);
                textArr[i] = String.Join(" ", ss);
            }
            text = string.Join("\n", textArr);
            FileWrite(path, text);
        }
        static string FileRead(string path)
        {
            string text;
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] arr = new byte[fs.Length];
                fs.Read(arr, 0, arr.Length);
                text = System.Text.Encoding.UTF8.GetString(arr);
            }

            return text;
        }

        static void FileWrite(string path, string text)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists)
                info.Delete();
            using (FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes(text.Remove(text.Length-1));
                fs1.Write(arr, 0, arr.Length);
            }
        }
        static void FileOut(string path)
        {
            string txt = FileRead(path);
            Console.WriteLine();
            Console.WriteLine($"Текст файла {path}:");
            Console.WriteLine(txt);
            Console.WriteLine();
            
        }
    }
}