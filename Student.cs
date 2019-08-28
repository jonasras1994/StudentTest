using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Student
    {
        public Student _student;


        public string _name;
        public string _address;
        public int _semester;
        public Gender _gender;


        public string Name
        {
            get { return _name; }
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                CheckAddress(value);
                _address = value;
            }
        }

        public int Semester
        {
            get { return _semester; }
            set
            {
                CheckSemester(value);
                _semester = value;
            }
        }

        public Gender Gender
        {
            get => _gender;
            set { _gender = value; }
        }

        public Student(string name, string address, int semester, Gender gender)
        {
            CheckName(name);
            CheckAddress(address);
            CheckSemester(semester);
            Name = name;
            Address = address;
            Semester = semester;
            Gender = gender;
        }


        public void CheckName(string name)
        {
            if (name.Length < 2)
            {
                throw new ArgumentException("Name must have at least two characters!");
            }
        }

        public void CheckAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address is empty or null");
            }
        }

        public void CheckSemester(int semester)
        {
            if (semester < 1 || semester > 8)
            {
                throw new ArgumentException("Semester can only be between 1 and 8");
            }


            /* public override string ToString()
             {
                 return string.Format();
             }
             */
        }
    }
}
