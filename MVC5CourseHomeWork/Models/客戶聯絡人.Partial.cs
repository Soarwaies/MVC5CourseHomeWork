    namespace MVC5CourseHomeWork.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var db = new CustomerEntities();
            if (this.Id == 0) //create資料
            {
                if (db.客戶聯絡人.Where( p => p.Email == this.Email).Any())
                {
                    if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id).Any())
                    {
                        yield return new ValidationResult("此Email 已經存在",new string[] { "Email" });
                    }
                }
            }
            else //update資料
            {
                if (db.客戶聯絡人.Where(p => p.Email == this.Email).Any())
                {
                    if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id).Any())
                    {
                        if (db.客戶聯絡人.Where(p => p.Id != this.Id).Any())
                        {
                            yield return new ValidationResult("此Email 已存在", new string[] { "Email" });
                        }
                    }
                }
            }
            yield return ValidationResult.Success;
        }
    }


    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [RegularExpression(@"\d{4}-\d{6}",ErrorMessage = "手機號碼的格式必須為09xx-xxxxxx！")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
        [Required]
        public bool 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
