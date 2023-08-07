﻿namespace InMemory.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
