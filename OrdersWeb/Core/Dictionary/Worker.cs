using OrdersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersWeb.Model
{
    public class Worker : IDbObject
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }
       
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        public int EmployeePostId { get; set; }
        public WorkerPost EmployeePost { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
