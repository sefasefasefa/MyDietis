using Jenga;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDietiss.Models
{
    [AutoGenerateTable(0)]
    [Alias("Employees")]
    [JengaEntity]
    public class Employee : IJengaAuth
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        [JengaImage(200, 200)]
        public byte[] Photo { get; set; }
        [JengaIdentifier]
        public string Name { get; set; }
        [JengaOptions("Male, Female,Non-Binary")]
        public string Gender { get; set; } = "Male";

        public string Email { get; set; }
        public string Password { get; set; }
        [JengaOptions("Admin,Employee")]
        public string Role { get; set; } = "Admin";

        public DateTime DateAdded { get; set; } = DateTime.Now;
        public bool Active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}