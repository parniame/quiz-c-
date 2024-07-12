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
            else if(bmi >= 18.5D &&  bmi < 25D) {
                Console.WriteLine("Normal");
            
            }
            else if (bmi >= 25D && bmi < 30D )
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
            if (phoneNumber.Length == 11)
            {
                if (phoneNumber.StartsWith("0"))
                {
                    return phoneNumber;
                }
            }
            else if ( phoneNumber.Length == 13) {

                if (phoneNumber.StartsWith("+98"))
                    return phoneNumber.Replace("+98", "0");
                

            }

             return "Not a phone number";
        }
    }
}
