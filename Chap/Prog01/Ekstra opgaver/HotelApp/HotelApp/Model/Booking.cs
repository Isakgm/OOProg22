﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Model;

[Table("Booking")]
public partial class Booking
{
    [Key]
    [Column("Booking_id")]
    public int BookingId { get; set; }

    [Column("Hotel_No")]
    public int HotelNo { get; set; }

    [Column("Guest_No")]
    public int GuestNo { get; set; }

    [Column("Date_From", TypeName = "date")]
    public DateTime DateFrom { get; set; }

    [Column("Date_To", TypeName = "date")]
    public DateTime DateTo { get; set; }

    [Column("Room_No")]
    public int RoomNo { get; set; }

    [ForeignKey("GuestNo")]
    [InverseProperty("Bookings")]
    public virtual Guest GuestNoNavigation { get; set; }

    [ForeignKey("RoomNo, HotelNo")]
    [InverseProperty("Bookings")]
    public virtual Room Room { get; set; }
}