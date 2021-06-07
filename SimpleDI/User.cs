namespace SimpleDI
{
    internal class User
    {
        private INotificationService _notificationService;

        public User(string username, INotificationService notificationService)
        {
            Username = username;
            _notificationService = notificationService;
        }
        
        public string Username { get; set; }

        public void ChangeUserName(string newUserName)
        {
            Username = newUserName;
            _notificationService.NotifyUsernameChanged(this);
        }
    }
}