using System;
namespace RelationshipsTask.Entities
{
	public class BookReader
	{
		public int Id { get; set; }
		public int BookId { get; set; }
		public int ReaderId { get; set; }
		//nav props
		public virtual Book Book { get; set; }
		public virtual Reader Reader { get; set; }
	}
}

