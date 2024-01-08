using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Domingo_DustinD_HWK2
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get exam scores and percentages from user input
            double firstExamScore = Convert.ToDouble(txtFirstExam.Text);
            double firstExamPercentage = Convert.ToDouble(txtFirstPercentage.Text);

            double secondExamScore = Convert.ToDouble(txtSecondExam.Text);
            double secondExamPercentage = Convert.ToDouble(txtSecondPercentage.Text);

            double thirdExamScore = Convert.ToDouble(txtThirdExam.Text);
            double thirdExamPercentage = Convert.ToDouble(txtThirdPercentage.Text);

            // Validate that the sum of percentages is 100
            double sumOfPercentages = firstExamPercentage + secondExamPercentage + thirdExamPercentage;

            // Calculate the weighted average

            double firstExamoverall = firstExamScore * (firstExamPercentage / 100);

            double secondExamoverall = secondExamScore * (secondExamPercentage / 100);

            double thirdExamoverall = thirdExamScore * (thirdExamPercentage / 100);

            double weightedAverage = firstExamoverall + secondExamoverall + thirdExamoverall;

            // Display the result
            Mod1Result.Text = $"Module 1 Overall: {firstExamoverall:F2}";

            Mod2Result.Text = $"Module 2 Overall: {secondExamoverall:F2}";

            Mod3Result.Text = $"Module 3 Overall: {thirdExamoverall:F2}";

            lblResult.Text = $"Weighted Average: {weightedAverage:F2}";

            string grade = GetGrade(weightedAverage);
            lblGrade.Text += $"<br/>Grade: {grade}";
        }

        private string GetGrade(double overallScore)
        {
            if (overallScore >= 94)
                return "A+";
            else if (overallScore >= 90)
                return "A";
            else if (overallScore >= 87)
                return "A-";
            else if (overallScore >= 84)
                return "B+";
            else if (overallScore >= 75)
                return "B";
            else
                return "Below B";
        }

    }
}