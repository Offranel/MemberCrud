using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace MemberCrud.Models;

/// <summary>
/// To have a message from a volunteer to the church admin.
/// </summary>
public class VolunteerMessage
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public required string MessageText { get; set; }

    public DateTime SentAt { get; set; }
}
