using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseProject
{
    public partial class LanguageCoursesForm : Form
    {
        public LanguageCoursesForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSetForCustomScripting.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter1.Fill(this.languageCoursesDataSetForCustomScripting.City);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSetForCustomScripting.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter1.Fill(this.languageCoursesDataSetForCustomScripting.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSetForCustomScripting.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter1.Fill(this.languageCoursesDataSetForCustomScripting.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSetForCustomScripting.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.languageCoursesDataSetForCustomScripting.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSetForCustomScripting.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter1.Fill(this.languageCoursesDataSetForCustomScripting.Course);
            PrivilegeChoiceForm form = new PrivilegeChoiceForm();
            form.ShowDialog();
            StreamReader sr = new StreamReader("privileges.lvl");
            string privilegeLevel = sr.ReadLine();
            if (privilegeLevel == "admin_privilege")
            {
                dataGridViewPrivileges(true);
            }
            else if (privilegeLevel == "user_privilege")
            {
                dataGridViewPrivileges(false);
            }
            else
            {
                MessageBox.Show("Error while detecting privilege level!\nPrivilege level set to <User>");
                dataGridViewPrivileges(false);
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.DBlanguageCoursesDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.DBlanguageCoursesDataSet.City);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.University". При необходимости она может быть перемещена или удалена.
            this.universityTableAdapter.Fill(this.DBlanguageCoursesDataSet.University);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.DBlanguageCoursesDataSet.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.DBlanguageCoursesDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.DBlanguageCoursesDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.DBlanguageCoursesDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.DBlanguageCoursesDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBlanguageCoursesDataSet.Language". При необходимости она может быть перемещена или удалена.
            this.languageTableAdapter.Fill(this.DBlanguageCoursesDataSet.Language);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageCoursesDataSet1.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.DBlanguageCoursesDataSet.Course);
        }

        private void dataGridViewPrivileges(bool value)
        {
            if (!value)
            {
                DGV_City.AllowUserToDeleteRows = value;
                DGV_City.AllowUserToAddRows = value;
                DGV_Country.AllowUserToDeleteRows = value;
                DGV_Country.AllowUserToAddRows = value;
                DGV_Course.AllowUserToDeleteRows = value;
                DGV_Course.AllowUserToAddRows = value;
                DGV_Department.AllowUserToDeleteRows = value;
                DGV_Department.AllowUserToAddRows = value;
                DGV_Faculty.AllowUserToDeleteRows = value;
                DGV_Faculty.AllowUserToAddRows = value;
                DGV_Group.AllowUserToDeleteRows = value;
                DGV_Group.AllowUserToAddRows = value;
                DGV_Language.AllowUserToDeleteRows = value;
                DGV_Language.AllowUserToAddRows = value;
                DGV_Student.AllowUserToDeleteRows = value;
                DGV_Student.AllowUserToAddRows = value;
                DGV_Teacher.AllowUserToDeleteRows = value;
                DGV_Teacher.AllowUserToAddRows = value;
                DGV_University.AllowUserToDeleteRows = value;
                DGV_University.AllowUserToAddRows = value;
                B_CommitChanges.Enabled = value;
                B_RefreshData.Enabled = value;
                B_RejectChanges.Enabled = value;
            }
        }

        private void B_CommitChanges_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                preparationOfSQLScript(TC_DatabaseTableChange.SelectedTab.Text)
            );
            preparationOfConnection(TC_DatabaseTableChange.SelectedTab.Text, command);
            preparationOfDataUpdate(TC_DatabaseTableChange.SelectedTab.Text, command);
            commitDataUpdate(TC_DatabaseTableChange.SelectedTab.Text);
        }

        private string preparationOfSQLScript(string tableName)
        {
            string script = "";
            switch(tableName)
            {
                case "Course":
                    script = "UPDATE Course SET idCourse = @idCourse, " +
                        "idLang = @idLang, idGroup = @idGroup, idTeacher = @idTeacher" +
                        "Audience = @Audience, Time = @Time, [Course Type] = @CourseType";
                    break;
                case "Language":
                    script = "UPDATE Language SET idLang = @idLang, " +
                        "Language = @Language, [Language Family] = @LanguageFamily, " +
                        "Prevalence = @Prevalence, [Language Writing Family] = @LanguageWritingFamily";
                    break;
                case "Teacher":
                    script = "UPDATE Teacher SET idTeacher = @idTeacher, " +
                        "[Last Name] = @LastName, Name = @Name, [Middle Name] = @MiddleName, " +
                        "idLang = @idLang, idGroup = @idGroup, idCountry = @idCountry";
                    break;
                case "Student":
                    script = "UPDATE Student SET idStudent = @idStudent, " +
                        "[Last Name] = @LastName, Name = @Name, MiddleName = @MiddleName, " +
                        "idGroup = @idGroup, idCountry = @idCountry, isEnrollee = @isEnrollee";
                    break;
                case "Group":
                    script = "UPDATE Group SET idGroup = @idGroup, " +
                        "[Group Name] = @GroupName, [Student Quantity] = @StudentQuantity, " +
                        "idDepartment = @idDepartment, [Enrollee Group] = @EnrolleeGroup";
                    break;
                case "Department":
                    script = "UPDATE Department SET idDepartment = @idDepartment, " +
                        "[Department Short Name] = @DepartmentShortName, " +
                        "[Department full Name] = @DepartmentfullName, " +
                        "idFaculty = @idFaculty, [Group Quantity] = @GroupQuantity";
                    break;
                case "Faculty":
                    script = "UPDATE Faculty SET idFaculty = @idFaculty, " +
                        "[Faculty Short Name] = @FacultyShortName, [Faculty Full Name] = @FacultyFullName, " +
                        "idUniversity = @idUniversity, [Department Quantity] = @DepartmentQuantity";
                    break;
                case "University":
                    script = "UPDATE University SET idUniversity = @idUniversity, " +
                        "[University Short Name] = @UniversityShortName, " +
                        "[University full Name] = @UniversityfullName, " +
                        "idCity = @idCity, [Faculty Quantity] = @Faculty Quantity";
                    break;
                case "City":
                    script = "UPDATE City SET idCity = @idCity, " +
                        "[City Name] = @CityName, idCountry = @idCountry, [University Quantity] = @UniversityQuantity, " +
                        "[Local Percent of Knowledge of Second Lang] = @LocalPercentofKnowledgeofSecondLang";
                    break;
                case "Country":
                    script = "UPDATE Country SET " +
                        "[Country Name] = @CountryName, idNativeLang = @idNativeLang, [City Quantity] = @CityQuantity, " +
                        "[Overall Percent of Knowledge of Second Lang] = @OverallPercentofKnowledgeofSecondLang";
                    /*script = "INSERT INTO Country (idCountry, [Country Name], idNativeLang, [City Quantity], " +
                        "[Overall Percent of Knowledge of Second Lang]) VALUES (@idCountry, @CountryName, " +
                        "@idNativeLang, @CityQuantity, @OverallPercentofKnowledgeofSecondLang)";*/
                    break;
                default: MessageBox.Show("Error while performing SQL Script");
                    break;
            }
            return script;
        }
        private void preparationOfConnection(string tableName, SqlCommand command)
        {
            switch (tableName)
            {
                case "Course":
                    command.Connection = courseTableAdapter.Connection;
                    courseTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Language":
                    command.Connection = languageTableAdapter.Connection;
                    languageTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Teacher":
                    command.Connection = teacherTableAdapter.Connection;
                    teacherTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Student":
                    command.Connection = studentTableAdapter.Connection;
                    studentTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Group":
                    command.Connection = groupTableAdapter.Connection;
                    groupTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Department":
                    command.Connection = departmentTableAdapter.Connection;
                    departmentTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Faculty":
                    command.Connection = facultyTableAdapter.Connection;
                    facultyTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "University":
                    command.Connection = universityTableAdapter.Connection;
                    universityTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "City":
                    command.Connection = cityTableAdapter.Connection;
                    cityTableAdapter.Adapter.UpdateCommand = command;
                    break;
                case "Country":
                    command.Connection = countryTableAdapter.Connection;
                    countryTableAdapter.Adapter.UpdateCommand = command;
                    break;
                default: MessageBox.Show("Error while connecting to database");
                    break;
            }
        }
        private void preparationOfDataUpdate(string tableName, SqlCommand command)
        {
            SqlParameter parameter;

            switch (tableName)
            {
                case "Course":
/****************************************************************************************/
                    parameter = new SqlParameter("@idCourse", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCourse";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idLang", SqlDbType.Decimal);
                    parameter.SourceColumn = "idLang";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idGroup", SqlDbType.Decimal);
                    parameter.SourceColumn = "idGroup";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idTeacher", SqlDbType.Decimal);
                    parameter.SourceColumn = "idTeacher";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Audience", SqlDbType.NChar);
                    parameter.SourceColumn = "Audience";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Time", SqlDbType.DateTime);
                    parameter.SourceColumn = "Time";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@CourseType", SqlDbType.NChar);
                    parameter.SourceColumn = "[Course Type]";
                    command.Parameters.Add(parameter);
                    break;
                case "Language":
/****************************************************************************************/
                    parameter = new SqlParameter("@idLang", SqlDbType.Decimal);
                    parameter.SourceColumn = "idLang";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Language", SqlDbType.NChar);
                    parameter.SourceColumn = "Language";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@LanguageFamily", SqlDbType.NChar);
                    parameter.SourceColumn = "[Language Family]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Prevalence", SqlDbType.Real);
                    parameter.SourceColumn = "Prevalence";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@LanguageWritingFamily", SqlDbType.NChar);
                    parameter.SourceColumn = "[Language Writing Family]";
                    command.Parameters.Add(parameter);
                    break;
                case "Teacher":
/****************************************************************************************/
                    parameter = new SqlParameter("@idTeacher", SqlDbType.Decimal);
                    parameter.SourceColumn = "idTeacher";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idLang", SqlDbType.Decimal);
                    parameter.SourceColumn = "idLang";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idGroup", SqlDbType.Decimal);
                    parameter.SourceColumn = "idGroup";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idCountry", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCountry";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@LastName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Last Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Name", SqlDbType.NChar);
                    parameter.SourceColumn = "Name";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@MiddleName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Middle Name]";
                    command.Parameters.Add(parameter);
                    break;
                case "Student":
