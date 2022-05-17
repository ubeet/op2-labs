using System;
using System.IO;
using static Lab2.Funcs;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            Drug[] lines = {new Drug("name0", "2:30"), new Drug("name1", "1:10"), new Drug("name2", "0:31"), new Drug("name3", "10:10")};
            FileWrite(lines, $"{path}drugs.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Введите названия препаратов из списка ниже и время их открытия в формате ГГ:ХХ");
            Drug[] drugsList = FileRead($"{path}drugs.txt");
            foreach (Drug drug in drugsList)
                Console.Write($"{drug.DrugName} ");
            Console.WriteLine();
            string enter = "";
            Drug[] withEnd = new Drug[0];
            while (enter != "endl")
            {
                enter = Console.ReadLine();
                if (enter == "endl")
                    continue;
                foreach (var drug in drugsList)
                {
                    if(drug.DrugName.Equals(enter.Split(" ")[0]))
                    {
                        string x = FindEndTime(DateTime.Parse(enter.Split(" ")[1]), DateTime.Parse(drug.Time));
                        withEnd = Add<Drug>(withEnd, new Drug(drug.DrugName, x));
                    }
                }
            }
            FileWrite(withEnd, $"{path}openDrugs.txt", FileMode.OpenOrCreate);
            
            TxtOut(FileRead($"{path}openDrugs.txt"));
            RemoveOverdue($"{path}openDrugs.txt");
            TxtOut(FileRead($"{path}openDrugs.txt"));
        }
        
    }
}