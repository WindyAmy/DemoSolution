using System;

namespace Demo.EF.FirstCodeFirstApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1.0 创建数据库及表

            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();//如果数据库不存在时则创建
            }
            Console.Write("DB has Created!");//提示DB创建成功
            Console.Read();

            #endregion 1.0 创建数据库
        }
    }
}