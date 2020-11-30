using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CarInsurance.Models;

namespace CarInsurance.Services
{
    public class InsuranceQuoteService
    {
        /// <summary>
        /// Calculates the Insurance Quote for the Given Insuree
        /// </summary>
        /// <param name="insuree"></param>
        /// <returns></returns>
        public decimal CalculateQuote(Insuree insuree)
        {
            decimal basePremium = 50.0M;
            basePremium += DetermineAgePremium(insuree.DateOfBirth);
            basePremium += DetermineCarYearPremium(insuree.CarYear);
            basePremium += DetermineCarMakeAndModelPremium(insuree.CarMake, insuree.CarModel);

            // Add $10 for every speeding ticket the user has
            basePremium += (10.0M * insuree.SpeedingTickets);

            if(insuree.DUI)
            {
                // If the user has ever has a DUI, add 25% to the total
                basePremium += (basePremium * 0.25M);
            }

            if(insuree.CoverageType)
            {
                // If it's full coverage, add 50% to the total
                basePremium += (basePremium * 0.50M);
            }

            return basePremium;
        }

        /// <summary>
        /// Determines the Age Premium based on the given birth date
        /// </summary>
        /// <param name="dateOfBirth">Year of birth of the Insuree</param>
        /// <returns>The premium associated with the age of the Insuree</returns>
        private decimal DetermineAgePremium(DateTime dateOfBirth)
        {
            TimeSpan ageDifference = DateTime.Now - dateOfBirth;
            int ageInYears = (int)ageDifference.TotalDays / 365;

            // If the user is 18 and under, add $100 to the monthly total
            if(ageInYears <= 18)
            {
                return 100.0M;
            }
            // Else if the user is between 19 and 25, add $50 to the monthly total
            else if(ageInYears >= 19 && ageInYears <= 25)
            {
                return 50.0M;
            }
            // Else if the user is over 25, add $25 to the monthly total
            else
            {
                return 25.0M;
            }
        }

        /// <summary>
        /// Determines the car year premium based on the given car year
        /// </summary>
        /// <param name="carYear">The year of the car</param>
        /// <returns>The premium associated with the car year</returns>
        private decimal DetermineCarYearPremium(int carYear)
        {
            // IF the cards year is before 2000, add $25 to the monthly total
            if (carYear < 2000)
            {
                return 25.0M;
            }
            // Else if the car's year is after 2015, add $25 to the monthly total
            else if (carYear > 2015)
            {
                return 25.0M;
            }
            // Else add nothing to the monthly total
            else
            {
                return 0.0M;
            }
        }

        /// <summary>
        /// Determines the premium based on the make and model of the car
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <returns>The premium based on the make and model of the car</returns>
        private decimal DetermineCarMakeAndModelPremium(string make, string model)
        {
            decimal baseMakeModelPremium = 0.0M;
            // If the Car's make is a Porsche, add $25 to the price
            if (make == "Porsche")
            {
                baseMakeModelPremium += 25.0M;

                // If the Car's make is a Porsche and its model is a 911 Carrera, 
                // add an additional $25 to the price.
                if( model == "911 Carrera")
                {
                    baseMakeModelPremium += 25.0M;
                }
            }
            return baseMakeModelPremium;
        }
    }
}