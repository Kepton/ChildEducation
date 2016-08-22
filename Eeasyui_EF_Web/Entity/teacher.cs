using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SchoolId { get; set; }
        public Nullable<int> Sex { get; set; }
        public string EducationExp { get; set; }
        public string speciality { get; set; }
    }
}
