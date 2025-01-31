//Defines the User entity with authentication details (Email, PasswordHash).
//Uses Data Annotations ([Required], [EmailAddress]) to enforce validation.
//Implements Role-based access control (RBAC) via RoleId (Foreign Key to Role).
//Includes CreatedAt and UpdatedAt for auditing.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HealthcareAPI.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty; // Hashed Password

        [ForeignKey("Role")]
        public int RoleId { get; set; } // Foreign Key
        public Role? Role { get; set; } // Navigation Property

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    } 
    
    public class User : IdentityUser
    {
        public string Role { get; set; }  // Admin, HealthcareProfessional
    }

}
