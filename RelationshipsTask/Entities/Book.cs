using System;
namespace RelationshipsTask.Entities
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int AuthorId { get; set; }

		//nav props
		public virtual Author Author { get; set; }
		public virtual ICollection<BookReader> BookReaders { get; set; } 
		public Book()
		{
		}
	}
}

