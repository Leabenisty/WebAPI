namespace Web_API.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int Idemployee { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public double Basesalary { get; set; }
      public  double Bouns { get; set; }

      public  double Finalesalary { get; set; }
        public bool Paidup { get ; set  ; }

      

        //מזהה רשומה ומזהה עובד
        //חודש ושנה
        //סכום כמה שעות חודשית ובונוס 
        //}
    }
}
