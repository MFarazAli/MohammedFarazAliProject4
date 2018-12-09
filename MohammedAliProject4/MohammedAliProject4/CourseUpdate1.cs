using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedAliProject4
{
    public static class CourseUpdate1    //This is my first Class
    {
       

        public static void SetCourse(string Value, string Value2, string Value3, string Value4, string Value5)
        {
            CourseUpdate2.SetCourse2(Value, Value2, Value3, Value4, Value5);
        }

        public static Object[] GetCourse()
        {
            Object[] ArrayOfObjects2 = new Object[5];   // Creating Objects array
            ArrayOfObjects2 = CourseUpdate2.GetCourse2();  // Calling the Second Class

            return ArrayOfObjects2;


        }

    }
}
