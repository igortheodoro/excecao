using System;
using System.Collections;
using System.Text;
using ConsoleApp1.Entities.Exceptions;

namespace ConsoleApp1
{
    class Reservation
    {
        private int numQuarto;
        private DateTime checkin;
        private DateTime checkout;

        public Reservation(int numQuarto, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("A data do check-out deve ser após a data do check-in.");
            }

            this.numQuarto = numQuarto;
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public int duration()
        {
            TimeSpan duration = checkout.Subtract(checkin);
            return (int)duration.TotalDays;
        }

        public void updateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                throw new DomainException("A data de check-in deve ser mais atual. E a data de check-out deve ser após a data de check-in.");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("A data do check-out deve ser após a data do check-in.");
            }

            this.checkin = checkin;
            this.checkout = checkout;
        }

        public override string ToString()
        {
            return "Room numer: " + numQuarto
                + "\nDurations in days: " + duration()
                + "\nCheckin: " + checkin.ToString("dd/MM/yyyy")
                + "\nCheckout: " + checkout.ToString("dd/MM/yyyy");
        }
    }
}
