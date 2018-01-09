using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Demo.EF.FirstCodeFirstApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //创建数据库
            Database.SetInitializer(new Initializer());
            using (var context = new Context())
            {
                //context.Database.CreateIfNotExists();//如果数据库不存在时则创建
                //context.Database.Create();

                //var payways = context.PayWays.Where(a => a.Id == 4).ToList();
                //var query = context.PayWays.Find(3);//该条记录直接在内存中查询不需要查询数据库

                #region 1.0 创建表记录

                //var donators1 = new List<Donator>
                //{
                //    new Donator
                //    {
                //      Name   = "陈志康",
                //      Amount = 50,
                //      DonateDate = new DateTime(2016, 4, 7)
                //    },
                //    new Donator
                //    {
                //        Name = "海风",
                //        Amount = 5,
                //        DonateDate = new DateTime(2016, 4, 8)
                //    },
                //    new Donator
                //    {
                //        Name = "醉千秋",
                //        Amount = 18.8m,
                //        DonateDate = new DateTime(2016, 4, 15)
                //    }
                //};
                var entity = new Donator
                {
                    Name = "阿文",
                    Amount = 18.8m,
                    DonateDate = new DateTime(2016, 4, 15)
                };
                context.Entry(entity).State = EntityState.Added;
                //context.Donators.AddRange(donators1);
                context.SaveChanges();
                ////Console.Write("DB has Created!");//提示DB创建成功
                //Console.Write("Creation Finished!");//提示创建完成

                #endregion 1.0 创建表记录

                #region 2.0 查询记录

                //var donators2 = context.Donators;
                //Console.WriteLine("Id\t\t姓名\t\t金额\t\t赞助日期");
                //foreach (var donator in donators2)
                //{
                //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", donator.DonatorId, donator.Name, donator.Amount, donator.DonateDate.ToShortDateString());
                //}

                #endregion 2.0 查询记录

                #region 3.0 更新记录

                //var donators3 = context.Donators;
                //if (donators3.Any())
                //{
                //    var toBeUpdate = donators3.FirstOrDefault(d => d.Name == "阿文");
                //    toBeUpdate.Name = "阿文Windy";
                //    context.SaveChanges();
                //}

                #endregion 3.0 更新记录

                #region 4.0 删除记录

                //var toBeDeleted = context.Donators.Single(a => a.Name == "阿文Windy");
                //if (toBeDeleted != null)
                //{
                //    context.Donators.Remove(toBeDeleted);
                //    context.SaveChanges();
                //}

                #endregion 4.0 删除记录

                #region 6.0 一对多关系

                //var donator = new Donator
                //{
                //    Amount = 6,
                //    Name = "键盘里的鼠标",
                //    DonateDate = DateTime.Parse("2016-4-13"),
                //};
                //donator.PayWays.Add(new PayWay { Name = "支付宝" });
                //donator.PayWays.Add(new PayWay { Name = "微信" });
                //context.Donators.Add(donator);
                //context.SaveChanges();

                #endregion 6.0 一对多关系
            }

            Console.Read();
        }
    }
}