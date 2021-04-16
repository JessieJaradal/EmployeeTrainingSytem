using System;

namespace EmployeeTrainingSystem
{
    class Program
    {
        static void Main(string[] args)

        {

            // the trainer username is admin and the password is passoword//
            // the employee user name are julian, jennifer, josh, july and jack.//

            String julian = ("Employee Name: Julian\n Exercise#1: completed\n Exercise#2: completed\n Exercise#3: completed \n Exercise#4: completed\n Exercise#5: completed");
            String jennifer = ("Employee Name: Jennifer\n Exercise#1: completed\n Exercise#2: completed\n Exercise#3: not completed \n Exercise#4: completed\n Exercise#5: not completed");
            String josh = ("Employee Name: Josh\n Exercise#1: not completed\n Exercise#2: completed\n Exercise#3: not  completed \n Exercise#4: completed\n Exercise#5: completed");
            String july = ("Employee Name: July\n Exercise#1: completed\n Exercise#2: completed\n Exercise#3: completed \n Exercise#4: completed\n Exercise#5: not completed");
            String jack = ("Employee Name: Jack\n Exercise#1: completed\n Exercise#2: completed\n Exercise#3: not completed \n Exercise#4: completed\n Exercise#5: completed");

            String employeemenu = "Welcome to the Employee Menu: Press A to view the Completed Exercise or Press B to view the Training Schedule";
            String adminmenu = "Welcome to the Admin Menu: Press A to view Employee's Status Press B to view the Training Schedule";
            String schedule = ("Training Schedule:\n exercise#1: April 1,2021\n Exercise#2: April 7,2021\n Exercise#3: April 14,2021\n Exercise#4: April 21,2021\n Exercise#5: April 28,2021");

            Console.WriteLine("Welcome to Jessie's Employee Traing System.");
            Console.WriteLine("..........");
            Console.WriteLine("If you are a Trainer Press A and Press B If you are a employee.");
            String letter = Console.ReadLine().ToUpper();


            if (letter.Equals("A"))
            {

                Console.WriteLine(".........");
                Console.WriteLine("Welcome Trainer: Please Input your Username:");
                String username = Console.ReadLine();

                if (username.Equals("admin"))
                {
                    Console.WriteLine("Please Input your password:");
                    String password = Console.ReadLine();

                    if (password.Equals("password"))
                    {

                        Console.WriteLine(adminmenu);
                        String admselection = Console.ReadLine().ToUpper();

                        if (admselection.Equals("A"))
                        {

                            Console.WriteLine("Employee Status");
                            Console.WriteLine(".......");
                            Console.WriteLine(julian);
                            Console.WriteLine(".......");
                            Console.WriteLine(jennifer);
                            Console.WriteLine(".......");
                            Console.WriteLine(josh);
                            Console.WriteLine(".......");
                            Console.WriteLine(july);
                            Console.WriteLine(".......");
                            Console.WriteLine(jack);
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                        else if (admselection.Equals("B"))
                        {

                            Console.WriteLine(schedule);
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
                    else
                    {

                        Console.WriteLine("Invalid Password!");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }

                }

                else
                {


                    Console.WriteLine("Invalid username!.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }

            }
           

            if (letter.Equals("B"))
            {

                Console.WriteLine(".........");
                Console.WriteLine(employeemenu);
                
                Console.WriteLine("Please choose a key:");
                String empselection = Console.ReadLine().ToLower();

                   if (empselection.Equals("a"))               
                   {
                    Console.WriteLine(".......");
                    Console.WriteLine("Please Input the username:");
                    String empselection2 = Console.ReadLine().ToLower();

                    if (empselection2.Equals("julian"))
                    {
                        Console.WriteLine(julian);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else if (empselection2.Equals("jennifer"))
                    {
                        Console.WriteLine(jennifer);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }                  
                    else if (empselection2.Equals("josh"))
                    {
                        Console.WriteLine(josh);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else if (empselection2.Equals("july"))
                    {
                        Console.WriteLine(july);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else if (empselection2.Equals("jack"))
                    {
                        Console.WriteLine(jack);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                  
                    }
                }
                if (empselection.Equals("b")) 
                { Console.WriteLine(schedule); Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }



            } else {
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }


           
        }
    }
}
