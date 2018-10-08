using System;
using System.Collections.Generic;
using System.Linq;

namespace Bufftechs2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                //no matter what, delete and then create 
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                    if(!db.Student.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                Phone = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                Phone = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                Phone = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },                        
                        };

                        db.Student.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Student.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }   
            }
            using(var db1 = new AppDbContext())
            {
                db1.Database.EnsureDeleted();
                db1.Database.EnsureCreated();

                if(!db1.Client.Any())
                {
                    List<Client> client = new List<Client>()
                    {
                        new Client() 
                        {
                        ClientID = "69-69",
                        FirstName = "John",
                        LastName = "Doe",
                        Phone = "123-555-4321",
                        Email = "client@email.com"

                        }

                    };
                }

             
                Team a = new Team()
                {
                    TeamName = "Group A",
                    TeamContact = "Group Discord",
                    TeamMembers = "Team List "

                };

                Project p = new Project()
                {
                    ProjectName = "Black Book",
                    ClientID = "69-69",
                    ProjectDescription = "Student Registry Project"
                };

                Organization o = new Organization()
                {
                    OrgName = "Disney",
                    Phone = "123-333-6930",
                    Email = "disney@mail.com"  
                };

                Advisor b1 = new Advisor()
                {
                    AdvisorName = "Babb",
                    Phone = "123-222-2343",
                    Email = "email@email.com"
                };
            }
        }
    }
}
