using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksLib
{
	public class Book
	{
		public int ID { get; set; }
		public string Name { get; set; }
		
		public IEnumerable<Author> Author { get; set; }
		public Publisher Publisher { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime PublishDate { get; set; }
		public int PageCount { get; set; }
		public string ISBN { get; set; }
	}
}