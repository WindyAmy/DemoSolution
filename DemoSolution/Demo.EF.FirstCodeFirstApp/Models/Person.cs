using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EF.FirstCodeFirstApp
{
    //public class Person
    //{
    //    #region 1.0 一对一

    //    //public int PersonId { get; set; }
    //    //public string Name { get; set; }
    //    //public bool IsActive { get; set; }
    //    //public virtual Student Student { get; set; }

    //    #endregion 1.0 一对一

    //    #region 2.0 TPT Table per Type(TPT)继承

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string PhoneNumber { get; set; }

    //    #endregion 2.0 TPT Table per Type(TPT)继承
    //}
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    [Table("Employees")] //无特殊配置使用（不加注解）TPH继承
    public class Employee : Person
    {
        public decimal Salary { get; set; }
    }

    [Table("Vendors")]
    public class Vendor : Person
    {
        public decimal HourlyRate { get; set; }
    }
}