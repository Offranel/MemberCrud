using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemberCrud.Models;

public class Member
{
    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Phone { get; set; }

    public required string Email { get; set; }

    public required string MembershipStatus { get; set; }


    public required string Street { get; set; }

    public required string City { get; set; }

    public required string PostalCode { get; set; }

    public DateTime DateOfBirth { get; set; }

    public DateTime CreateAt { get; set; }

}

