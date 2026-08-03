using System;
using System.Collections.Generic;
using System.Text;

namespace MemberCrud.Models;

/// <summary>
/// Represents the relationship between a church member and a ministry.
///
/// This class is used to connect members with the ministries in which
/// they serve. It creates a link between the Members table and the
/// Ministries table, allowing one member to serve in one or more
/// ministries.
///
/// MemberMinistry objects are used to store, retrieve, and manage
/// ministry assignments in the application and the SQL Server database.
/// </summary>
public class MemberMinistry
{
   
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int MinistryId { get; set; } 

}
