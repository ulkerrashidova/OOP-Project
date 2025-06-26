using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_Rashidova
{
    public class Clients
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }

        public Clients(string email, string firstName, string lastName, DateTime dob, string phone)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Phone = phone;
        }

        // Перевірка даних клієнта
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Email) && Email.Contains("@")
                && !string.IsNullOrWhiteSpace(FirstName)
                && !string.IsNullOrWhiteSpace(LastName)
                && DateOfBirth > new DateTime(1900, 1, 1)
                && Regex.IsMatch(Phone, @"^\+38\(0\d{2}\)-\d{7}$");
        }
        public bool Login(string email, string password)
        {
            // Перевіряє, чи емейл співпадає 
            return email == this.Email;
        }

        // Перевірка, чи є запис на прийом
        public bool HasAppointment(int appointmentId)
        {
            return appointmentId > 0;
        }
    }
}
