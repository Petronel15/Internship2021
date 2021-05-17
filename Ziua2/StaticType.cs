using System;
using System.Collections.Generic;
using System.Text;

namespace Ziua2
{
    public class StaticType
    {
        public static string staticName;
        public string name;
        public StaticType xxx;

        public StaticType(string name = "Test")
        {
            this.name = name;
        }
        public static string DoubleToString(double number)
        {
            string result;
            number = Math.Round(number, 2);
            result = number.ToString();
            return result;
        }

        public StaticType Clone()
        {
            var tmp = (StaticType)this.MemberwiseClone();
            return tmp;
        }
    }
}
