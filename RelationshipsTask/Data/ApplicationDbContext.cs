using System;
using Microsoft.EntityFrameworkCore;
using RelationshipsTask.Entities;

namespace RelationshipsTask.Data
{
	public class ApplicationDbContext: DbContext
	{

		public ApplicationDbContext(DbContextOptions options)
			:base(options)
		{

		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<BookReader> BookReaders { get; set; }
	}
}

