/***********************************************************************
 * Module:  Lijek.cs
 * Purpose: Definition of the Class Pregled.Lijek
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;
using System.Collections.Generic;

namespace Model.Examination
{
    public class Drug:Entity
    {
        public List<Ratio> ratio { get; set; }
        public String name { get; set; }
        public int id { get; set; }
        public String state { get; set; }


    }
}