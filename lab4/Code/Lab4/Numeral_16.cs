using System;

namespace Lab4
{
    public class Numeral_16
    {
        private string _hexNum;

        public Numeral_16(string hexNum)
        {
            _hexNum = hexNum;
        }

        public Numeral_16(int intNum)
        {
            _hexNum = intNum.ToString("X");
        }

        public string GetHexNum()
        {
            return _hexNum;
        }

        public int GetIntNum()
        {
            return Convert.ToInt32(_hexNum, 16);
        }
        
        public void SetHexNum(string hexNum)
        {
            _hexNum = hexNum;
        }
        
        public void SetHexNum(int intNum)
        {
            _hexNum = intNum.ToString("X");
        }
        
        public void SetHexNum(Numeral_16 hexNum)
        {
            _hexNum = hexNum._hexNum;
        }
        
        public static Numeral_16 operator ++(Numeral_16 hexNum)
        {
            int sum = hexNum.GetIntNum() + 1;
            hexNum._hexNum = sum.ToString("X");
            return hexNum;
        }

        public static Numeral_16 operator +(Numeral_16 hexNum, int intNum)
        {
            int sum = hexNum.GetIntNum() + intNum;
            hexNum._hexNum = sum.ToString("X");
            return hexNum;
        }
        
        public static Numeral_16 operator +(Numeral_16 hexNum1, Numeral_16 hexNum2)
        {
            int sum = hexNum1.GetIntNum() + hexNum2.GetIntNum();
            Numeral_16 sumNum = new Numeral_16(sum);
            return sumNum;
        }

        
    }
}