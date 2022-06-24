using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabBigSchool.Models;

namespace LabBigSchool.ViewModels
{
    public class CoursesViewModel
    {
            public IEnumerable<Course> UpcommingCourses { get; set; }
            public bool ShowAction { get; set; }
        
    }
}