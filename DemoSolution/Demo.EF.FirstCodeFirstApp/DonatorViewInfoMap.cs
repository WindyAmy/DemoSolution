﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EF.FirstCodeFirstApp
{
    public class DonatorViewInfoMap : EntityTypeConfiguration<DonatorViewInfo>
    {
        public DonatorViewInfoMap()
        {
            HasKey(d => d.DonatorId);
            ToTable("DonatorViews");
        }
    }
}