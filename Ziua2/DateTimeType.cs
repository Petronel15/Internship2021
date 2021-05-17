using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ziua2
{
    public class DateTimeType
    {
        public DateTime datetime2;
        public DateTime datetime3;
        public StaticType xxx;

        public DateTimeType()
        {
            xxx = new StaticType();
        }

        public DateTime GetToday()
        {
            return DateTime.Today;
        }

        public string GetTime()
        {
            var now = DateTime.Now;
            return now.ToString("yyyy-MM-dd HH:mm");
        }

        public DateTime ParseDate(string v)
        {
            return DateTime.Parse(v);
        }
        public DateTime ParseDate2(string v)
        {
            return DateTime.ParseExact(v, "MM.dd.yyyy", CultureInfo.InvariantCulture);
        }

        public DateTimeType Clone()
        {
            var tmp = (DateTimeType)this.MemberwiseClone();
            tmp.xxx = xxx.Clone();
            return tmp;
        }
    }
}