/****************************************************************************************/
                    parameter = new SqlParameter("@idStudent", SqlDbType.Decimal);
                    parameter.SourceColumn = "idStudent";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@LastName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Last Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Name", SqlDbType.NChar);
                    parameter.SourceColumn = "Name";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@MiddleName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Middle Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idGroup", SqlDbType.Decimal);
                    parameter.SourceColumn = "idGroup";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idCountry", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCountry";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@isEnrollee", SqlDbType.Bit);
                    parameter.SourceColumn = "isEnrollee";
                    command.Parameters.Add(parameter);
                    break;
                case "Group":
/****************************************************************************************/
                    parameter = new SqlParameter("@idGroup", SqlDbType.Decimal);
                    parameter.SourceColumn = "idGroup";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@GroupName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Group Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@StudentQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[Student Quantity]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idDepartment", SqlDbType.Decimal);
                    parameter.SourceColumn = "idDepartment";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@EnrolleeGroup", SqlDbType.Bit);
                    parameter.SourceColumn = "[Enrollee Group]";
                    command.Parameters.Add(parameter);
                    break;
                case "Department":
/****************************************************************************************/
                    parameter = new SqlParameter("@idDepartment", SqlDbType.Decimal);
                    parameter.SourceColumn = "idDepartment";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DepartmentShortName", SqlDbType.NChar);
                    parameter.SourceColumn = "[Department Short Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DepartmentfullName", SqlDbType.NVarChar);
                    parameter.SourceColumn = "[Department full Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idFaculty", SqlDbType.Decimal);
                    parameter.SourceColumn = "idFaculty";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@GroupQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[Group Quantity]";
                    command.Parameters.Add(parameter);
                    break;
                case "Faculty":
