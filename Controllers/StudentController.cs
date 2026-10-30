using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers;

public class StudentController : Controller
{
    public IActionResult index()
    {
        var students = new List<Student>
        {
            new Student
            {
                id = 1,
                name = "Nguyen Van An",
                age = 20,
                email = "an@example.com"
            },
            new Student
            {
                id = 2,
                name = "Tran Binh",
                age = 21,
                email = "binh@example.com"
            },
            new Student
            {
                id = 3,
                name = "Le Han",
                age = 10,
                email = "han@example.com"
            }
        };

        return View(students);
    }
}