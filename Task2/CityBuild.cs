using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct CityBuild
    {
        public string CompanyName { get; set; }
        public string BuildObject { get; set; }
        public int Square { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }

        public CityBuild(string companyName, string buildObject, int square, DateTime startDate, DateTime endDate, string state)
        {
            CompanyName = companyName;
            BuildObject = buildObject;
            Square = square;
            StartDate = startDate;
            EndDate = endDate;
            State = state;
        }
        public int GetDays()
        {
            return EndDate.Subtract(StartDate).Days;
        }
        public override string ToString()
        {
            return $"{CompanyName, -12} | {BuildObject, -12} | {Square,5}м^2 | {StartDate.ToString("d"), -9} | {EndDate.ToString("d"), -12} | {State, - 10} | {GetDays()} д.";
        }
    }
}
