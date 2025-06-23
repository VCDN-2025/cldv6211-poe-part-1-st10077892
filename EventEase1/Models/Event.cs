using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventEase1.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public string? Description { get; set; }

    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; } = string.Empty; // Default value assigned

    public string? Name { get; set; }
}
