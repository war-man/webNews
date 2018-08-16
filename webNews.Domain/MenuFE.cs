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
	[Alias("MenuFE")]
    public partial class MenuFE : IHasId<int> 
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool? Show { get; set; }
        public int? MenuLevel { get; set; }
        public int? Order { get; set; }
        public string Lang { get; set; }
    }

}
#pragma warning restore 1591
