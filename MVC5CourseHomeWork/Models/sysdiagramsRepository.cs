using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5CourseHomeWork.Models
{   
	public  class sysdiagramsRepository : EFRepository<sysdiagrams>, IsysdiagramsRepository
	{

	}

	public  interface IsysdiagramsRepository : IRepository<sysdiagrams>
	{

	}
}