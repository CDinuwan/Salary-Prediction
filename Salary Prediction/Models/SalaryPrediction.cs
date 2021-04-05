using Microsoft.ML.Data;

namespace Salary_Prediction.Models
{
    public class SalaryPrediction
    {
        [ColumnName("Score")]
        public float PredictedSalary { get; set; }
    }
}