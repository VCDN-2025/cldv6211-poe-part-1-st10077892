﻿using System;
using System.Collections.Generic;

namespace EventEase1.Models;

public partial class Venue
{
    public int VenueId { get; set; }

    public string VenueName { get; set; } = null!;

    public string? Location { get; set; }

    public int? Capacity { get; set; }

    public string? ImageUrl { get; set; }
}