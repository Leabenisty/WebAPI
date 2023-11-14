namespace Web_API.Entities
{
    public class Workhours
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }  
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int HoursDay { get; set; }
       
        //מזהה עובד
        //מזה רשומה
        //תאריך
        //מספר שעות
    }
}
