/*
Create a Student Management System:
a) Capability of adding Students
b) Add Subject Name
c) Generate Result Sheet (Add marks per subject and calculate grades)
*/

using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object creation of Application class
            Application app = new Application();
            app.ConsoleApp();
            app.UserChoice();
            #endregion
        }
    }
}
