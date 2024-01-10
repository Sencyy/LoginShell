class UserShell {
    public static void UserLoggedInShell(string UserName) {
        string cmd = "";

        while (cmd != "logout") {
            Console.Write("{0} # ", UserName);
            cmd = Console.ReadLine();
            string[] Command = cmd.Split(' ');

            switch (Command[0]) {
                case "whoami":
                    Console.WriteLine(UserName);
                    break;

                case "sum":
                    Console.WriteLine(int.Parse(Command[1]) + int.Parse(Command[2]));
                    break;

                case "clear":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Unknown Command!");
                    break;
            }
        }
    }
}