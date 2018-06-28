using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class HealthProfileTest
    {
        static void Main(string[] args)
        {
            int weight, height, doBMonth, doBDay, doBYear, age;
            int localCurrentYear;
            string patientLast, patientFirst;
            char patientGender;
            double maxHeartRate, maxTargHR, minTargHR, patientBMI;

            localCurrentYear = DateTime.Now.Year;

            Console.WriteLine("Enter your first name and last name in first/last order: ");
            patientFirst = Console.ReadLine();
            patientLast = Console.ReadLine();

            Console.WriteLine("Enter your weight in pounds: ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height in inches: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the day of your day of the month of birth, the month, and the year, in the listed order:");
            Console.WriteLine("Day of birth: "); doBDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month of birth as an integer: "); doBMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year of birth: "); doBYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first character of your gender (male/female): "); patientGender = Convert.ToChar(Console.Read());

            HealthProfile randomMemberHealthProfile = new HealthProfile(weight, height, doBMonth, doBDay, doBYear, patientLast, patientFirst, patientGender);

            //perform heart rate methods on random member profile
            age = randomMemberHealthProfile.CalculateAge(localCurrentYear, doBYear);
            maxHeartRate = randomMemberHealthProfile.CalculateMaxumumHearRate(age);
            maxTargHR = randomMemberHealthProfile.CalculateUpperTargetHeartRateRangeBound(maxHeartRate);
            minTargHR = randomMemberHealthProfile.CalculateLowerTargetHeartRateRangeBound(maxHeartRate);
            patientBMI = randomMemberHealthProfile.CalculateBMI(height, weight);


            Console.WriteLine("Be prepared for a deluge of personal data!");Console.ReadKey();
            Console.WriteLine("Your age is: {0}", age); Console.WriteLine("Your first and last name are: {0} {1}", patientFirst, patientLast);Console.ReadKey();
            Console.WriteLine("Your Date of Birth is: {0}/{1}/{2}", doBMonth, doBDay, doBYear);Console.ReadKey();
            Console.WriteLine("Your gender is: {0}", patientGender);Console.ReadKey(); Console.WriteLine("Press another key to clear the screen..."); Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Your recommended Maximum heart rate is: {0}", maxHeartRate);Console.ReadKey();
            Console.WriteLine("Your recommended target heart rate range is from {0} to {1}", minTargHR, maxHeartRate);Console.ReadKey();
            Console.WriteLine("Your BMI is: {0}", patientBMI);Console.ReadKey();

    }//end main method
    }//end class
}//end namespace
