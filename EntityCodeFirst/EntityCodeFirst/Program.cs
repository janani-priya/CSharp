using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    class Program
    {

        public class Course
        {

            public int ID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public float price { get; set; }
            public CourseLevel CourseLevel { get; set; }
            public Author author { get; set; }
            public IList<Tag> tags { get; set; }

        }

        public class Author
        {

            public int Id { get; set; }
            public string name { get; set; }
            public IList<Course> courses { get; set; }
        }

        public class Tag
        {
            public int Id { get; set; }
            public string name { get; set; }
            public IList<Course> courses { get; set; }
        }

        public enum CourseLevel
        {
            Beginner =1,
            Intermediate=2,
            Advanced =3
        }

        public class PlutoContext : DbContext
        {
            public DbSet<Course> Courses { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Tag> Tags { get; set; }
        }

        static void Main(string[] args)
        {
        }
    }
}
