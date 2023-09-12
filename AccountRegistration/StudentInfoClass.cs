using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);
    class StudentInfoClass
    {
        

        public static string Fname = "";
        public static string Lname = "";
        public static string Mname = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ConNo = 0;
        public static long StudNo = 0;

        public static string getFirstName(string Fname) 
        {
            return StudentInfoClass.Fname = Fname;
        }

        public static string getLastName(string Lname)
        {
            return Lname;
        }

        public static string getMiddlName(string Mname) 
        {
            return Mname;
        }

        public static string getAddress(string Address) 
        {
            return Address;
        }

        public static string getProgram(string Program) 
        {
            return Program;
        }

        public static long getAge(long Age) 
        {
            return Age;
        }

        public static long getContactNum(long ConNo)
        {
            return ConNo;
        }

        public static long getStudentNo(long StudNo)
        {
            return StudNo;
        }
    }
}
