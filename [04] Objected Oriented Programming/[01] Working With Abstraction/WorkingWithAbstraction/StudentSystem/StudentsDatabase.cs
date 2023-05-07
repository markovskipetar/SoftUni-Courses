using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    class StudentsDatabase
    {
        public Dictionary<string, Student> Repository { get; set; } = new Dictionary<string, Student>();
    }
}
