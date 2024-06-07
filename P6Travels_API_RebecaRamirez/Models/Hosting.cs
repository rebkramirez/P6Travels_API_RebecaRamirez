﻿using System;
using System.Collections.Generic;

namespace P6Travels_API_RebecaRamirez.Models;

public partial class Hosting
{
    public int HostingId { get; set; }

    public string HostingName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string? Notes { get; set; }

    public int Stars { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
