using System;

namespace Project_Rashidova
{
    public class Appointment
    {
        public DateTime Date { get; set; }

        public Appointment(DateTime date)
        {
            Date = date;
        }

        public bool Book(DateTime newDate)
        {
            // Дозволяємо бронювати тільки на майбутні дати
            return newDate > DateTime.Now;
        }
    }
}



