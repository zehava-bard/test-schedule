using Newtonsoft.Json;

namespace test
{
    public partial class myProject : Form
    {
        HomePage h;
        string filePathT;
        public myProject()
        {
            InitializeComponent();
        }
        public myProject(HomePage h)
        {
            filePathT = "Test.json";
            this.h = h;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filePathT = "Test.json";
            if (!File.Exists(filePathT))
            {
                MessageBox.Show("Error! there is no file in this path");
                return;
            }
            ListTest lt = new ListTest(this);
            this.Hide();
            lt.Show();
        }

        private void button2_Click(object sender, EventArgs e)//יצירת מבחן חדש
        {
            createNewTest cnt = new createNewTest(this);
            cnt.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           // h.Show();
        }
    }
}