/****************************************************************************************/
                    parameter = new SqlParameter("@idFaculty", SqlDbType.Decimal);
                    parameter.SourceColumn = "idFaculty";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@FacultyShortName", SqlDbType.NChar);
                    parameter.SourceColumn = "FacultyShortName";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@FacultyfullName", SqlDbType.NVarChar);
                    parameter.SourceColumn = "[Faculty full Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idUniversity", SqlDbType.Decimal);
                    parameter.SourceColumn = "idUniversity";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DepartmentQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[Department Quantity]";
                    command.Parameters.Add(parameter);
                    break;
                case "University":
/****************************************************************************************/
                    parameter = new SqlParameter("@idUniversity", SqlDbType.Decimal);
                    parameter.SourceColumn = "idUniversity";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@UniversityShortName", SqlDbType.NChar);
                    parameter.SourceColumn = "[University Short Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@UniversityfullName", SqlDbType.NVarChar);
                    parameter.SourceColumn = "[University full Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idCity", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCity";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@FacultyQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[Faculty Quantity]";
                    command.Parameters.Add(parameter);
                    break;
                case "City":
/****************************************************************************************/
                    parameter = new SqlParameter("@idCity", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCity";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@CityName", SqlDbType.NVarChar);
                    parameter.SourceColumn = "[City Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idCountry", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCountry";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@UniversityQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[University Quantity]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@LocalPercentofKnowledgeofSecondLang", SqlDbType.Int);
                    parameter.SourceColumn = "[Local Percent of Knowledge of Second Lang]";
                    command.Parameters.Add(parameter);
                    break;
                case "Country":
