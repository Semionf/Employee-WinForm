using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class EmployeeClass
    {
        public EmployeeClass() { }

        [Key]
		public int Code { get; set; }
		[Required]
		private int _id;
		public int id { get {return _id; } set { _id = value; } }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }

		


	}
}
