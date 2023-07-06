using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDietiss.Models
{
    [AutoGenerateTable(2)]
    [Alias("Tasks")]
    [JengaEntity]

    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Project), OnDelete = "CASCADE")]
        public int ProjectID { get; set; }
[JengaIdentifier]
        public string TaskName { get; set; }
        [JengaTextArea]
        public string Description { get; set; }
        [ForeignKey(typeof(Employee), OnDelete = "CASCADE")]
        public int TaskOwnerID { get; set; }
        [JengaOptions("In Progress,On Hold,Completed,Cancelled")]
        public string Status { get; set; } = "In Progress";
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    } }