class User {
    private string name;
    private string password;

    public User(string Name, string Password){
        this.name = Name;
        this.password = Password;
    }

    public string GetName(){
        return this.name;
    }

    public string GetPasswd(){
        return this.password;
    }
}