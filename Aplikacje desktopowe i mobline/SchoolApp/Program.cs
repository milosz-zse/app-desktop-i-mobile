using System;
using Microsoft.EntityFrameworkCore;
using SchoolApp.database;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Run(); 

        }
    }
}
