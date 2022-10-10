namespace PomodoroProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PomoTask pomoTask = new PomoTask() { Id = 1, Title = "Learn Git" };
            TaskForm taskForm = new TaskForm(pomoTask);
            taskForm.ShowDialog();
        }
    }
}