namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter PhoneNumber: ");
            var phone = Console.ReadLine();

            var normalizedPhone = phone.NormalizePhoneNumber();

            Console.WriteLine("Entered phoneNumber => " + normalizedPhone);
            double weight;
            double height;

            while (true)
            {
                Console.Write("Enter Weight(kg): ");

                bool result1 = double.TryParse(Console.ReadLine(), out  weight);
                Console.Write("Enter height(cm): ");
                bool result2 = double.TryParse(Console.ReadLine(), out  height);
                if(!(result1 && result2))
                {
                    Console.WriteLine("Incorrect, input should be a number");
                }
                else
                {
                    break;
                }
            }

            

            Practice.BMI(weight,height);
        }
    }
}
