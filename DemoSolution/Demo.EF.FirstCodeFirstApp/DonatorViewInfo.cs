using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EF.FirstCodeFirstApp
{
    public class DonatorViewInfo
    {
        public int DonatorId { get; set; }
        public string DonatorName { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
        public string PayWayName { get; set; }
    }
}