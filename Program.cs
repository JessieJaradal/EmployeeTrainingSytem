using System;
using System.Collections.Generic;

namespace EmployeeTrainingSystem
{
    class Program
    {


        private static List<string> EmployeeMenu = new List<string>()
         { "'A' to view employee Info",
           "'B' to view Completed Exercise",
           "'C' to view Schedule",
        };

        private static List<string> TrainerMenu = new List<string>()
        {
          "'A' to view employee Infos",
          "'B' to view Completed Exercises ",
          "'C' to view Schedule",
        };
        public static void Main(string[] args)

        {
            // the trainer username is admin and the password is passoword//
            // the employee user name are julian, jennifer, josh, july and jack.//

            var EmployeesInfo = new[]
            { "Employee Name: Julian\n Gender: Male \n Age: 20",
              "Employee Name: Jennifer\n Gender: Male \n Age: 19",
              "Employee Name: Josh\n Gender: Male \n Age: 18",
              "Employee Name: July\n Gender: Male \n Age: 20 ",
              "Employee Name: Jack\n Gender: Male \n Age: 23"};

            var JulianExercises = new[] { "Exercise#1: completed", "Exercise#2: completed", "Exercise#3: completed", "Exercise#4: completed", "Exercise#5: completed" };
            var JenniferExercises = new[] { "Exercise#1: completed", "Exercise#2: completed", "Exercise#3: completed", "Exercise#4: completed", "Exercise#5: not completed" };
            var JoshExercises = new[] { "Exercise#1: not completed", "Exercise#2: completed", "Exercise#3: completed", "Exercise#4: completed", "Exercise#5: completed" };
            var JulyExercises = new[] { "Exercise#1: completed", "Exercise#2: completed", "Exercise#3: not completed", "Exercise#4: completed", "Exercise#5: completed" };
            var JackExercises = new[] { "Exercise#1: completed", "Exercise#2: not completed", "Exercise#3: completed", "Exercise#4: completed", "Exercise#5: completed" };
            var CompletedExercise = new[] { "" };

            String employeemenu = "Welcome to the Employee Menu: Press A to view the Completed Exercise or Press B to view the Training Schedule";
            String adminmenu = "Welcome to the Admin Menu: Press A to view Employee's Status Press B to view the Training Schedule";
            var schedule = new[] { "exercise#1: April 1,2021", "Exercise#2: April 7,2021", "Exercise#3: April 14,2021", "Exercise#3: April 14,2021", "Exercise#5: April 28,2021" };

            Console.WriteLine("Welcome to Jessie's Employee Traing System.");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("PRESS A to Access Trainer Menu and Press B to access Employee Menu");
            String letter = Console.ReadLine().ToUpper();


            if (letter.Equals("A"))
            {

                ShowTrainerMenu();
                Console.WriteLine("----------------------------------------------------------");
                String UserInput = Console.ReadLine().ToUpper();

                if (UserInput.Equals("A"))
                {

                    foreach (var title in EmployeesInfo) { Console.WriteLine($"Employees Info< {title}"); }

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
                else if (UserInput.Equals("C"))
                {

                    foreach (var title in schedule) { Console.WriteLine($"Employees Schedule: {title}"); }
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                }
                else if (UserInput.Equals("B"))
                {
                    Console.WriteLine(EmployeesInfo[0]);
                    Console.WriteLine(JulianExercises[0]);
                    Console.WriteLine(EmployeesInfo[1]);
                    Console.WriteLine(JenniferExercises[1]);
                    Console.WriteLine(EmployeesInfo[2]);
                    Console.WriteLine(JoshExercises[0]);
                    Console.WriteLine(EmployeesInfo[3]);
                    Console.WriteLine(JulyExercises[0]);
                    Console.WriteLine(EmployeesInfo[4]);
                    Console.WriteLine(JackExercises[0]);

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                }

                else
                {

                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }



            }

            else if (letter.Equals("B"))
            {

                ShowEmployeeMenu();
                Console.WriteLine("----------------------------------------------------------");
                String UserInput1 = Console.ReadLine().ToUpper();


                if (UserInput1.Equals("A"))
                {

                    foreach (var title in EmployeesInfo) { Console.WriteLine($"Employees Info< {title}"); }

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
                else if (UserInput1.Equals("C"))
                {

                    foreach (var title in schedule) { Console.WriteLine($"Employees Schedule: {title}"); }
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                }
                else if (UserInput1.Equals("B"))
                {
                    Console.WriteLine(EmployeesInfo[0]);
                    Console.WriteLine(JulianExercises[0]);
                    Console.WriteLine(EmployeesInfo[1]);
                    Console.WriteLine(JenniferExercises[1]);
                    Console.WriteLine(EmployeesInfo[2]);
                    Console.WriteLine(JoshExercises[0]);
                    Console.WriteLine(EmployeesInfo[3]);
                    Console.WriteLine(JulyExercises[0]);
                    Console.WriteLine(EmployeesInfo[4]);
                    Console.WriteLine(JackExercises[0]);

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                }

                Console.WriteLine("Exiting The Employee Management System!");
            }

            static void ShowEmployeeMenu()
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("WELCOME EMPLOYEE! PLEASE PRESS ANY KEY OF THE FOLLOWING OPTIONS:");
                Console.WriteLine(":");
                foreach (var decription in EmployeeMenu)
                {
                    Console.WriteLine(decription);
                }
            }

            static void ShowTrainerMenu()
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("WELCOME TRAINER PLEASE PRESS ANY KEY OF THE FOLLOWING OPTIONS:");
                foreach (var decription in TrainerMenu)
                {
                    Console.WriteLine(decription);
                }
            }


        }
    }
}