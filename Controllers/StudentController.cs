using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers;

public class StudentController : Controller
{
    // Lưu tạm danh sách trong bộ nhớ
    private static readonly List<Student> students = new();

    [HttpGet]
    public IActionResult index()
    {
        ViewBag.Students = students;
        return View(new Student());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult create(
        [Bind("name,age,email")] Student student)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Students = students;
            return View("Index", student);
        }

        student.id = students.Count + 1;
        students.Add(student);

        return RedirectToAction("Index");
    }
}