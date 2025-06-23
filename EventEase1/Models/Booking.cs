using System;
using System.Collections.Generic;

namespace EventEase1.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? EventId { get; set; }

    public int? VenueId { get; set; }

    public DateTime? BookingDate { get; set; }
}