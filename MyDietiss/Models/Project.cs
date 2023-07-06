using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
namespace MyDietiss.Models
{

    [AutoGenerateTable(1)]
    [Alias("Projects")]
    [JengaEntity]
    public class Project
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [JengaIdentifier]



        public string ProjectName { get; set; }
        [JengaTextArea]

        public string Description { get; set; }
        [JengaOptions("Active,On Hold, In Progress.Completed.Past Due, Aborted, Cancelled")]
        [ForeignKey(typeof(Employee), OnDelete = "CASCADE")]
        public int ProjectOwnerID { get; set; }
        public string Status { get; set; } = "Pending";

        [CustomField("LONGBLOB")]
        [JengaFile("Document Files |*.pdf;*.doc;*.docx;*.xls;*.xlsx;")]
        public byte[] Document { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
    }
    

}
