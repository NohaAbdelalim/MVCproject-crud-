using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Department
    {

        
        public int Id { get; set; }

        public string DeptName { get; set; }



        public bool isdeleted { get; set; } = false;
        //public List<Student> studentList { get; set; }

        //to restrict that the student is added only to one department
        //call gethashcode then compare
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();

    }
}
