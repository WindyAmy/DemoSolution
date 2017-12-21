namespace Demo.EF.FirstCodeFirstApp
{
    #region 1.0 普通POCO类方式定义

    public class PayWay
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    #endregion 1.0 普通POCO类方式定义

    #region 2.0 注解方式定义

    //[Table("PayWay")]
    //public class PayWay
    //{
    //    public int Id { get; set; }

    //    [MaxLength(8, ErrorMessage = "支付方式的名称长度不能大于8")]
    //    public string Name { get; set; }
    //}

    #endregion 2.0 注解方式定义
}