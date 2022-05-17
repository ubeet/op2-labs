using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Funcs
    {
        public static void FileWrite(Drug[] drugs, string path, FileMode fm) 
        {
            
            FileStream stream = File.Open(path, fm);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (var i in drugs)
                bf.Serialize(stream, i); 
            stream.Close();
            
        }
        
        

        public static T[] Add<T>(T[] ss, T z)
        {
            T[] x = new T[ss.Length+1];
            for (int i = 0; i < ss.Length; i++)
            {
                x[i] = ss[i];
            }
            x[ss.Length] = z;
            return x;
        }
        
        public static Drug[] FileRead(string path)
        {
            Drug[] txt = new Drug[0];
            FileStream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (stream.Position < stream.Length)
            {
                Drug drug = (Drug) bf.Deserialize(stream);
                txt = Add(txt, drug);
            }

            stream.Close();
            return txt;
        }

        public static void TxtOut(Drug[] ss)
        {
            foreach (var el in ss)
            {
                Console.WriteLine($"{el.DrugName}\t{el.Time}");
            }

            Console.WriteLine();
        }

        public static T[] RemoveElement<T>(T[] elements, int j)
        {
            T[] newLines = new T[elements.Length - 1];
            int k = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (i != j)
                {
                    newLines[k] = elements[i];
                    k++;
                }
                
            }

            return newLines;
        }

        public static string FindEndTime(DateTime openTime, DateTime endTime)
        {
            openTime = openTime.AddHours(endTime.Hour);
            openTime = openTime.AddMinutes(endTime.Minute);
            
            return openTime.ToString("g");

        }

        

        public static void RemoveOverdue(string path)
        {
            Drug[] lines = FileRead(path);
            for (int i = 0; i < lines.Length; i++)
            {
                DateTime endTime = DateTime.Parse(lines[i].Time);
                if (endTime < DateTime.Now)
                {
                    lines = RemoveElement(lines, i);
                    i--;
                }
            }
            FileWrite(lines, path, FileMode.Create);
            
        }
        
        [Serializable]
        public struct Drug
        {
            public string DrugName{get; set;}
            public string Time{get; set;}

            
            public Drug(string drugName, string time)
            {
                DrugName = drugName;
                Time = time;
            }

        }
        
    }
}