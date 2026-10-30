using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models;

public class Student
{
    public int id {get; set;}

    [Required(ErrorMessage = "Vui long nhap ten")]
    public string name {get; set;} = "";

    [Range(1, 120, ErrorMessage = "Toi phai tu 1 - 120")]
    public int age {get; set;}
    
    [Required(ErrorMessage = "Vui long nhap Email")]
    [EmailAddress(ErrorMessage = "Email khong hop le")]
    public string email {get; set;} = "";

}