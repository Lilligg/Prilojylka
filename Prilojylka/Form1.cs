namespace Prilojylka
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            string trueLog = "admin";
            string truePass = "admin";

            string login = textLogin.Text;
            string password = textPassword.Text;

            if (trueLog == login && truePass == password) 
            {               
                Form2 form2 = new Form2();          
                form2.Show();
                this.Hide();
            }
            else if (login == "" | password == "")
            { MessageBox.Show("Заполните все обязательные поля"); }
            else
            { MessageBox.Show("Логин или пароль не верный"); }
            
        }
    }
}