using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studentClass = new Student() {
                Name = "",
                Birthday = new DateTime(1985,09,09),
                ClassNumber = 1,
                Grade = 1
            };

            Console.Write(studentClass.Name + studentClass.Birthday + studentClass.ClassNumber + studentClass.Grade);

            Person person = studentClass;
            object objectStudent = studentClass;
        }
    }
}
