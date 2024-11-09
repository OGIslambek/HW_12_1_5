using HW_12_1_5.Modules;

namespace HW_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() { new User("Олег", "OOO Leg", false), new User("Татьяна", "Thotiana123", false), new User("Григорий", "OGrigory", true), new User("Николай", "NikolaII", false) };

            Thread.Sleep(2000);
            foreach (User user in users)
            {
                if (user.IsPremium == true)
                {
                    user.GreetingPremiumUser(user.Name, user.Login);
                }
                else
                {
                    Console.WriteLine($"{user.Name}({user.Login}),");
                    Thread.Sleep(1000);
                    user.ShowAds();
                }
            }
        }
    }
}
