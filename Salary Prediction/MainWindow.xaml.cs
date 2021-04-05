using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Salary_Prediction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = new MLContext();

            var model = context.Model.Load("./MLModel/salary-model.zip",out DataViewSchema inputSchema);

            var predictionEngine = context.Model.CreatePredictionEngine<Models.SalaryData, Models.SalaryPrediction>(model, inputSchema: inputSchema);

            var prediction = predictionEngine.Predict(new Models.SalaryData
            {
                YearsExperience=float.Parse(yearsOfExpirience.Text)
            });

            result.Text = $"Predicted salary is {prediction.PredictedSalary.ToString("c")}";
        }
    }
}
