using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SATapp.DATA.EF.Models/*.metadata*/
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }

    public partial class ScheduledClass { }

    public partial class Student { }

    public partial class StudentStatus { }

    public partial class ScheduledClassStatus { }
}
