namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length <= 0) return;
            bool isRight = Double.TryParse(txt.Text, out _);
            if (!isRight)
            {
                MessageBox.Show("dato no valido");
                string res = "";
                for(int i = 0; i < txt.Text.Length; i++)
                {
                    if (txt.Text[i] >'0' && txt.Text[i]<='9')
                    {
                        res += txt.Text[i];
                    }
                }
                txt.Text = res;
            }
            // char last = txt.Text[txt.Text.Length - 1];
            /*if (!(last >= '0' && last <= '9'))
            {
                MessageBox.Show("Dato no valido");
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            }*/
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = false;
            }
        }
    }
}