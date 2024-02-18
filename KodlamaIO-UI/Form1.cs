using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Entities.Concrete;

namespace KodlamaIO_UI
{
    public partial class Form1 : Form
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        CourseManager courseManager = new CourseManager(new CourseDal());
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());

        List<Course> courses;
        public Form1()
        {
            InitializeComponent();
            GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView1.ScrollBars = ScrollBars.None;

            GetData();
        }

        public void GetData()
        {
            courses = courseManager.GetAll();
            List<Category> categories = categoryManager.GetAll();
            List<Instructor> instructors = instructorManager.GetAll();


            var query = from course in courses
                        join category in categories on course.CategoryId equals category.Id
                        join instructor in instructors on course.InstructorId equals instructor.Id
                        select new
                        {
                            course.Id,
                            course.CourseName,
                            course.Description,
                            course.Price,
                            CategoryName = category.CategoryName,
                            InstructorName = instructor.FullName



                        };

            dataGridView1.DataSource = query.ToList();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";

            cbInstructor.DataSource = instructors;
            cbInstructor.DisplayMember = "FullName";
            cbInstructor.ValueMember = "Id";

        }



        private void btnCourses_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null)
            {
                int selectedCategoryId = ((Category)cbCategory.SelectedItem).Id;

                var query = from course in courses
                            join category in categoryManager.GetAll() on course.CategoryId equals category.Id
                            join instructor in instructorManager.GetAll() on course.InstructorId equals instructor.Id
                            where course.CategoryId == selectedCategoryId
                            select new
                            {
                                course.Id,
                                course.CourseName,
                                course.Description,
                                course.Price,
                                CategoryName = category.CategoryName,
                                InstructorName = instructor.FirstName + " " + instructor.LastName,
                            };

                dataGridView1.DataSource = query.ToList();
            }
            if (cbCategory.SelectedIndex != -1 && cbInstructor.Items.Count > cbCategory.SelectedIndex)
            {
                cbInstructor.SelectedIndex = cbCategory.SelectedIndex;
            }

        }

        private void cbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInstructor.SelectedItem != null)
            {
                int selectedInsturctorId = ((Instructor)cbInstructor.SelectedItem).Id;

                var query = from course in courses
                            join category in categoryManager.GetAll() on course.CategoryId equals category.Id
                            join instructor in instructorManager.GetAll() on course.InstructorId equals instructor.Id
                            where course.CategoryId == selectedInsturctorId
                            select new
                            {
                                course.Id,
                                course.CourseName,
                                course.Description,
                                course.Price,
                                CategoryName = category.CategoryName,
                                InstructorName = instructor.FirstName + " " + instructor.LastName,
                            };

                dataGridView1.DataSource = query.ToList();


            }
            if (cbInstructor.SelectedIndex != -1 && cbCategory.Items.Count > cbInstructor.SelectedIndex)
            {
                cbCategory.SelectedIndex = cbInstructor.SelectedIndex;
            }

        }
    }
}