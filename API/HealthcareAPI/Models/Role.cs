//The Role model represents different roles in the system (Admin, Healthcare Professional).
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Permissions { get; set; }
}


//Defines different user roles like Admin and Healthcare Professional.
//Establishes a One-to-Many relationship with User.cs (a role can have multiple users).

//namespace HealthcareAPI.Models
//{
//    public class Role
//    {
//        public int Id { get; set; } // Primary Key
//        public string Name { get; set; } = string.Empty; // Role Name (Admin, Healthcare Professional)

//        // Navigation Property
//        public ICollection<User>? Users { get; set; }
//    }
//}
