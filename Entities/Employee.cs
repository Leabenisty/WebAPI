namespace Web_API.Entities
{
    public class Employee
    { 
       public int id;           
       public string firstname;
       public  string lastname;
       public  int age; 
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }
        //public Employee(string firstname,string lastname,int age,int id)
        //{
        //    this.firstname = firstname;
        //    this.lastname = lastname;
        //    this.age = age;
        //    this.id = id;
        //}
    }
}
