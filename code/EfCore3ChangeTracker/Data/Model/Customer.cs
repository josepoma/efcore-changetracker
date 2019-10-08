using System;

namespace EfCore3ChangeTracker.Data.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Creator { get; set; }
        public DateTime? Created { get; set; }
        public string Modifier { get; set; }
        public DateTime? Modified { get; set; }

    }
}
