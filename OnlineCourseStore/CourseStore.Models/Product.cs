using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Models
{

	
	public class Product { 
	[Key]
	public int Id { get; set; }

	[Required]
	public string? Title { get; set; }

	[Display(Name = "Course Description")]
	public string? Description { get; set; }

	[Required]
	[Display(Name = "Instructor Name")]
	public string? Instructor { get; set; } // Replaces Author with Instructor

	[Required]
	[Display(Name = "Course Duration (Hours)")]
	[Range(1, 500)]
	public double Duration { get; set; } // New field for course duration

	[Required]
	[Display(Name = "Course Level")]
	public string? Level { get; set; } // Course level, e.g., Beginner, Intermediate, Advanced

        [Required]
        [Display(Name = "Course Content")]
	public string? Content { get; set; } // Optional content description

	[Required]
	[Display(Name = "Standard Price")]
	[Range(1, 5000)]
	public double StandardPrice { get; set; } // Replaces List Price with a more relevant term

	[Required]
	[Display(Name = "Discount Price for 1 - 50 Registrations")]
	[Range(1, 5000)]
	public double Price { get; set; } // Discount pricing as an example

	[Required]
	[Display(Name = "Discount Price for 50 - 100 Registrations")]
	[Range(1, 5000)]
	public double Price50 { get; set; }

	[Required]
	[Display(Name = "Discount Price for 100+ Registrations")]
	[Range(1, 5000)]
	public double Price100 { get; set; }

	public int CategoryId { get; set; }

	[ForeignKey(nameof(CategoryId))]
	[ValidateNever]
	public Category? Category { get; set; }

	[ValidateNever]
	public string? ImageUrl { get; set; } = ""; // Could be used for course thumbnail or preview image
}
}
