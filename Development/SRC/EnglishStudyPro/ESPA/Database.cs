using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESPA
{
    public class ESPDatabase : DbContext
    {
        public ESPDatabase(string connectionString = null) : base(connectionString ?? "name=ESP")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ESPDatabase>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ESPSystem> System { get; set; }
        public DbSet<ESPCategory> Categories { get; set; }
        public DbSet<ESPClass> Classes { get; set; }
        public DbSet<ESPVocabulary> Vocabularies { get; set; }
    };

    [Table("System")]
    public class ESPSystem
    {
        [Column("name")]
        [Key]
        public string Name { get; set; }
        [Column("version")]
        public long Version { get; set; }
        [Column("desc")]
        public string Description { get; set; }
        [Column("pin")]
        public string PIN { get; set; }
        [Column("date")]
        public int Date { get; set; }

        public ESPSystem(string name, long version, string desc, string pin, int date)
        {
            this.Name = name;
            this.Version = version;
            this.Description = desc;
            this.PIN = pin;
            this.Date = date;
        }

        public ESPSystem()
        {
            this.Name = string.Empty;
            this.Version = 0;
            this.Description = string.Empty;
            this.PIN = string.Empty;
            this.Date = 0;
        }
    };

    [Table("Categories")]
    public class ESPCategory
    {
        [Column("id")]
        [Key]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("parent")]
        public long Parent { get; set; }
        [NotMapped]
        public string DisplayName { get; set; }
        [NotMapped]
        public ESPCategory ParentObject { get; set; }
        public ESPCategory(string name, string title, long parent = 0)
        {
            this.Id = 0;
            this.Name = name;
            this.Title = title;
            this.Parent = parent;
        }

        public ESPCategory()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Title = string.Empty;
            this.Parent = 0;
        }
    };

    [Table("Classes")]
    public class ESPClass
    {
        [Column("id")]
        [Key]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("title")]
        public string Title { get; set; }

        public ESPClass()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Title = string.Empty;
        }

        public ESPClass(string name, string title)
        {
            this.Name = name;
            this.Title = title;
        }
    };

    [Table("Vocabularies")]
    public class ESPVocabulary
    {
        [Column("name")]
        [Key]
        public string Name { get; set; }

        public ESPVocabulary()
        {
            this.Name = string.Empty;
        }
        public ESPVocabulary(string name)
        {
            this.Name = name;
        }
    }
}
