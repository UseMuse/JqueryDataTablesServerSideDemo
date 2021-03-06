﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreServerSide.Models
{
    public class DemoExcel
    {
        public string Name { get; set; }

        public string Position { get; set; }

        [DisplayName("Office")]
        public string Offices { get; set; }

        [DisplayName("Experience")]
        public short? DemoNestedLevelOneExperience { get; set; }

        [Display(Name = "Extn")]
        public int? DemoNestedLevelOneExtension { get; set; }

        [DisplayName("Start Date")]
        public DateTime? DemoNestedLevelOneDemoNestedLevelTwosStartDates { get; set; }

        [DisplayName("Salary")]
        public long? DemoNestedLevelOneDemoNestedLevelTwosSalary { get; set; }
    }
}
