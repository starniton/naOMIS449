using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    abstract class Student
    {
        //Fields
        private string _name;
        private string _id;

        //Constructor
        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //ID property
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        //RequiredHours property (abstract)
        public abstract double RequiredHours
        {
            get;
        }
    }
}
