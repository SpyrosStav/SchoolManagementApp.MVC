using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class ClassMetadata
{
    [Display(Name = "Lecturer")]
    public string LecturerId { get; set; } = null!;

    [Display(Name = "Course")]
    public string CourseId { get; set; } = null!;
}

[ModelMetadataType(typeof(ClassMetadata))]
public partial class Class{}