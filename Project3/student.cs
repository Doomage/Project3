﻿namespace Project3 {     public enum Conduct { good, poor, excellent }      internal class student     {         internal string Name { get; set; }         internal string LastName { get; set; }         internal string Age { get; set; }         internal string Phone { get; set; }         internal string Height { get; set; }         internal string Tuition { get; set; }         internal string Date { get; set; }         internal Conduct conduct { get; set; }          public student(string Name, string LastName, string Age, string Height, string Tuition, string Date, string Phone)         {             this.Name = Name;             this.LastName = LastName;             this.Age = Age;             this.Phone = Phone;             this.Height = Height;             this.Tuition = Tuition;             this.Date = Date;             conduct = Conduct.poor;         }      } } 