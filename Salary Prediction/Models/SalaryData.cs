using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Salary_Prediction.Models
{
    internal class SalaryData
    {
        [LoadColumn(0)]
        public float YearsExperience;

        [LoadColumn(1)]
        public float Salary;
    }
}
