using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CIS440Project.Models
{
    public class GroupDB
    {
        [Key]
        public int GroupID
        { get; set; }

        public string GroupName
        { get; set; }
    }

    public class GroupDBContext : DbContext
    {
        public GroupDBContext() : base("Group") { }
        public DbSet<GroupDB> Groups { get; set; }
    }

}