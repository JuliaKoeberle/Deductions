﻿namespace DeductionsAPI.Models.ViewModels
{
    public class SummaryViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int DependentCount { get; set; }
    }
}