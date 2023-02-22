using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_tk2672.Models
{
	public class ApplicationResponse
	{
		[Key]
		[Required]
		public int MovieId { get; set; }

		[Required(ErrorMessage = "Please enter a movie title")]
		public string Title { get; set; }

		[Required]
		public string Year { get; set; }

		[Required]
		public string Director { get; set; }

		[Required]
		public string Rating { get; set; }

		public bool Edited { get; set; }

		public string LentTo { get; set; }

		public string Notes { get; set; }

		// Build foreign key relationship
		[Required (ErrorMessage = "Please select a category")]
		public int CategoryId { get; set; }

		public Category Category { get; set; } 
	}
}