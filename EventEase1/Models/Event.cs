using System;
using System.Collections.Generic;

namespace EventEase1.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public string? Description { get; set; }
}
