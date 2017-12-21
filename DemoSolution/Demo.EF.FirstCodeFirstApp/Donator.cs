using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.EF.FirstCodeFirstApp
{
    #region 1.0 普通POCO类方式定义

    public class Donator
    {
        public int DonatorId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
    }

    #endregion 1.0 普通POCO类方式定义

    #region 2.0 注解方式定义

    //[Table("Donator")]
    //public class Donator
    //{
    //    [Key]
    //    [Column("Id")]
    //    public int DonatorId { get; set; }

    //    [StringLength(10, MinimumLength = 2)]
    //    public string Name { get; set; }

    //    public decimal Amount { get; set; }
    //    public DateTime DonateDate { get; set; }
    //}

    #endregion 2.0 注解方式定义
}