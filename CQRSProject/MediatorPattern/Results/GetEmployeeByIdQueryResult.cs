﻿namespace CQRSProject.MediatorPattern.Results
{
    public class GetEmployeeByIdQueryResult
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
