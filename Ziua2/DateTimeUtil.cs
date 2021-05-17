using System;
using System.Collections.Generic;
using System.Text;

namespace Ziua2
{
    public static class DateTimeUtil
    {
        public static void SetDatetime2Today(DateTimeType object2)
        {
            object2.datetime2 = DateTime.Today;
        }

        public static void SetInt(ref int value2)
        {
            value2 = 4;
        }

        public static void TestOut(out int value2)
        {
            value2 = 4;
        }

        public static void SetWithNewInstanceDatetime2Today(ref DateTimeType object2)
        {
            object2 = new DateTimeType();
            object2.datetime2 = DateTime.Today;

        }
    }
}
