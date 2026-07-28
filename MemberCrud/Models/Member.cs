
using System;

namespace MemberCrud.Models
{
    public class Member
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }

        public required string MembershipStatus { get; set; }

        public DateTime CreateAt { get; set; }
    }
}

