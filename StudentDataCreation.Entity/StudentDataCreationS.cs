﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace StudentDataCreation.Entity
{
    public partial class StudentDataCreationS
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentSecondName { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool? IS_Deleted { get; set; }
        public DateTime? Create_Time_Stamp { get; set; }
        public DateTime? Update_Time_Stamp { get; set; }
    }
}