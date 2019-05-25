using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5CourseHomeWork.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(p => p.是否已刪除 == false);
        }
        public override void Delete(客戶資料 entity)
        {
            entity.是否已刪除 = true;
            this.UnitOfWork.Commit();
        }

        internal 客戶資料 Find(int? id)
        {
            throw new NotImplementedException();
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}