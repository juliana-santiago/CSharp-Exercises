using ProcessFile.Entities;
using ProcessFile.Entities.Exceptions;
using System;

namespace ProcessFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                var number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                var checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                var checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}");
            }
        }
    }
}
