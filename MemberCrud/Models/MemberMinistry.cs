using System;
using System.Collections.Generic;
using System.Text;

namespace MemberCrud.Models;    

public class MemberMinistry
{
    /// <summary>
    /// Gets or sets the unique identifier for the MemberMinistry entity.  
    /// </summary>
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int MinistryId { get; set; } 

}
