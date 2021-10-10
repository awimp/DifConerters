using System;
using System.Collections.Generic;

namespace DZ2
{
    class Group
    {

        private string GName;

        private List<Student> studentsList;



        public Group(string GName)
        {
            studentsList = new List<Student>();
            this.GName = GName;
        }



        public Group(List<Student> students)
        {
            studentsList = new List<Student>(students);
        }

        

        public void AddStudent(Student student)
        {
            studentsList.Add(student);
        }




        public void GetInfo()

        {
            Console.WriteLine("Group's name is " + GName);
            for (int i = 0; i < studentsList.Count; ++i)
            {
                Console.WriteLine(studentsList[i].getName());
            }
        }



        public void GetFullInfo()

        {

            Console.WriteLine("Group's name is " + GName + "\n");
            Console.WriteLine("Students list: \n");



            for (int i = 0; i < studentsList.Count; ++i)
            {
                Console.WriteLine( studentsList[i].getName());
              
                Console.WriteLine(studentsList[i].getState());


            }
        }
    }
}