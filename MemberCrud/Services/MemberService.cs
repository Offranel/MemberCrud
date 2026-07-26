using System;
using System.Collections.Generic;
using MemberCrud.Models;

namespace MemberCrud.Services;

public class MemberService  
{
    private List<Member> members = new List<Member>();

    public List<Member> GetAllMembers()
    {
        return members;
    }
    public void AddMember(Member member)
    {
        members.Add(member);
    }

    public void DeleteMember( Member member)
    {
        members.Remove(member);
    }

}

