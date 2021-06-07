using System;

namespace SimpleDI
{
    internal class ConsoleNotification
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has been changed to: {user.Username}");
        }
    }
}