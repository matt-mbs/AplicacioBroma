using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cancel_Btn_MouseHover(object sender, EventArgs e)
        {

            Random random = new Random();

            int x = random.Next(1, 200);
            int y = random.Next(1, 200);

            cancel_Btn.Location = new Point(x, y);
        }

        private void accept_Btn_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje();

            mensaje.Show();
        }
    }
}
