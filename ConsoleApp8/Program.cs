using ConsoleApp8.NewFolder.Exceptions;
using ConsoleApp8.NewFolder1;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {



         

            try
            {
                Human human = new Human();
                human.Name = Console.ReadLine();
                human.Surname = Console.ReadLine();
                human.Age = int.Parse(Console.ReadLine());

                if (human.Age == 0 || human.Age < 0)
                {
                    throw new AgeException("Yas yanlisdir");

                }

                

            }
            catch (AgeException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}