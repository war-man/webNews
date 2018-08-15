// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ServiceStack;

namespace webNews.Domain.Entities
{
	[Alias("NewsCategory")]
    public partial class NewsCategory : IHasId<int> 
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public string Slug { get; set; }
        public string Action { get; set; }
        public string Tags { get; set; }
        public string Image { get; set; }
        [Required]
        public int Status { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? UpdatedById { get; set; }
    }

}
#pragma warning restore 1591
