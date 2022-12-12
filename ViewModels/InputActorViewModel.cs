using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Models;

namespace MoviesApp.ViewModels;

public class InputActorViewModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
}