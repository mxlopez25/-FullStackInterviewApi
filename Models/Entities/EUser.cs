namespace WebService.Models.Entities {
    public class EUser {

        public EUser() {
            
        }

        public EUser(Users u) {
            users = new List<Users>();
            users.Add(u);
        }
        public EUser(List<Users> u) {
            users = new List<Users>();
            users.AddRange(u);
        }
        public List<Users>? users { get; set; }
    }
}