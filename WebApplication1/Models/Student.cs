using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {

        public int Id { get; set; }

     
        public string Name { get; set; }

       public string image {  get; set; }   
        public int Age { get; set; }
        public string Email { get; set; }

        [ForeignKey("Department")]
        public int deptNo { get; set; }
        //navigation properties
        public Department? Department { get; set; }

        public bool isdeleted { get; set; } = false;


    }
}
