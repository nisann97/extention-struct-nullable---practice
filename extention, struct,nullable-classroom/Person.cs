using System;
using extention__struct_nullable_classroom.Helpers.Extentions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extention__struct_nullable_classroom
{
	public class Person
	{
		public int Id { get; set; }
		public string Email { get; set; }


		public Person(string email)
		{
			Email = email;
			Console.WriteLine(email.CheckStr(@"\W"));
		}
	}
}

