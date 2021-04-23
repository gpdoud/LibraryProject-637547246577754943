using System;

using Education.DB;

using UtilityLibrary;

namespace LibraryProject {

    class Program {

        static void Main(string[] args) {

            var about = Utility.About();
            Console.WriteLine($"About is {about}");

            var stud1 = new Student() {
                Id = 1, Name = "Fred", SAT = 1000, GPA = 2.5
            };
        }
    }
}
