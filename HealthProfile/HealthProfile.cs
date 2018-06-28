using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HealthProfile
{
    class HealthProfile
    {
        //variables
        private int patientWeight, patientHeight, patientDoBMonth, patientDoBDay, patientDoBYear, userage;
        private string patientLastName, patientFirstName;
        private char patientGender;
        private double userMaxHeartRate, lowerTargetHeartRatebound, upperTargetHeartRateBound;
        int currentYear = DateTime.Now.Year;

        //properties
        public string PatientLastName {
            get { return patientLastName; }
            set { patientLastName = value;
            } }
        public int PatientFirstName{ get; set; }
        public int PatientWeight { get; set;}
        public int PatientDoBMonth {
            get { return patientDoBMonth; }  set {
                if (value > 12 || value < 1) throw new ArgumentOutOfRangeException("Cannot enter a number more than 12 or less than 1.");
                else if (value >= 1 && value <=12) patientDoBMonth = value; } }
        public int PatientDoBDay {
            get { return PatientDoBDay; }
            set { if (patientDoBDay < 1 || patientDoBDay > 31) throw new ArgumentOutOfRangeException("Cannot enter a number more than 31 or less than 1.");
                else if (patientDoBDay <= 31 && patientDoBDay >= 1) patientDoBDay = value; } }
        public int PatientDoBYear {
            get { return PatientDoBYear; }
            set {if (patientDoBYear < 1859 || patientDoBYear > currentYear) throw new 
                        ArgumentOutOfRangeException("Cannot enter a number less than 1859 or more than {0}.", Convert.ToString(currentYear));
                else if (patientDoBYear >= 1859 && patientDoBYear <= currentYear) patientDoBYear = value;}
        } 
        public char PatientGender {
            get { return patientGender;}
            set {if (patientGender == 'M' || patientGender == 'F' || patientGender == 'm' || patientGender == 'f') patientGender = value;
                else throw new ArgumentOutOfRangeException("Please enter 'M' or 'F' only for gender.");
            } }

        public HealthProfile(int weight, int height, int monthDateOfBirth, int dayDateOfBirth, int yearDateOfBirth, string lastName, string firstName, char gender) {
            patientWeight = weight; patientHeight = height; patientDoBMonth = monthDateOfBirth; patientDoBDay = dayDateOfBirth; patientDoBYear = yearDateOfBirth;
            patientLastName = lastName; patientFirstName = firstName; patientGender = gender;
               }//end constructor

        public int CalculateAge(int methCurrentYear, int methYearOfBirth)
        {
            int userAge = methCurrentYear - methYearOfBirth;
            return userAge;
        }//end calculate age method

        //this method depends on either asking the user their age or using the calculate age method
        public double CalculateMaxumumHearRate(double methUserAge)
        {
            double userMaxHeartRate = 220 - methUserAge;
            return userMaxHeartRate;
        }//end calculate max heart rate method

        public double CalculateLowerTargetHeartRateRangeBound(double methMaxHeartRate)
        {
            double lowerTargetHeartRateBound;
            lowerTargetHeartRateBound = methMaxHeartRate * .5;
            return lowerTargetHeartRateBound;
        }//end calc calculate lower boundary target heart rate range

        public double CalculateUpperTargetHeartRateRangeBound(double methMaxHeartRate)
        {
            double upperTargetHeartRateBound;
            upperTargetHeartRateBound = methMaxHeartRate * .85;
            return upperTargetHeartRateBound;
        }//end calculate upper boundary target heart rate range

        public double CalculateBMI(int patientHeight, int patientWeight)
        {
            double bodyMassIndex = (patientWeight * 703) / (patientHeight * patientHeight);
            return bodyMassIndex;
        }//end calculate BMI

    }//end class
}//end namespace
