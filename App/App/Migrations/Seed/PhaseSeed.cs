﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;

namespace App.Migrations.Seed
{
    /// <summary>
    /// 
    /// Class PhaseSeed
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class PhaseSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: PhaseSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new AppContext())
            {
                if (!db.Phases.Any())
                {
                    db.Phases.Add(new Phase("Preliminary", new DateTime(2017, 6, 5)));
                    db.Phases.Add(new Phase("Phase 1", new DateTime(2017, 6, 7)));
                    db.Phases.Add(new Phase("Phase 2", new DateTime(2017, 6, 9)));
                    db.Phases.Add(new Phase("Phase 3", new DateTime(2017, 6, 11)));

                    db.SaveChanges();
                }
            }
        }
    }
}
