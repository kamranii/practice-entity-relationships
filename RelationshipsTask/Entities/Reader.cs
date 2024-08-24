using System;
namespace RelationshipsTask.Entities
{
	public class Reader
	{
		public int Id { get; set; }
		public string Name { get; set; }

		//nav props
		public virtual ICollection<BookReader> ReaderBooks { get; set; }
		public Reader()
		{
		}
	}
}

