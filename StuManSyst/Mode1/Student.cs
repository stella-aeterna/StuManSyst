using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.Mode1
{
    public class Student
    {
        string id;
        string name;
        string gender;
        string phone;
        string address;
        string photo;

        public Student(string id, string name, string gender, string phone, string address, string photo)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.Photo = photo;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Photo { get => photo; set => photo = value; }
    }
}
