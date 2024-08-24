using System;
namespace RelationshipsTask.Entities
{
	public class Author
	{
		public int Id { get; set; }
		public string Surname { get; set; }

		//nav prop
		public virtual ICollection<Book> Books { get; set; }
		public Author()
		{
		}
	}
}

