namespace CACTOC;

class User
{
    public string UserName{get; set;} = string.Empty;
    public string Password{get; set;} = string.Empty;
    public string Email {get;set;} = string.Empty;


    public User(string name, string email, string password)
    {
        UserName = name;
        Password = password;
        Email = email;
        System.Console.WriteLine($"{UserName} ");

    }


    public User() :
        this("данил колбасенко", "danilkolbasenko", "kolbasenco"){}

    
    public void Say(string msg) =>
    System.Console.WriteLine($"{UserName}: {msg}");


 }