/****************************************************************************************/
                    parameter = new SqlParameter("@idCountry", SqlDbType.Decimal);
                    parameter.SourceColumn = "idCountry";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@CountryName", SqlDbType.NVarChar);
                    parameter.SourceColumn = "[Country Name]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@idNativeLang", SqlDbType.Decimal);
                    parameter.SourceColumn = "idNativeLang";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@CityQuantity", SqlDbType.Int);
                    parameter.SourceColumn = "[City Quantity]";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@OverallPercentofKnowledgeofSecondLang", SqlDbType.Int);
                    parameter.SourceColumn = "[Overall Percent of Knowledge of Second Lang]";
                    command.Parameters.Add(parameter);
                    break;
                default:
/****************************************************************************************/
                    MessageBox.Show("Error while updating data");
                    break;
            }
        }
        private void commitDataUpdate(string tableName)
        {
            switch (tableName)
            {
                case "Course":
                    courseTableAdapter.Update(DBlanguageCoursesDataSet.Course);
                    break;
                case "Language":
                    languageTableAdapter.Update(DBlanguageCoursesDataSet.Language);
                    break;
                case "Teacher":
                    teacherTableAdapter.Update(DBlanguageCoursesDataSet.Teacher);
                    break;
                case "Student":
                    studentTableAdapter.Update(DBlanguageCoursesDataSet.Student);
                    break;
                case "Group":
                    groupTableAdapter.Update(DBlanguageCoursesDataSet.Group);
                    break;
                case "Department":
                    departmentTableAdapter.Update(DBlanguageCoursesDataSet.Department);
                    break;
                case "Faculty":
                    facultyTableAdapter.Update(DBlanguageCoursesDataSet.Faculty);
                    break;
                case "University":
                    universityTableAdapter.Update(DBlanguageCoursesDataSet.University);
                    break;
                case "City":
                    cityTableAdapter.Update(DBlanguageCoursesDataSet.City);
                    break;
                case "Country":
                    countryTableAdapter.Update(DBlanguageCoursesDataSet.Country);
                    break;
                default: MessageBox.Show("Error while commiting update");
                    break;
            }
        }

        private void B_RejectChanges_Click(object sender, EventArgs e)
        {
            B_RefreshData_Click(sender, e);
        }

        private void B_RefreshData_Click(object sender, EventArgs e)
        {
            this.teacherTableAdapter.Fill(this.DBlanguageCoursesDataSet.Teacher);
            this.languageTableAdapter.Fill(this.DBlanguageCoursesDataSet.Language);
            this.courseTableAdapter.Fill(this.DBlanguageCoursesDataSet.Course);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        /*private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();
        }*/

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}


/*SqlConnection connection = new SqlConnection(@"Data Source = GHHOSTED; Initial Catalog = Test; Integrated Security = True");
            SqlCommand command = new SqlCommand(
                "SELECT ROW_NUMBER() OVER (ORDER BY idCourse) AS 'Course number', L.[Language], G.[Group Name], " +
                "T.[Last Name], T.[Name], T.[Middle Name] Audience, [Time], [Course Type] " +
                "FROM dbo.Course AS C " +
                "LEFT JOIN dbo.[Language] AS L ON C.idLang = L.idLang " +
                "LEFT JOIN dbo.[Group] AS G ON C.idGroup = G.idGroup " +
                "LEFT JOIN dbo.[Teacher] AS T ON C.idTeacher = T.idTeacher",
                connection
            );
            using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dataGridView8.ColumnCount = dataReader.FieldCount;
                for (int i = 0; i < dataReader.FieldCount; ++i)
                {
                    dataGridView8.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));
                    while (dataReader.Read())
                    {
                        //dataGridView8.UpdateCellValue()
                    }
                }
            }*/