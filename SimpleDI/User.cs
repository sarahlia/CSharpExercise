namespace SimpleDI
{
    internal class User
    {
        private ConsoleNotification _notificationService;

        public User(string username)
        {
            Username = username;
            _notificationService = new ConsoleNotification();
        }
        
        public string Username { get; set; }

        public void ChangeUserName(string newUserName)
        {
            Username = newUserName;
            _notificationService.NotifyUsernameChanged(this);
        }
    }
}