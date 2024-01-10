using System;
namespace Program;

class Program {
    static void Main(string[] args) {

        string cmd = "";

        while (cmd != "exit") {
            Console.Write("LoginShell # ");
            cmd = Console.ReadLine();

            switch (cmd){              
                case "add":
                    UserManager.CreateUserDialog();
                    break;

                case "login":
                    UserManager.UserLoginDialog();
                    break;

                case "list":
                    UserManager.ListAllUsers();
                    break;

                case "exit":
                    Console.WriteLine("Exiting...");
                    break;
                
                case "clear":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Unknown command!");
                    break;
            }
        }}
    }

