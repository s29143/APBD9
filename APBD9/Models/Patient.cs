﻿using System.ComponentModel.DataAnnotations;

namespace APBD9.Models;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = "";
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = "";
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = "";
    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}