namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] fio = new string[3];

        int year = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            fio = str.Split();



            DateTime dt = dateTimePicker1.Value;

            int dat = DateTime.Now.Year - dt.Year;

            //DateTime.Now.Year - текущая дата;
            //dt - выбранная пользователем дата


            StreamWriter sw = new StreamWriter("file.txt");
            sw.WriteLine(fio[0]);
            sw.WriteLine(fio[1]);
            sw.WriteLine(fio[2]);
            sw.Close();

            StreamReader sr = new StreamReader("file.txt");
            str = sr.ReadToEnd();
            sr.Close();


            MessageBox.Show(str + dat);
        }

    }
}