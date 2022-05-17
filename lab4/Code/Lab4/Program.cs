using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeral_16 N1 = new Numeral_16(763);
            Numeral_16 N2 = new Numeral_16("15B");
            Numeral_16 N3 = new Numeral_16(5518);
            
            Console.WriteLine($"N1\n16: {N1.GetHexNum()}\n10: {N1.GetIntNum()}\n");
            Console.WriteLine($"N2\n16: {N2.GetHexNum()}\n10: {N2.GetIntNum()}\n");
            Console.WriteLine($"N3\n16: {N3.GetHexNum()}\n10: {N3.GetIntNum()}\n");
            
            N1++;
            N2 += 15;
            N3.SetHexNum(N1 + N2);

            Console.WriteLine($"N1\n16: {N1.GetHexNum()}\n10: {N1.GetIntNum()}\n");
            Console.WriteLine($"N2\n16: {N2.GetHexNum()}\n10: {N2.GetIntNum()}\n");
            Console.WriteLine($"N3\n16: {N3.GetHexNum()}\n10: {N3.GetIntNum()}\n");
        }
    }
}