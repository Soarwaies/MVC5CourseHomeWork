namespace MVC5CourseHomeWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶概要檢視MetaData))]
    public partial class 客戶概要檢視
    {
    }
    
    public partial class 客戶概要檢視MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 聯絡人數量 { get; set; }
        public Nullable<int> 帳戶數量 { get; set; }
    }
}
