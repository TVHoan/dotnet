using System.ComponentModel.DataAnnotations;

namespace dotnetbase.Models;

public class CategoryMenu
{
    [Key] public Guid Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}