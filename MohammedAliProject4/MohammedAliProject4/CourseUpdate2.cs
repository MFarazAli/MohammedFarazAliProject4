using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammedAliProject4
{
    public class CustomException : Exception  // Custom exception to handle exceptions occured in Number of courses and Name textbox
    {
        public CustomException()     
        {
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public static class CourseUpdate2   //This is the Second Class
    {
        private static int CNValue;      //Stores the number of courses
        private static string FLNValue;  // Stores the First and Last name  
        private static string CSD;       // Stores the Class Start Date
        private static string Course;    // Stores the Course name
        private static string MODE;      // Stores the Mode of class
        public static string x = "Null";

        public static void SetCourse2(string Value, string Value2, string Value3, string Value4, string Value5)
        {
            try
            {

                CNValue = Convert.ToInt16(Value);  //Converting number of courses to integer
                if ((CNValue <= 0) || (CNValue>6))
                    throw new CustomException("Number of Courses cannot be less than 0 and greater than 6 ");


                FLNValue = Value2;
                CSD = Value3;
                Course = Value4;
                MODE = Value5;

                if (FLNValue.Length == 0)  //if name textbox is empty throw exception
                    throw new CustomException("Name cannot be empty");               

                foreach (char c in FLNValue)   // if name textbox contains special characters(other than space) or numbers throw exception
                {
                    if (Char.IsLetter(c) || c == ' ')
                    {    // Do Nothing 
                    }
                    else
                        throw new CustomException("Name can only contain Alphabets");
                }

                if (FLNValue != x) // shows a message if first last name value is changed
                {
                    MessageBox.Show("The Name of the student is changed from " + x + " to " + FLNValue, "Name Changed");
                    x = FLNValue;
                }

                

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numeric format for Number of Courses. Please check the entry.", "Entry Error");
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message, "Custom Exception");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public static Object[] GetCourse2()
        {
            Object[] ArrayOfObjects = new Object[] { CNValue, FLNValue, CSD, Course, MODE }; // Creating Objects array and initializing it
            return ArrayOfObjects;


        }

    }
}
