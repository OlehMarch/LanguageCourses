namespace DBCourseProject
{
    partial class LanguageCoursesForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageCoursesForm));
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBlanguageCoursesSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBlanguageCoursesDataSet = new DBCourseProject.LanguageCoursesDataSet1();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.CourseTableAdapter();
            this.languageTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.LanguageTableAdapter();
            this.teacherTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.TeacherTableAdapter();
            this.studentTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.StudentTableAdapter();
            this.groupTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.GroupTableAdapter();
            this.departmentTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.DepartmentTableAdapter();
            this.facultyTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.FacultyTableAdapter();
            this.universityTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.UniversityTableAdapter();
            this.cityTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.CityTableAdapter();
            this.countryTableAdapter = new DBCourseProject.LanguageCoursesDataSet1TableAdapters.CountryTableAdapter();
            this.TC_MainOperations = new System.Windows.Forms.TabControl();
            this.TB_ViewData = new System.Windows.Forms.TabPage();
            this.TC_ViewData = new System.Windows.Forms.TabControl();
            this.TP_Courses = new System.Windows.Forms.TabPage();
            this.DGV_VD_Courses = new System.Windows.Forms.DataGridView();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audienceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.languageCoursesDataSetForCustomScriptingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageCoursesDataSetForCustomScripting = new DBCourseProject.LanguageCoursesDataSetForCustomScripting();
            this.TP_Teachers = new System.Windows.Forms.TabPage();
            this.DGV_VD_Teachers = new System.Windows.Forms.DataGridView();
            this.rowDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TP_Students = new System.Windows.Forms.TabPage();
            this.DGV_VD_Students = new System.Windows.Forms.DataGridView();
            this.rowDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnrolleeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.TP_Groups = new System.Windows.Forms.TabPage();
            this.DGV_VD_Groups = new System.Windows.Forms.DataGridView();
            this.rowDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolleeGroupDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TP_Cities = new System.Windows.Forms.TabPage();
            this.DGV_VD_Cities = new System.Windows.Forms.DataGridView();
            this.rowDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TB_ChangeData = new System.Windows.Forms.TabPage();
            this.B_RefreshData = new System.Windows.Forms.Button();
            this.B_RejectChanges = new System.Windows.Forms.Button();
            this.B_CommitChanges = new System.Windows.Forms.Button();
            this.TC_DatabaseTableChange = new System.Windows.Forms.TabControl();
            this.Course = new System.Windows.Forms.TabPage();
            this.DGV_Course = new System.Windows.Forms.DataGridView();
            this.idCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.TabPage();
            this.DGV_Language = new System.Windows.Forms.DataGridView();
            this.idLangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageFamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevalenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageWritingFamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.TabPage();
            this.DGV_Teacher = new System.Windows.Forms.DataGridView();
            this.idTeacherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLangDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.TabPage();
            this.DGV_Student = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCountryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnrolleeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Group = new System.Windows.Forms.TabPage();
            this.DGV_Group = new System.Windows.Forms.DataGridView();
            this.idGroupDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolleeGroupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Department = new System.Windows.Forms.TabPage();
            this.DGV_Department = new System.Windows.Forms.DataGridView();
            this.idDepartmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.TabPage();
            this.DGV_Faculty = new System.Windows.Forms.DataGridView();
            this.idFacultyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University = new System.Windows.Forms.TabPage();
            this.DGV_University = new System.Windows.Forms.DataGridView();
            this.idUniversityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.City = new System.Windows.Forms.TabPage();
            this.DGV_City = new System.Windows.Forms.DataGridView();
            this.idCityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCountryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.TabPage();
            this.DGV_Country = new System.Windows.Forms.DataGridView();
            this.idCountryDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNativeLangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new DBCourseProject.LanguageCoursesDataSetForCustomScriptingTableAdapters.CourseTableAdapter();
            this.studentTableAdapter1 = new DBCourseProject.LanguageCoursesDataSetForCustomScriptingTableAdapters.StudentTableAdapter();
            this.teacherTableAdapter1 = new DBCourseProject.LanguageCoursesDataSetForCustomScriptingTableAdapters.TeacherTableAdapter();
            this.groupTableAdapter1 = new DBCourseProject.LanguageCoursesDataSetForCustomScriptingTableAdapters.GroupTableAdapter();
            this.cityTableAdapter1 = new DBCourseProject.LanguageCoursesDataSetForCustomScriptingTableAdapters.CityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBlanguageCoursesSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBlanguageCoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.TC_MainOperations.SuspendLayout();
            this.TB_ViewData.SuspendLayout();
            this.TC_ViewData.SuspendLayout();
            this.TP_Courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCoursesDataSetForCustomScriptingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCoursesDataSetForCustomScripting)).BeginInit();
            this.TP_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            this.TP_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.TP_Groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            this.TP_Cities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Cities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            this.TB_ChangeData.SuspendLayout();
            this.TC_DatabaseTableChange.SuspendLayout();
            this.Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Course)).BeginInit();
            this.Language.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Language)).BeginInit();
            this.Teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Teacher)).BeginInit();
            this.Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Student)).BeginInit();
            this.Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Group)).BeginInit();
            this.Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Department)).BeginInit();
            this.Faculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Faculty)).BeginInit();
            this.University.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_University)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.City.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_City)).BeginInit();
            this.Country.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // DBlanguageCoursesSource
            // 
            this.DBlanguageCoursesSource.DataSource = this.DBlanguageCoursesDataSet;
            this.DBlanguageCoursesSource.Position = 0;
            // 
            // DBlanguageCoursesDataSet
            // 
            this.DBlanguageCoursesDataSet.DataSetName = "LanguageCoursesDataSet1";
            this.DBlanguageCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(942, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aboutToolStripMenuItem.Text = "About program";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.DBlanguageCoursesSource;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // universityTableAdapter
            // 
            this.universityTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // TC_MainOperations
            // 
            this.TC_MainOperations.Controls.Add(this.TB_ViewData);
            this.TC_MainOperations.Controls.Add(this.TB_ChangeData);
            this.TC_MainOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TC_MainOperations.ItemSize = new System.Drawing.Size(456, 30);
            this.TC_MainOperations.Location = new System.Drawing.Point(13, 40);
            this.TC_MainOperations.Name = "TC_MainOperations";
            this.TC_MainOperations.SelectedIndex = 0;
            this.TC_MainOperations.Size = new System.Drawing.Size(917, 575);
            this.TC_MainOperations.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TC_MainOperations.TabIndex = 2;
            // 
            // TB_ViewData
            // 
            this.TB_ViewData.Controls.Add(this.TC_ViewData);
            this.TB_ViewData.Location = new System.Drawing.Point(4, 34);
            this.TB_ViewData.Name = "TB_ViewData";
            this.TB_ViewData.Padding = new System.Windows.Forms.Padding(3);
            this.TB_ViewData.Size = new System.Drawing.Size(909, 537);
            this.TB_ViewData.TabIndex = 0;
            this.TB_ViewData.Text = "View Data";
            this.TB_ViewData.UseVisualStyleBackColor = true;
            // 
            // TC_ViewData
            // 
            this.TC_ViewData.Controls.Add(this.TP_Courses);
            this.TC_ViewData.Controls.Add(this.TP_Teachers);
            this.TC_ViewData.Controls.Add(this.TP_Students);
            this.TC_ViewData.Controls.Add(this.TP_Groups);
            this.TC_ViewData.Controls.Add(this.TP_Cities);
            this.TC_ViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TC_ViewData.ItemSize = new System.Drawing.Size(72, 30);
            this.TC_ViewData.Location = new System.Drawing.Point(6, 6);
            this.TC_ViewData.Multiline = true;
            this.TC_ViewData.Name = "TC_ViewData";
            this.TC_ViewData.SelectedIndex = 0;
            this.TC_ViewData.Size = new System.Drawing.Size(897, 525);
            this.TC_ViewData.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TC_ViewData.TabIndex = 13;
            // 
            // TP_Courses
            // 
            this.TP_Courses.BackColor = System.Drawing.Color.White;
            this.TP_Courses.Controls.Add(this.DGV_VD_Courses);
            this.TP_Courses.Location = new System.Drawing.Point(4, 34);
            this.TP_Courses.Name = "TP_Courses";
            this.TP_Courses.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Courses.Size = new System.Drawing.Size(889, 487);
            this.TP_Courses.TabIndex = 0;
            this.TP_Courses.Text = "Courses";
            // 
            // DGV_VD_Courses
            // 
            this.DGV_VD_Courses.AllowUserToAddRows = false;
            this.DGV_VD_Courses.AllowUserToDeleteRows = false;
            this.DGV_VD_Courses.AutoGenerateColumns = false;
            this.DGV_VD_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VD_Courses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_VD_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VD_Courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn1,
            this.languageDataGridViewTextBoxColumn1,
            this.groupNameDataGridViewTextBoxColumn1,
            this.teacherDataGridViewTextBoxColumn,
            this.audienceDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1});
            this.DGV_VD_Courses.DataSource = this.courseBindingSource2;
            this.DGV_VD_Courses.Location = new System.Drawing.Point(6, 6);
            this.DGV_VD_Courses.Name = "DGV_VD_Courses";
            this.DGV_VD_Courses.ReadOnly = true;
            this.DGV_VD_Courses.Size = new System.Drawing.Size(877, 475);
            this.DGV_VD_Courses.TabIndex = 0;
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            this.rowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTypeDataGridViewTextBoxColumn1
            // 
            this.courseTypeDataGridViewTextBoxColumn1.DataPropertyName = "Course Type";
            this.courseTypeDataGridViewTextBoxColumn1.HeaderText = "Course Type";
            this.courseTypeDataGridViewTextBoxColumn1.Name = "courseTypeDataGridViewTextBoxColumn1";
            this.courseTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn1
            // 
            this.languageDataGridViewTextBoxColumn1.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn1.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn1.Name = "languageDataGridViewTextBoxColumn1";
            this.languageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn1
            // 
            this.groupNameDataGridViewTextBoxColumn1.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn1.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn1.Name = "groupNameDataGridViewTextBoxColumn1";
            this.groupNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // audienceDataGridViewTextBoxColumn1
            // 
            this.audienceDataGridViewTextBoxColumn1.DataPropertyName = "Audience";
            this.audienceDataGridViewTextBoxColumn1.HeaderText = "Audience";
            this.audienceDataGridViewTextBoxColumn1.Name = "audienceDataGridViewTextBoxColumn1";
            this.audienceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // languageCoursesDataSetForCustomScriptingBindingSource
            // 
            this.languageCoursesDataSetForCustomScriptingBindingSource.DataSource = this.languageCoursesDataSetForCustomScripting;
            this.languageCoursesDataSetForCustomScriptingBindingSource.Position = 0;
            // 
            // languageCoursesDataSetForCustomScripting
            // 
            this.languageCoursesDataSetForCustomScripting.DataSetName = "LanguageCoursesDataSetForCustomScripting";
            this.languageCoursesDataSetForCustomScripting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TP_Teachers
            // 
            this.TP_Teachers.Controls.Add(this.DGV_VD_Teachers);
            this.TP_Teachers.Location = new System.Drawing.Point(4, 34);
            this.TP_Teachers.Name = "TP_Teachers";
            this.TP_Teachers.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Teachers.Size = new System.Drawing.Size(889, 487);
            this.TP_Teachers.TabIndex = 1;
            this.TP_Teachers.Text = "Teachers";
            this.TP_Teachers.UseVisualStyleBackColor = true;
            // 
            // DGV_VD_Teachers
            // 
            this.DGV_VD_Teachers.AllowUserToAddRows = false;
            this.DGV_VD_Teachers.AllowUserToDeleteRows = false;
            this.DGV_VD_Teachers.AutoGenerateColumns = false;
            this.DGV_VD_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VD_Teachers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_VD_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VD_Teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3,
            this.middleNameDataGridViewTextBoxColumn3,
            this.languageDataGridViewTextBoxColumn2,
            this.groupNameDataGridViewTextBoxColumn3,
            this.countryNameDataGridViewTextBoxColumn2});
            this.DGV_VD_Teachers.DataSource = this.teacherBindingSource1;
            this.DGV_VD_Teachers.Location = new System.Drawing.Point(6, 6);
            this.DGV_VD_Teachers.Name = "DGV_VD_Teachers";
            this.DGV_VD_Teachers.ReadOnly = true;
            this.DGV_VD_Teachers.Size = new System.Drawing.Size(877, 475);
            this.DGV_VD_Teachers.TabIndex = 0;
            // 
            // rowDataGridViewTextBoxColumn2
            // 
            this.rowDataGridViewTextBoxColumn2.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn2.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn2.Name = "rowDataGridViewTextBoxColumn2";
            this.rowDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn3
            // 
            this.lastNameDataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn3.Name = "lastNameDataGridViewTextBoxColumn3";
            this.lastNameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn3
            // 
            this.middleNameDataGridViewTextBoxColumn3.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn3.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn3.Name = "middleNameDataGridViewTextBoxColumn3";
            this.middleNameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn2
            // 
            this.languageDataGridViewTextBoxColumn2.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn2.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn2.Name = "languageDataGridViewTextBoxColumn2";
            this.languageDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn3
            // 
            this.groupNameDataGridViewTextBoxColumn3.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn3.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn3.Name = "groupNameDataGridViewTextBoxColumn3";
            this.groupNameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn2
            // 
            this.countryNameDataGridViewTextBoxColumn2.DataPropertyName = "Country Name";
            this.countryNameDataGridViewTextBoxColumn2.HeaderText = "Country Name";
            this.countryNameDataGridViewTextBoxColumn2.Name = "countryNameDataGridViewTextBoxColumn2";
            this.countryNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // TP_Students
            // 
            this.TP_Students.Controls.Add(this.DGV_VD_Students);
            this.TP_Students.Location = new System.Drawing.Point(4, 34);
            this.TP_Students.Name = "TP_Students";
            this.TP_Students.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Students.Size = new System.Drawing.Size(889, 487);
            this.TP_Students.TabIndex = 2;
            this.TP_Students.Text = "Students";
            this.TP_Students.UseVisualStyleBackColor = true;
            // 
            // DGV_VD_Students
            // 
            this.DGV_VD_Students.AllowUserToAddRows = false;
            this.DGV_VD_Students.AllowUserToDeleteRows = false;
            this.DGV_VD_Students.AutoGenerateColumns = false;
            this.DGV_VD_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VD_Students.BackgroundColor = System.Drawing.Color.White;
            this.DGV_VD_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VD_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.middleNameDataGridViewTextBoxColumn2,
            this.groupNameDataGridViewTextBoxColumn2,
            this.countryNameDataGridViewTextBoxColumn1,
            this.isEnrolleeDataGridViewCheckBoxColumn1});
            this.DGV_VD_Students.DataSource = this.studentBindingSource2;
            this.DGV_VD_Students.Location = new System.Drawing.Point(6, 6);
            this.DGV_VD_Students.Name = "DGV_VD_Students";
            this.DGV_VD_Students.ReadOnly = true;
            this.DGV_VD_Students.Size = new System.Drawing.Size(877, 475);
            this.DGV_VD_Students.TabIndex = 0;
            // 
            // rowDataGridViewTextBoxColumn1
            // 
            this.rowDataGridViewTextBoxColumn1.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn1.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn1.Name = "rowDataGridViewTextBoxColumn1";
            this.rowDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn2
            // 
            this.middleNameDataGridViewTextBoxColumn2.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn2.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn2.Name = "middleNameDataGridViewTextBoxColumn2";
            this.middleNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn2
            // 
            this.groupNameDataGridViewTextBoxColumn2.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn2.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn2.Name = "groupNameDataGridViewTextBoxColumn2";
            this.groupNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn1
            // 
            this.countryNameDataGridViewTextBoxColumn1.DataPropertyName = "Country Name";
            this.countryNameDataGridViewTextBoxColumn1.HeaderText = "Country Name";
            this.countryNameDataGridViewTextBoxColumn1.Name = "countryNameDataGridViewTextBoxColumn1";
            this.countryNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isEnrolleeDataGridViewCheckBoxColumn1
            // 
            this.isEnrolleeDataGridViewCheckBoxColumn1.DataPropertyName = "isEnrollee";
            this.isEnrolleeDataGridViewCheckBoxColumn1.HeaderText = "Enrollee";
            this.isEnrolleeDataGridViewCheckBoxColumn1.Name = "isEnrolleeDataGridViewCheckBoxColumn1";
            this.isEnrolleeDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // TP_Groups
            // 
            this.TP_Groups.Controls.Add(this.DGV_VD_Groups);
            this.TP_Groups.Location = new System.Drawing.Point(4, 34);
            this.TP_Groups.Name = "TP_Groups";
            this.TP_Groups.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Groups.Size = new System.Drawing.Size(889, 487);
            this.TP_Groups.TabIndex = 3;
            this.TP_Groups.Text = "Groups";
            this.TP_Groups.UseVisualStyleBackColor = true;
            // 
            // DGV_VD_Groups
            // 
            this.DGV_VD_Groups.AllowUserToAddRows = false;
            this.DGV_VD_Groups.AllowUserToDeleteRows = false;
            this.DGV_VD_Groups.AutoGenerateColumns = false;
            this.DGV_VD_Groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VD_Groups.BackgroundColor = System.Drawing.Color.White;
            this.DGV_VD_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VD_Groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDataGridViewTextBoxColumn3,
            this.groupNameDataGridViewTextBoxColumn4,
            this.studentQuantityDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.universityDataGridViewTextBoxColumn,
            this.enrolleeGroupDataGridViewCheckBoxColumn1});
            this.DGV_VD_Groups.DataSource = this.groupBindingSource1;
            this.DGV_VD_Groups.Location = new System.Drawing.Point(6, 6);
            this.DGV_VD_Groups.Name = "DGV_VD_Groups";
            this.DGV_VD_Groups.ReadOnly = true;
            this.DGV_VD_Groups.Size = new System.Drawing.Size(877, 475);
            this.DGV_VD_Groups.TabIndex = 0;
            // 
            // rowDataGridViewTextBoxColumn3
            // 
            this.rowDataGridViewTextBoxColumn3.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn3.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn3.Name = "rowDataGridViewTextBoxColumn3";
            this.rowDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn4
            // 
            this.groupNameDataGridViewTextBoxColumn4.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn4.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn4.Name = "groupNameDataGridViewTextBoxColumn4";
            this.groupNameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // studentQuantityDataGridViewTextBoxColumn1
            // 
            this.studentQuantityDataGridViewTextBoxColumn1.DataPropertyName = "Student Quantity";
            this.studentQuantityDataGridViewTextBoxColumn1.HeaderText = "Student Quantity";
            this.studentQuantityDataGridViewTextBoxColumn1.Name = "studentQuantityDataGridViewTextBoxColumn1";
            this.studentQuantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            this.facultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            this.universityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enrolleeGroupDataGridViewCheckBoxColumn1
            // 
            this.enrolleeGroupDataGridViewCheckBoxColumn1.DataPropertyName = "Enrollee Group";
            this.enrolleeGroupDataGridViewCheckBoxColumn1.HeaderText = "Enrollee Group";
            this.enrolleeGroupDataGridViewCheckBoxColumn1.Name = "enrolleeGroupDataGridViewCheckBoxColumn1";
            this.enrolleeGroupDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataMember = "Group";
            this.groupBindingSource1.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // TP_Cities
            // 
            this.TP_Cities.Controls.Add(this.DGV_VD_Cities);
            this.TP_Cities.Location = new System.Drawing.Point(4, 34);
            this.TP_Cities.Name = "TP_Cities";
            this.TP_Cities.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Cities.Size = new System.Drawing.Size(889, 487);
            this.TP_Cities.TabIndex = 4;
            this.TP_Cities.Text = "Cities";
            this.TP_Cities.UseVisualStyleBackColor = true;
            // 
            // DGV_VD_Cities
            // 
            this.DGV_VD_Cities.AllowUserToAddRows = false;
            this.DGV_VD_Cities.AllowUserToDeleteRows = false;
            this.DGV_VD_Cities.AutoGenerateColumns = false;
            this.DGV_VD_Cities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VD_Cities.BackgroundColor = System.Drawing.Color.White;
            this.DGV_VD_Cities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VD_Cities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDataGridViewTextBoxColumn4,
            this.cityNameDataGridViewTextBoxColumn1,
            this.countryNameDataGridViewTextBoxColumn3,
            this.languageDataGridViewTextBoxColumn3,
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1,
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1});
            this.DGV_VD_Cities.DataSource = this.cityBindingSource1;
            this.DGV_VD_Cities.Location = new System.Drawing.Point(7, 7);
            this.DGV_VD_Cities.Name = "DGV_VD_Cities";
            this.DGV_VD_Cities.ReadOnly = true;
            this.DGV_VD_Cities.Size = new System.Drawing.Size(876, 474);
            this.DGV_VD_Cities.TabIndex = 0;
            // 
            // rowDataGridViewTextBoxColumn4
            // 
            this.rowDataGridViewTextBoxColumn4.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn4.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn4.Name = "rowDataGridViewTextBoxColumn4";
            this.rowDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cityNameDataGridViewTextBoxColumn1
            // 
            this.cityNameDataGridViewTextBoxColumn1.DataPropertyName = "City Name";
            this.cityNameDataGridViewTextBoxColumn1.HeaderText = "City Name";
            this.cityNameDataGridViewTextBoxColumn1.Name = "cityNameDataGridViewTextBoxColumn1";
            this.cityNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn3
            // 
            this.countryNameDataGridViewTextBoxColumn3.DataPropertyName = "Country Name";
            this.countryNameDataGridViewTextBoxColumn3.HeaderText = "Country Name";
            this.countryNameDataGridViewTextBoxColumn3.Name = "countryNameDataGridViewTextBoxColumn3";
            this.countryNameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn3
            // 
            this.languageDataGridViewTextBoxColumn3.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn3.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn3.Name = "languageDataGridViewTextBoxColumn3";
            this.languageDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1
            // 
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.DataPropertyName = "Local Percent of Knowledge of Second Lang";
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.HeaderText = "Local Percent of Knowledge of Second Lang";
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.Name = "localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1";
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1
            // 
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.DataPropertyName = "Overall Percent of Knowledge of Second Lang";
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.HeaderText = "Overall Percent of Knowledge of Second Lang";
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.Name = "overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1";
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // TB_ChangeData
            // 
            this.TB_ChangeData.Controls.Add(this.B_RefreshData);
            this.TB_ChangeData.Controls.Add(this.B_RejectChanges);
            this.TB_ChangeData.Controls.Add(this.B_CommitChanges);
            this.TB_ChangeData.Controls.Add(this.TC_DatabaseTableChange);
            this.TB_ChangeData.Location = new System.Drawing.Point(4, 34);
            this.TB_ChangeData.Name = "TB_ChangeData";
            this.TB_ChangeData.Padding = new System.Windows.Forms.Padding(3);
            this.TB_ChangeData.Size = new System.Drawing.Size(909, 537);
            this.TB_ChangeData.TabIndex = 1;
            this.TB_ChangeData.Text = "Change data";
            this.TB_ChangeData.UseVisualStyleBackColor = true;
            // 
            // B_RefreshData
            // 
            this.B_RefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_RefreshData.Image = ((System.Drawing.Image)(resources.GetObject("B_RefreshData.Image")));
            this.B_RefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_RefreshData.Location = new System.Drawing.Point(633, 480);
            this.B_RefreshData.Name = "B_RefreshData";
            this.B_RefreshData.Size = new System.Drawing.Size(173, 45);
            this.B_RefreshData.TabIndex = 15;
            this.B_RefreshData.Text = "Refresh Data";
            this.B_RefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_RefreshData.UseVisualStyleBackColor = true;
            // 
            // B_RejectChanges
            // 
            this.B_RejectChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_RejectChanges.Image = ((System.Drawing.Image)(resources.GetObject("B_RejectChanges.Image")));
            this.B_RejectChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_RejectChanges.Location = new System.Drawing.Point(371, 480);
            this.B_RejectChanges.Name = "B_RejectChanges";
            this.B_RejectChanges.Size = new System.Drawing.Size(173, 45);
            this.B_RejectChanges.TabIndex = 14;
            this.B_RejectChanges.Text = "Reject changes";
            this.B_RejectChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_RejectChanges.UseVisualStyleBackColor = true;
            // 
            // B_CommitChanges
            // 
            this.B_CommitChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_CommitChanges.Image = ((System.Drawing.Image)(resources.GetObject("B_CommitChanges.Image")));
            this.B_CommitChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_CommitChanges.Location = new System.Drawing.Point(109, 480);
            this.B_CommitChanges.Name = "B_CommitChanges";
            this.B_CommitChanges.Size = new System.Drawing.Size(173, 45);
            this.B_CommitChanges.TabIndex = 13;
            this.B_CommitChanges.Text = "Commit changes";
            this.B_CommitChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_CommitChanges.UseVisualStyleBackColor = true;
            // 
            // TC_DatabaseTableChange
            // 
            this.TC_DatabaseTableChange.Controls.Add(this.Course);
            this.TC_DatabaseTableChange.Controls.Add(this.Language);
            this.TC_DatabaseTableChange.Controls.Add(this.Teacher);
            this.TC_DatabaseTableChange.Controls.Add(this.Student);
            this.TC_DatabaseTableChange.Controls.Add(this.Group);
            this.TC_DatabaseTableChange.Controls.Add(this.Department);
            this.TC_DatabaseTableChange.Controls.Add(this.Faculty);
            this.TC_DatabaseTableChange.Controls.Add(this.University);
            this.TC_DatabaseTableChange.Controls.Add(this.City);
            this.TC_DatabaseTableChange.Controls.Add(this.Country);
            this.TC_DatabaseTableChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TC_DatabaseTableChange.ItemSize = new System.Drawing.Size(72, 30);
            this.TC_DatabaseTableChange.Location = new System.Drawing.Point(6, 6);
            this.TC_DatabaseTableChange.Multiline = true;
            this.TC_DatabaseTableChange.Name = "TC_DatabaseTableChange";
            this.TC_DatabaseTableChange.SelectedIndex = 0;
            this.TC_DatabaseTableChange.Size = new System.Drawing.Size(897, 468);
            this.TC_DatabaseTableChange.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TC_DatabaseTableChange.TabIndex = 12;
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.White;
            this.Course.Controls.Add(this.DGV_Course);
            this.Course.Location = new System.Drawing.Point(4, 34);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(3);
            this.Course.Size = new System.Drawing.Size(889, 430);
            this.Course.TabIndex = 0;
            this.Course.Text = "Course";
            // 
            // DGV_Course
            // 
            this.DGV_Course.AutoGenerateColumns = false;
            this.DGV_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Course.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourseDataGridViewTextBoxColumn,
            this.idLangDataGridViewTextBoxColumn,
            this.idGroupDataGridViewTextBoxColumn,
            this.idTeacherDataGridViewTextBoxColumn,
            this.audienceDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn});
            this.DGV_Course.DataSource = this.courseBindingSource;
            this.DGV_Course.Location = new System.Drawing.Point(6, 6);
            this.DGV_Course.Name = "DGV_Course";
            this.DGV_Course.Size = new System.Drawing.Size(877, 418);
            this.DGV_Course.TabIndex = 0;
            // 
            // idCourseDataGridViewTextBoxColumn
            // 
            this.idCourseDataGridViewTextBoxColumn.DataPropertyName = "idCourse";
            this.idCourseDataGridViewTextBoxColumn.HeaderText = "idCourse";
            this.idCourseDataGridViewTextBoxColumn.Name = "idCourseDataGridViewTextBoxColumn";
            // 
            // idLangDataGridViewTextBoxColumn
            // 
            this.idLangDataGridViewTextBoxColumn.DataPropertyName = "idLang";
            this.idLangDataGridViewTextBoxColumn.HeaderText = "idLang";
            this.idLangDataGridViewTextBoxColumn.Name = "idLangDataGridViewTextBoxColumn";
            // 
            // idGroupDataGridViewTextBoxColumn
            // 
            this.idGroupDataGridViewTextBoxColumn.DataPropertyName = "idGroup";
            this.idGroupDataGridViewTextBoxColumn.HeaderText = "idGroup";
            this.idGroupDataGridViewTextBoxColumn.Name = "idGroupDataGridViewTextBoxColumn";
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            // 
            // audienceDataGridViewTextBoxColumn
            // 
            this.audienceDataGridViewTextBoxColumn.DataPropertyName = "Audience";
            this.audienceDataGridViewTextBoxColumn.HeaderText = "Audience";
            this.audienceDataGridViewTextBoxColumn.Name = "audienceDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "Course Type";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "Course Type";
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            // 
            // Language
            // 
            this.Language.Controls.Add(this.DGV_Language);
            this.Language.Location = new System.Drawing.Point(4, 34);
            this.Language.Name = "Language";
            this.Language.Padding = new System.Windows.Forms.Padding(3);
            this.Language.Size = new System.Drawing.Size(889, 430);
            this.Language.TabIndex = 1;
            this.Language.Text = "Language";
            this.Language.UseVisualStyleBackColor = true;
            // 
            // DGV_Language
            // 
            this.DGV_Language.AutoGenerateColumns = false;
            this.DGV_Language.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Language.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Language.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Language.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLangDataGridViewTextBoxColumn1,
            this.languageDataGridViewTextBoxColumn,
            this.languageFamilyDataGridViewTextBoxColumn,
            this.prevalenceDataGridViewTextBoxColumn,
            this.languageWritingFamilyDataGridViewTextBoxColumn});
            this.DGV_Language.DataSource = this.languageBindingSource;
            this.DGV_Language.Location = new System.Drawing.Point(6, 6);
            this.DGV_Language.Name = "DGV_Language";
            this.DGV_Language.Size = new System.Drawing.Size(877, 418);
            this.DGV_Language.TabIndex = 0;
            // 
            // idLangDataGridViewTextBoxColumn1
            // 
            this.idLangDataGridViewTextBoxColumn1.DataPropertyName = "idLang";
            this.idLangDataGridViewTextBoxColumn1.HeaderText = "idLang";
            this.idLangDataGridViewTextBoxColumn1.Name = "idLangDataGridViewTextBoxColumn1";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // languageFamilyDataGridViewTextBoxColumn
            // 
            this.languageFamilyDataGridViewTextBoxColumn.DataPropertyName = "Language Family";
            this.languageFamilyDataGridViewTextBoxColumn.HeaderText = "Language Family";
            this.languageFamilyDataGridViewTextBoxColumn.Name = "languageFamilyDataGridViewTextBoxColumn";
            // 
            // prevalenceDataGridViewTextBoxColumn
            // 
            this.prevalenceDataGridViewTextBoxColumn.DataPropertyName = "Prevalence";
            this.prevalenceDataGridViewTextBoxColumn.HeaderText = "Prevalence";
            this.prevalenceDataGridViewTextBoxColumn.Name = "prevalenceDataGridViewTextBoxColumn";
            // 
            // languageWritingFamilyDataGridViewTextBoxColumn
            // 
            this.languageWritingFamilyDataGridViewTextBoxColumn.DataPropertyName = "Language Writing Family";
            this.languageWritingFamilyDataGridViewTextBoxColumn.HeaderText = "Language Writing Family";
            this.languageWritingFamilyDataGridViewTextBoxColumn.Name = "languageWritingFamilyDataGridViewTextBoxColumn";
            // 
            // Teacher
            // 
            this.Teacher.Controls.Add(this.DGV_Teacher);
            this.Teacher.Location = new System.Drawing.Point(4, 34);
            this.Teacher.Name = "Teacher";
            this.Teacher.Padding = new System.Windows.Forms.Padding(3);
            this.Teacher.Size = new System.Drawing.Size(889, 430);
            this.Teacher.TabIndex = 2;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // DGV_Teacher
            // 
            this.DGV_Teacher.AutoGenerateColumns = false;
            this.DGV_Teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Teacher.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacherDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.idLangDataGridViewTextBoxColumn2,
            this.idGroupDataGridViewTextBoxColumn1,
            this.idCountryDataGridViewTextBoxColumn});
            this.DGV_Teacher.DataSource = this.teacherBindingSource;
            this.DGV_Teacher.Location = new System.Drawing.Point(6, 6);
            this.DGV_Teacher.Name = "DGV_Teacher";
            this.DGV_Teacher.Size = new System.Drawing.Size(877, 418);
            this.DGV_Teacher.TabIndex = 0;
            // 
            // idTeacherDataGridViewTextBoxColumn1
            // 
            this.idTeacherDataGridViewTextBoxColumn1.DataPropertyName = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn1.HeaderText = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn1.Name = "idTeacherDataGridViewTextBoxColumn1";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // idLangDataGridViewTextBoxColumn2
            // 
            this.idLangDataGridViewTextBoxColumn2.DataPropertyName = "idLang";
            this.idLangDataGridViewTextBoxColumn2.HeaderText = "idLang";
            this.idLangDataGridViewTextBoxColumn2.Name = "idLangDataGridViewTextBoxColumn2";
            // 
            // idGroupDataGridViewTextBoxColumn1
            // 
            this.idGroupDataGridViewTextBoxColumn1.DataPropertyName = "idGroup";
            this.idGroupDataGridViewTextBoxColumn1.HeaderText = "idGroup";
            this.idGroupDataGridViewTextBoxColumn1.Name = "idGroupDataGridViewTextBoxColumn1";
            // 
            // idCountryDataGridViewTextBoxColumn
            // 
            this.idCountryDataGridViewTextBoxColumn.DataPropertyName = "idCountry";
            this.idCountryDataGridViewTextBoxColumn.HeaderText = "idCountry";
            this.idCountryDataGridViewTextBoxColumn.Name = "idCountryDataGridViewTextBoxColumn";
            // 
            // Student
            // 
            this.Student.Controls.Add(this.DGV_Student);
            this.Student.Location = new System.Drawing.Point(4, 34);
            this.Student.Name = "Student";
            this.Student.Padding = new System.Windows.Forms.Padding(3);
            this.Student.Size = new System.Drawing.Size(889, 430);
            this.Student.TabIndex = 3;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // DGV_Student
            // 
            this.DGV_Student.AutoGenerateColumns = false;
            this.DGV_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Student.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.middleNameDataGridViewTextBoxColumn1,
            this.idGroupDataGridViewTextBoxColumn2,
            this.idCountryDataGridViewTextBoxColumn1,
            this.isEnrolleeDataGridViewCheckBoxColumn});
            this.DGV_Student.DataSource = this.studentBindingSource;
            this.DGV_Student.Location = new System.Drawing.Point(6, 6);
            this.DGV_Student.Name = "DGV_Student";
            this.DGV_Student.Size = new System.Drawing.Size(877, 418);
            this.DGV_Student.TabIndex = 0;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "idStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "idStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // middleNameDataGridViewTextBoxColumn1
            // 
            this.middleNameDataGridViewTextBoxColumn1.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.Name = "middleNameDataGridViewTextBoxColumn1";
            // 
            // idGroupDataGridViewTextBoxColumn2
            // 
            this.idGroupDataGridViewTextBoxColumn2.DataPropertyName = "idGroup";
            this.idGroupDataGridViewTextBoxColumn2.HeaderText = "idGroup";
            this.idGroupDataGridViewTextBoxColumn2.Name = "idGroupDataGridViewTextBoxColumn2";
            // 
            // idCountryDataGridViewTextBoxColumn1
            // 
            this.idCountryDataGridViewTextBoxColumn1.DataPropertyName = "idCountry";
            this.idCountryDataGridViewTextBoxColumn1.HeaderText = "idCountry";
            this.idCountryDataGridViewTextBoxColumn1.Name = "idCountryDataGridViewTextBoxColumn1";
            // 
            // isEnrolleeDataGridViewCheckBoxColumn
            // 
            this.isEnrolleeDataGridViewCheckBoxColumn.DataPropertyName = "isEnrollee";
            this.isEnrolleeDataGridViewCheckBoxColumn.HeaderText = "isEnrollee";
            this.isEnrolleeDataGridViewCheckBoxColumn.Name = "isEnrolleeDataGridViewCheckBoxColumn";
            // 
            // Group
            // 
            this.Group.Controls.Add(this.DGV_Group);
            this.Group.Location = new System.Drawing.Point(4, 34);
            this.Group.Name = "Group";
            this.Group.Padding = new System.Windows.Forms.Padding(3);
            this.Group.Size = new System.Drawing.Size(889, 430);
            this.Group.TabIndex = 4;
            this.Group.Text = "Group";
            this.Group.UseVisualStyleBackColor = true;
            // 
            // DGV_Group
            // 
            this.DGV_Group.AutoGenerateColumns = false;
            this.DGV_Group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Group.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGroupDataGridViewTextBoxColumn3,
            this.groupNameDataGridViewTextBoxColumn,
            this.studentQuantityDataGridViewTextBoxColumn,
            this.idDepartmentDataGridViewTextBoxColumn,
            this.enrolleeGroupDataGridViewCheckBoxColumn});
            this.DGV_Group.DataSource = this.groupBindingSource;
            this.DGV_Group.Location = new System.Drawing.Point(7, 7);
            this.DGV_Group.Name = "DGV_Group";
            this.DGV_Group.Size = new System.Drawing.Size(876, 417);
            this.DGV_Group.TabIndex = 0;
            // 
            // idGroupDataGridViewTextBoxColumn3
            // 
            this.idGroupDataGridViewTextBoxColumn3.DataPropertyName = "idGroup";
            this.idGroupDataGridViewTextBoxColumn3.HeaderText = "idGroup";
            this.idGroupDataGridViewTextBoxColumn3.Name = "idGroupDataGridViewTextBoxColumn3";
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // studentQuantityDataGridViewTextBoxColumn
            // 
            this.studentQuantityDataGridViewTextBoxColumn.DataPropertyName = "Student Quantity";
            this.studentQuantityDataGridViewTextBoxColumn.HeaderText = "Student Quantity";
            this.studentQuantityDataGridViewTextBoxColumn.Name = "studentQuantityDataGridViewTextBoxColumn";
            // 
            // idDepartmentDataGridViewTextBoxColumn
            // 
            this.idDepartmentDataGridViewTextBoxColumn.DataPropertyName = "idDepartment";
            this.idDepartmentDataGridViewTextBoxColumn.HeaderText = "idDepartment";
            this.idDepartmentDataGridViewTextBoxColumn.Name = "idDepartmentDataGridViewTextBoxColumn";
            // 
            // enrolleeGroupDataGridViewCheckBoxColumn
            // 
            this.enrolleeGroupDataGridViewCheckBoxColumn.DataPropertyName = "Enrollee Group";
            this.enrolleeGroupDataGridViewCheckBoxColumn.HeaderText = "Enrollee Group";
            this.enrolleeGroupDataGridViewCheckBoxColumn.Name = "enrolleeGroupDataGridViewCheckBoxColumn";
            // 
            // Department
            // 
            this.Department.Controls.Add(this.DGV_Department);
            this.Department.Location = new System.Drawing.Point(4, 34);
            this.Department.Name = "Department";
            this.Department.Padding = new System.Windows.Forms.Padding(3);
            this.Department.Size = new System.Drawing.Size(889, 430);
            this.Department.TabIndex = 5;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // DGV_Department
            // 
            this.DGV_Department.AutoGenerateColumns = false;
            this.DGV_Department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Department.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartmentDataGridViewTextBoxColumn1,
            this.departmentShortNameDataGridViewTextBoxColumn,
            this.departmentFullNameDataGridViewTextBoxColumn,
            this.idFacultyDataGridViewTextBoxColumn,
            this.groupQuantityDataGridViewTextBoxColumn});
            this.DGV_Department.DataSource = this.departmentBindingSource;
            this.DGV_Department.Location = new System.Drawing.Point(7, 7);
            this.DGV_Department.Name = "DGV_Department";
            this.DGV_Department.Size = new System.Drawing.Size(876, 417);
            this.DGV_Department.TabIndex = 0;
            // 
            // idDepartmentDataGridViewTextBoxColumn1
            // 
            this.idDepartmentDataGridViewTextBoxColumn1.DataPropertyName = "idDepartment";
            this.idDepartmentDataGridViewTextBoxColumn1.HeaderText = "idDepartment";
            this.idDepartmentDataGridViewTextBoxColumn1.Name = "idDepartmentDataGridViewTextBoxColumn1";
            // 
            // departmentShortNameDataGridViewTextBoxColumn
            // 
            this.departmentShortNameDataGridViewTextBoxColumn.DataPropertyName = "Department Short Name";
            this.departmentShortNameDataGridViewTextBoxColumn.HeaderText = "Department Short Name";
            this.departmentShortNameDataGridViewTextBoxColumn.Name = "departmentShortNameDataGridViewTextBoxColumn";
            // 
            // departmentFullNameDataGridViewTextBoxColumn
            // 
            this.departmentFullNameDataGridViewTextBoxColumn.DataPropertyName = "Department full Name";
            this.departmentFullNameDataGridViewTextBoxColumn.HeaderText = "Department full Name";
            this.departmentFullNameDataGridViewTextBoxColumn.Name = "departmentFullNameDataGridViewTextBoxColumn";
            // 
            // idFacultyDataGridViewTextBoxColumn
            // 
            this.idFacultyDataGridViewTextBoxColumn.DataPropertyName = "idFaculty";
            this.idFacultyDataGridViewTextBoxColumn.HeaderText = "idFaculty";
            this.idFacultyDataGridViewTextBoxColumn.Name = "idFacultyDataGridViewTextBoxColumn";
            // 
            // groupQuantityDataGridViewTextBoxColumn
            // 
            this.groupQuantityDataGridViewTextBoxColumn.DataPropertyName = "Group Quantity";
            this.groupQuantityDataGridViewTextBoxColumn.HeaderText = "Group Quantity";
            this.groupQuantityDataGridViewTextBoxColumn.Name = "groupQuantityDataGridViewTextBoxColumn";
            // 
            // Faculty
            // 
            this.Faculty.Controls.Add(this.DGV_Faculty);
            this.Faculty.Location = new System.Drawing.Point(4, 34);
            this.Faculty.Name = "Faculty";
            this.Faculty.Padding = new System.Windows.Forms.Padding(3);
            this.Faculty.Size = new System.Drawing.Size(889, 430);
            this.Faculty.TabIndex = 6;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // DGV_Faculty
            // 
            this.DGV_Faculty.AutoGenerateColumns = false;
            this.DGV_Faculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Faculty.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Faculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacultyDataGridViewTextBoxColumn1,
            this.facultyShortNameDataGridViewTextBoxColumn,
            this.facultyFullNameDataGridViewTextBoxColumn,
            this.idUniversityDataGridViewTextBoxColumn,
            this.departmentQuantityDataGridViewTextBoxColumn});
            this.DGV_Faculty.DataSource = this.facultyBindingSource;
            this.DGV_Faculty.Location = new System.Drawing.Point(7, 7);
            this.DGV_Faculty.Name = "DGV_Faculty";
            this.DGV_Faculty.Size = new System.Drawing.Size(876, 417);
            this.DGV_Faculty.TabIndex = 0;
            // 
            // idFacultyDataGridViewTextBoxColumn1
            // 
            this.idFacultyDataGridViewTextBoxColumn1.DataPropertyName = "idFaculty";
            this.idFacultyDataGridViewTextBoxColumn1.HeaderText = "idFaculty";
            this.idFacultyDataGridViewTextBoxColumn1.Name = "idFacultyDataGridViewTextBoxColumn1";
            // 
            // facultyShortNameDataGridViewTextBoxColumn
            // 
            this.facultyShortNameDataGridViewTextBoxColumn.DataPropertyName = "Faculty Short Name";
            this.facultyShortNameDataGridViewTextBoxColumn.HeaderText = "Faculty Short Name";
            this.facultyShortNameDataGridViewTextBoxColumn.Name = "facultyShortNameDataGridViewTextBoxColumn";
            // 
            // facultyFullNameDataGridViewTextBoxColumn
            // 
            this.facultyFullNameDataGridViewTextBoxColumn.DataPropertyName = "Faculty Full Name";
            this.facultyFullNameDataGridViewTextBoxColumn.HeaderText = "Faculty Full Name";
            this.facultyFullNameDataGridViewTextBoxColumn.Name = "facultyFullNameDataGridViewTextBoxColumn";
            // 
            // idUniversityDataGridViewTextBoxColumn
            // 
            this.idUniversityDataGridViewTextBoxColumn.DataPropertyName = "idUniversity";
            this.idUniversityDataGridViewTextBoxColumn.HeaderText = "idUniversity";
            this.idUniversityDataGridViewTextBoxColumn.Name = "idUniversityDataGridViewTextBoxColumn";
            // 
            // departmentQuantityDataGridViewTextBoxColumn
            // 
            this.departmentQuantityDataGridViewTextBoxColumn.DataPropertyName = "Department Quantity";
            this.departmentQuantityDataGridViewTextBoxColumn.HeaderText = "Department Quantity";
            this.departmentQuantityDataGridViewTextBoxColumn.Name = "departmentQuantityDataGridViewTextBoxColumn";
            // 
            // University
            // 
            this.University.Controls.Add(this.DGV_University);
            this.University.Location = new System.Drawing.Point(4, 34);
            this.University.Name = "University";
            this.University.Padding = new System.Windows.Forms.Padding(3);
            this.University.Size = new System.Drawing.Size(889, 430);
            this.University.TabIndex = 7;
            this.University.Text = "University";
            this.University.UseVisualStyleBackColor = true;
            // 
            // DGV_University
            // 
            this.DGV_University.AutoGenerateColumns = false;
            this.DGV_University.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_University.BackgroundColor = System.Drawing.Color.White;
            this.DGV_University.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_University.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUniversityDataGridViewTextBoxColumn1,
            this.universityShortNameDataGridViewTextBoxColumn,
            this.universityFullNameDataGridViewTextBoxColumn,
            this.idCityDataGridViewTextBoxColumn,
            this.facultyQuantityDataGridViewTextBoxColumn});
            this.DGV_University.DataSource = this.universityBindingSource;
            this.DGV_University.Location = new System.Drawing.Point(7, 7);
            this.DGV_University.Name = "DGV_University";
            this.DGV_University.Size = new System.Drawing.Size(876, 417);
            this.DGV_University.TabIndex = 0;
            // 
            // idUniversityDataGridViewTextBoxColumn1
            // 
            this.idUniversityDataGridViewTextBoxColumn1.DataPropertyName = "idUniversity";
            this.idUniversityDataGridViewTextBoxColumn1.HeaderText = "idUniversity";
            this.idUniversityDataGridViewTextBoxColumn1.Name = "idUniversityDataGridViewTextBoxColumn1";
            // 
            // universityShortNameDataGridViewTextBoxColumn
            // 
            this.universityShortNameDataGridViewTextBoxColumn.DataPropertyName = "University Short Name";
            this.universityShortNameDataGridViewTextBoxColumn.HeaderText = "University Short Name";
            this.universityShortNameDataGridViewTextBoxColumn.Name = "universityShortNameDataGridViewTextBoxColumn";
            // 
            // universityFullNameDataGridViewTextBoxColumn
            // 
            this.universityFullNameDataGridViewTextBoxColumn.DataPropertyName = "University Full Name";
            this.universityFullNameDataGridViewTextBoxColumn.HeaderText = "University Full Name";
            this.universityFullNameDataGridViewTextBoxColumn.Name = "universityFullNameDataGridViewTextBoxColumn";
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            this.idCityDataGridViewTextBoxColumn.DataPropertyName = "idCity";
            this.idCityDataGridViewTextBoxColumn.HeaderText = "idCity";
            this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            // 
            // facultyQuantityDataGridViewTextBoxColumn
            // 
            this.facultyQuantityDataGridViewTextBoxColumn.DataPropertyName = "Faculty Quantity";
            this.facultyQuantityDataGridViewTextBoxColumn.HeaderText = "Faculty Quantity";
            this.facultyQuantityDataGridViewTextBoxColumn.Name = "facultyQuantityDataGridViewTextBoxColumn";
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataMember = "University";
            this.universityBindingSource.DataSource = this.DBlanguageCoursesSource;
            // 
            // City
            // 
            this.City.Controls.Add(this.DGV_City);
            this.City.Location = new System.Drawing.Point(4, 34);
            this.City.Name = "City";
            this.City.Padding = new System.Windows.Forms.Padding(3);
            this.City.Size = new System.Drawing.Size(889, 430);
            this.City.TabIndex = 8;
            this.City.Text = "City";
            this.City.UseVisualStyleBackColor = true;
            // 
            // DGV_City
            // 
            this.DGV_City.AutoGenerateColumns = false;
            this.DGV_City.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_City.BackgroundColor = System.Drawing.Color.White;
            this.DGV_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_City.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCityDataGridViewTextBoxColumn1,
            this.cityNameDataGridViewTextBoxColumn,
            this.idCountryDataGridViewTextBoxColumn2,
            this.universityQuantityDataGridViewTextBoxColumn,
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn});
            this.DGV_City.DataSource = this.cityBindingSource;
            this.DGV_City.Location = new System.Drawing.Point(7, 7);
            this.DGV_City.Name = "DGV_City";
            this.DGV_City.Size = new System.Drawing.Size(876, 417);
            this.DGV_City.TabIndex = 0;
            // 
            // idCityDataGridViewTextBoxColumn1
            // 
            this.idCityDataGridViewTextBoxColumn1.DataPropertyName = "idCity";
            this.idCityDataGridViewTextBoxColumn1.HeaderText = "idCity";
            this.idCityDataGridViewTextBoxColumn1.Name = "idCityDataGridViewTextBoxColumn1";
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "City Name";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "City Name";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // idCountryDataGridViewTextBoxColumn2
            // 
            this.idCountryDataGridViewTextBoxColumn2.DataPropertyName = "idCountry";
            this.idCountryDataGridViewTextBoxColumn2.HeaderText = "idCountry";
            this.idCountryDataGridViewTextBoxColumn2.Name = "idCountryDataGridViewTextBoxColumn2";
            // 
            // universityQuantityDataGridViewTextBoxColumn
            // 
            this.universityQuantityDataGridViewTextBoxColumn.DataPropertyName = "University Quantity";
            this.universityQuantityDataGridViewTextBoxColumn.HeaderText = "University Quantity";
            this.universityQuantityDataGridViewTextBoxColumn.Name = "universityQuantityDataGridViewTextBoxColumn";
            // 
            // localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn
            // 
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.DataPropertyName = "Local Percent of Knowledge of Second Lang";
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.HeaderText = "Local Percent of Knowledge of Second Lang";
            this.localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.Name = "localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn";
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.White;
            this.Country.Controls.Add(this.DGV_Country);
            this.Country.Location = new System.Drawing.Point(4, 34);
            this.Country.Name = "Country";
            this.Country.Padding = new System.Windows.Forms.Padding(3);
            this.Country.Size = new System.Drawing.Size(889, 430);
            this.Country.TabIndex = 9;
            this.Country.Text = "Country";
            // 
            // DGV_Country
            // 
            this.DGV_Country.AutoGenerateColumns = false;
            this.DGV_Country.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Country.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Country.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCountryDataGridViewTextBoxColumn3,
            this.countryNameDataGridViewTextBoxColumn,
            this.idNativeLangDataGridViewTextBoxColumn,
            this.cityQuantityDataGridViewTextBoxColumn,
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn});
            this.DGV_Country.DataSource = this.countryBindingSource;
            this.DGV_Country.Location = new System.Drawing.Point(7, 7);
            this.DGV_Country.Name = "DGV_Country";
            this.DGV_Country.Size = new System.Drawing.Size(876, 417);
            this.DGV_Country.TabIndex = 0;
            // 
            // idCountryDataGridViewTextBoxColumn3
            // 
            this.idCountryDataGridViewTextBoxColumn3.DataPropertyName = "idCountry";
            this.idCountryDataGridViewTextBoxColumn3.HeaderText = "idCountry";
            this.idCountryDataGridViewTextBoxColumn3.Name = "idCountryDataGridViewTextBoxColumn3";
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "Country Name";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Country Name";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // idNativeLangDataGridViewTextBoxColumn
            // 
            this.idNativeLangDataGridViewTextBoxColumn.DataPropertyName = "idNativeLang";
            this.idNativeLangDataGridViewTextBoxColumn.HeaderText = "idNativeLang";
            this.idNativeLangDataGridViewTextBoxColumn.Name = "idNativeLangDataGridViewTextBoxColumn";
            // 
            // cityQuantityDataGridViewTextBoxColumn
            // 
            this.cityQuantityDataGridViewTextBoxColumn.DataPropertyName = "City Quantity";
            this.cityQuantityDataGridViewTextBoxColumn.HeaderText = "City Quantity";
            this.cityQuantityDataGridViewTextBoxColumn.Name = "cityQuantityDataGridViewTextBoxColumn";
            // 
            // overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn
            // 
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.DataPropertyName = "Overall Percent of Knowledge of Second Lang";
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.HeaderText = "Overall Percent of Knowledge of Second Lang";
            this.overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn.Name = "overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.languageCoursesDataSetForCustomScriptingBindingSource;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // LanguageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 627);
            this.Controls.Add(this.TC_MainOperations);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "LanguageCoursesForm";
            this.Text = "Language Courses";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBlanguageCoursesSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBlanguageCoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.TC_MainOperations.ResumeLayout(false);
            this.TB_ViewData.ResumeLayout(false);
            this.TC_ViewData.ResumeLayout(false);
            this.TP_Courses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCoursesDataSetForCustomScriptingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCoursesDataSetForCustomScripting)).EndInit();
            this.TP_Teachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            this.TP_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.TP_Groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            this.TP_Cities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VD_Cities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            this.TB_ChangeData.ResumeLayout(false);
            this.TC_DatabaseTableChange.ResumeLayout(false);
            this.Course.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Course)).EndInit();
            this.Language.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Language)).EndInit();
            this.Teacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Teacher)).EndInit();
            this.Student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Student)).EndInit();
            this.Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Group)).EndInit();
            this.Department.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Department)).EndInit();
            this.Faculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Faculty)).EndInit();
            this.University.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_University)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.City.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_City)).EndInit();
            this.Country.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private LanguageCoursesDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private LanguageCoursesDataSet1TableAdapters.FacultyTableAdapter facultyTableAdapter;
        private LanguageCoursesDataSet1TableAdapters.UniversityTableAdapter universityTableAdapter;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private LanguageCoursesDataSet1TableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private LanguageCoursesDataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.BindingSource DBlanguageCoursesSource;
        public LanguageCoursesDataSet1 DBlanguageCoursesDataSet;
        public System.Windows.Forms.BindingSource courseBindingSource;
        public LanguageCoursesDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        public LanguageCoursesDataSet1TableAdapters.LanguageTableAdapter languageTableAdapter;
        public LanguageCoursesDataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        public LanguageCoursesDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        public LanguageCoursesDataSet1TableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.TabControl TC_MainOperations;
        private System.Windows.Forms.TabPage TB_ViewData;
        private System.Windows.Forms.TabPage TB_ChangeData;
        private System.Windows.Forms.Button B_RefreshData;
        private System.Windows.Forms.Button B_RejectChanges;
        private System.Windows.Forms.Button B_CommitChanges;
        private System.Windows.Forms.TabControl TC_DatabaseTableChange;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.DataGridView DGV_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Language;
        private System.Windows.Forms.DataGridView DGV_Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageFamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevalenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageWritingFamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Teacher;
        private System.Windows.Forms.DataGridView DGV_Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLangDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Student;
        private System.Windows.Forms.DataGridView DGV_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnrolleeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage Group;
        private System.Windows.Forms.DataGridView DGV_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enrolleeGroupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage Department;
        private System.Windows.Forms.DataGridView DGV_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Faculty;
        private System.Windows.Forms.DataGridView DGV_Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage University;
        private System.Windows.Forms.DataGridView DGV_University;
        private System.Windows.Forms.TabPage City;
        private System.Windows.Forms.DataGridView DGV_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Country;
        private System.Windows.Forms.DataGridView DGV_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNativeLangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl TC_ViewData;
        private System.Windows.Forms.TabPage TP_Courses;
        private System.Windows.Forms.DataGridView DGV_VD_Courses;
        private System.Windows.Forms.TabPage TP_Teachers;
        private System.Windows.Forms.DataGridView DGV_VD_Teachers;
        private System.Windows.Forms.TabPage TP_Students;
        private System.Windows.Forms.DataGridView DGV_VD_Students;
        private System.Windows.Forms.TabPage TP_Groups;
        private System.Windows.Forms.DataGridView DGV_VD_Groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUniversityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource universityBindingSource;
        private LanguageCoursesDataSetForCustomScripting languageCoursesDataSetForCustomScripting;
        private System.Windows.Forms.BindingSource languageCoursesDataSetForCustomScriptingBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private LanguageCoursesDataSetForCustomScriptingTableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audienceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private LanguageCoursesDataSetForCustomScriptingTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private LanguageCoursesDataSetForCustomScriptingTableAdapters.TeacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private LanguageCoursesDataSetForCustomScriptingTableAdapters.GroupTableAdapter groupTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enrolleeGroupDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnrolleeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage TP_Cities;
        private System.Windows.Forms.DataGridView DGV_VD_Cities;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private LanguageCoursesDataSetForCustomScriptingTableAdapters.CityTableAdapter cityTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallPercentOfKnowledgeOfSecondLangDataGridViewTextBoxColumn1;
    }
}

