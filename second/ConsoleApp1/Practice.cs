namespace ConsoleApp1
{
    public static class Practice
    {
        /// <summary>
        /// calculate BMI
        /// </summary>
        /// <param name="weight"> In Kg</param>
        /// <param name="height"> IN centimeter</param>
        public static void BMI(double weight , double height) {
            var bmi = weight / (Math.Pow(height,2)) * 10000;
            if (bmi < 18.5D)
            {
                Console.WriteLine("Underweight");
            }
            else if(bmi >= 18.5D &&  bmi < 25) {
                Console.WriteLine("Normal");
            
            }
            else if (bmi >= 25 && bmi < 30 )
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Fat");
            }
                
         }
        public static string NormalizePhoneNumber(this string phoneNumber)
        {
            if(phoneNumber.Length >= 11 &&  phoneNumber.Length <= 13) {

                if (phoneNumber.StartsWith("+98"))
                    return phoneNumber.Replace("+98", "0");
                else if (phoneNumber.StartsWith("0"))
                {
                    return phoneNumber;
                }

            }

             return "Not a phone number";
        }
    }
}
