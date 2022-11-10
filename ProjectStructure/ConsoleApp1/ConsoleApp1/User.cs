using ConsoleApp1;
using System;
using System.Collections;

public class User
{

    private string phone;
	public Guid Id { get; private set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDay { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Phone { get { return phone; } set { phone = RunApp.FormatPhoneNumber(value); } }
    public Role Role { get; set;}
    public ArrayList Activities { get; set; }

    public User()
    {
        Id = Guid.NewGuid();
    }

    public User(string firstName, string lastName, string email, string password, Role role)
    {
        Id = Guid.NewGuid();
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        Password = password;
        Role = role;
        Activities = new ArrayList();
    }
    
    public User( string firstName, string lastName, string email, string password, string phone, Role role)
    {
        Id = Guid.NewGuid();
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        Role=role;
        Phone = phone;
        Password = password;
        Activities = new ArrayList();

    }

    //public User(string firstName, string lastName, string email, string role, string phone)
    //{
    //    Id = Guid.NewGuid();
    //    LastName = lastName;
    //    FirstName = firstName;
    //    Email = email;
    //    Role = new Role(role);
    //    Phone = phone;
    //}
    public User(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, Role role)
    {
        Id = Guid.NewGuid();
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        BirthDay = date;
        Height = height;
        Weight = weight;
        Role = role;
        Password = password;
        Activities = new ArrayList();

    }

    public User(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, string phone, Role role)
    {
        Id = Guid.NewGuid();
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        BirthDay = date;
        Height = height;
        Weight = weight;
        Phone = phone;
        Role = role;
        Password = password;
        Activities = new ArrayList();

    }

}
