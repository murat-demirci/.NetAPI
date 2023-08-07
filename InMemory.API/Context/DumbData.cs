using InMemory.API.Models;

namespace InMemory.API.Context
{
    public static class DumbData
    {
        public static async Task InsertDatas()
        {
            try
            {
                List<Student> studentList = new() {
                new Student
                {
                    FirstName = "Murat",
                    LastName = "Demirci",
                    Number = "1030510013",
                    Notes = new List<Note>
                    {
                        new Note
                        {
                            Name = "C# Programming",
                            Point = 84.5,
                        },
                        new Note
                        {
                            Name = "Visual Programming",
                            Point = 76.5,
                        },
                        new Note
                        {
                            Name = "Veri Tabani Ve Yönetimi",
                            Point = 91,
                        }
                    }
                },
                new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Number = "1030510020",
                    Notes = new List<Note>
                    {
                        new Note
                        {
                            Name = "C# Programming",
                            Point = 87,
                        },
                        new Note
                        {
                            Name = "Visual Programming",
                            Point = 97,
                        },
                        new Note
                        {
                            Name = "Veri Tabani Ve Yönetimi",
                            Point = 63.5,
                        }
                    }
                }
                };
                using (var context = new InMemoryContext())
                {
                    await context.Students.AddRangeAsync(studentList);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
