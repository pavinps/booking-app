// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace booking_app.Migrations
{
    [DbContext(typeof(BookingDb))]
    [Migration("20221006041245_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Amenities", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Roomid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Roomid");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("Booking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("checkInDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("checkOutDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("guestFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("guestLastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("numberOfAdults")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numberOfChildren")
                        .HasColumnType("INTEGER");

                    b.Property<int>("roomId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("roomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("adultCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("childCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("roomNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Amenities", b =>
                {
                    b.HasOne("Room", null)
                        .WithMany("amenities")
                        .HasForeignKey("Roomid");
                });

            modelBuilder.Entity("Booking", b =>
                {
                    b.HasOne("Room", "room")
                        .WithMany("bookings")
                        .HasForeignKey("roomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("Room", b =>
                {
                    b.Navigation("amenities");

                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
