using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5CourseHomeWork.Models
{   
	public  class 客戶概要檢視Repository : EFRepository<客戶概要檢視>, I客戶概要檢視Repository
	{

	}

	public  interface I客戶概要檢視Repository : IRepository<客戶概要檢視>
	{

	}
}