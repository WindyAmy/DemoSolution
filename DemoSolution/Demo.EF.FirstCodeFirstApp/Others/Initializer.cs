using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EF.FirstCodeFirstApp
{
    public class Initializer : DropCreateDatabaseAlways<Context> //DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //    context.PayWays.AddRange(new List<PayWay>
            //{
            //    new PayWay{Name = "支付宝"},
            //    new PayWay{Name = "微信"},
            //    new PayWay{Name = "QQ红包"}
            //});

            var drop = "drop table DonatorViews";
            context.Database.ExecuteSqlCommand(drop);
            var createView = @"CREATE VIEW [dbo].[DonatorViews]
                            AS SELECT
	dbo.Donators.DonatorId AS DonatorId,
	dbo.Donators.Name AS DonatorName,
	dbo.Donators.Amount AS Amount,
	dbo.Donators.DonateDate AS DonateDate,
	dbo.PayWays.NAME AS PayWayName
FROM dbo.Donators
INNER JOIN dbo.PayWays
	ON dbo.PayWays.DonatorId = dbo.Donators.DonatorId";
            context.Database.ExecuteSqlCommand(createView);

         
        }
    }
}