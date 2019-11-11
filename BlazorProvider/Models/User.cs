using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorProvider.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public long State { get; set; }
    }
}
