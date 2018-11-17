using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public Dictionary<string, int> assessments = new Dictionary<string, int>(5);
        private static int MAX_Subject = 5;
        private string name;
        private string surname;
        private int group;
       
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
       
        public int Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }
        
               
        public void Set(string key, int value)
        {
            if (assessments.ContainsKey(key))
            {
                assessments[key] = value;
            }
            else
            {
                assessments.Add(key, value);
            }
        }

        public int Get(string key)
        {
            int result = 0;

            if (assessments.ContainsKey(key))
            {
                result = assessments[key];
            }

            return result;
        }
        public void GetStudent()
        {
            Console.WriteLine("Name: {0} \n Surname: {1}  \n Group: {2} \n",
                name, surname,  group);

            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                Console.WriteLine("Subject: {0}, Evaluation: {1} \n", kvp.Key, kvp.Value);
            }

        }
        public float GetSubjectSum()
        {
            float SubjectSum = 0;
            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                SubjectSum += kvp.Value;
            }
            return SubjectSum / MAX_Subject;
        }
        public float GetSubjectSum(string Subject)
        {
            float SubjectSum = 0;
            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                if (kvp.Key.Equals(Subject))
                    SubjectSum = kvp.Value;
                break;
            }
            return SubjectSum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>();
           
            Student student1 = new Student
            {
                Name = "Anna",
                Surname = "Yurkovets",
                Group = 2,
             };
            student1.Set("ZI", 6);
            student1.Set("SP", 9);
            student1.Set("RIS", 8);
            student1.Set("MIOPIS", 6);
            student1.Set("AWP", 9);
            
            Student student2 = new Student
            {
                Name = "Esaulov",
                Surname = "Ilya",
                Group = 2,
            };
            student2.Set("ZI", 5);
            student2.Set("SP", 9);
            student2.Set("RIS", 8);
            student2.Set("MIOPIS", 4);
            student2.Set("AWP", 9);
            
            Student student3 = new Student
            {
                Name = "Sherlock",
                Surname = "Holmes",
                Group = 2,
            };
            student3.Set("ZI", 7);
            student3.Set("SP", 7);
            student3.Set("RIS", 8);
            student3.Set("MIOPIS", 9);
            student3.Set("AWP", 8);
            
            Student student4 = new Student
            {
                Name = "Jon",
                Surname = "Milton",
                Group = 2,
            };
            student4.Set("ZI", 8);
            student4.Set("SP", 6);
            student4.Set("RIS", 9);
            student4.Set("MIOPIS", 5);
            student4.Set("AWP", 8);
            
            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);
            
           
            float Sum_Subject = 0;
            int Person = listStudent.Count;
            foreach (var list in listStudent)
            {
                Sum_Subject += list.GetSubjectSum("ZI");
            }
            Console.WriteLine("Average mark of ZI: {0}", Sum_Subject / Person);
           
                   
            float Sum_Group = 0;
            foreach (var list in listStudent)
            {
                if (list.Group.Equals(2))
                    Sum_Group += list.GetSubjectSum();
            }
            Console.WriteLine("Average mark on the Group 2: {0}", Sum_Group / Person);
        }
    }
}
