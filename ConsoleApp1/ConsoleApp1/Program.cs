using ConsoleApp1.Entities.Exceptions;
using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Data do check-in (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data do check-out (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reserv = new Reservation(num, checkin, checkout);
                Console.WriteLine(reserv);

                Console.WriteLine("\nDigite os dados para atualizar a reserva:");

                Console.Write("Data do check-in (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data do check-out (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserv.updateDates(checkin, checkout);
                Console.WriteLine(reserv);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: {0}", e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro no formato da entrada.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro inesperado.");
            }


        }
    }
}
