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
    [Alias("FileAttachments")]
    [JengaEntity]

    public class FileAttachment
    {

        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        [JengaIdentifier]
        public string FileName { get; set; }
        [JengaOptions("Image,Video, Document,Other")]

        public string AttachmentType { get; set; } = "Image";
        [ForeignKey(typeof(Project), OnDelete = "CASCADE")]
        public int ProjectID { get; set; }
        [JengaTextArea]
        public string Description { get; set; }
        [JengaFile("All Files|*.")]
        public byte[] File { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}