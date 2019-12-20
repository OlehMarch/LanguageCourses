using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBCourseProject
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string[] lables = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            int i = 0;
            for (double y = 0.1; y < 1; y += 0.1)
            {
                CourseChart.Series[0].Points.AddY(y);
                CourseChart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, lables[i], 0, LabelMarkStyle.LineSideMark));
                i++;
            }
            /*SqlConnection connection = new SqlConnection("server = GHHOSTED;Database=LanguageCourses;");
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Course;", connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CourseChart.Data

                    this.CourseChart.Series["Prevalence of courses by language"].Points.Add(reader.GetInt32(1));
                }
            }
            catch
            {

            }*/
        }
    }
}
