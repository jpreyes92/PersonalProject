using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace CIS440Project.Models
{
    public class ProjectDB
    {
        [Key]
        public int ProjectID
        { get; set; }

        public string ProjectName
        { get; set; }

        public string Description
        { get; set; }

        public string CompanyName
        { get; set; }

        public string Image
        { get; set; }

        public int GroupID
        { get; set; }

        public int VoteYesCount
        { get; set; }

        public int VoteNoCount
        { get; set; }
    }

    public class Project2DBContext : DbContext
    {
        public Project2DBContext() : base("Project2") { }
        public DbSet<ProjectDB> Projects { get; set; }
    }
}