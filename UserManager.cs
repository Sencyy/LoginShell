class UserManager {

    private static List<User> UserList = new List<User>();
    public static void CreateUserDialog() {
        Console.WriteLine("Please inser user name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please insert user password:");
        string passwd = Console.ReadLine();

        User user = new User(name, passwd);
        UserList.Add(user);
        
    }

    public static void UserLoginDialog() {
        Console.WriteLine("Insert login:");
        string login = Console.ReadLine();

        Console.WriteLine("Password for {0}:", login);
        string pswd = Console.ReadLine();

        foreach (User user in UserList) {
            if (user.GetName() == login & user.GetPasswd() == pswd) {
                Console.Clear();
                UserShell.UserLoggedInShell(login);
            } else {
                Console.WriteLine("Incorrect credentials!");
            }
        }
    }

    public static void ListAllUsers() {
        foreach (User user in UserList) {
            Console.Write("User\t{0}\n", user.GetName());
        }
    }
}