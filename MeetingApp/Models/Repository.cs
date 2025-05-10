namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo()
            {
                Id = 1,
                Name = "Ali",
                Email = "abc@gmail.com",
                Phone = "4378438",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Ahmet",
                Email = "asd@gmail.com",
                Phone = "092000",
                WillAttend = false
            });
            _users.Add(new UserInfo()
            {
                Id = 3,
                Name = "Canan",
                Email = "xyz@gmail.com",
                Phone = "0850438",
                WillAttend = true
            });
        }
        public static List<UserInfo> Users //_user geri döndüren property oluşturuyoruz
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(Users=> Users.Id == id);
        }
    }

}