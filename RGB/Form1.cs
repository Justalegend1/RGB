using System.Drawing;
namespace RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void pictureBox1_Color()
        {
            if ((moyLichniyTextBox1.Text == "") || (moyLichniyTextBox2.Text == "") || (moyLichniyTextBox3.Text == ""))
            {
                MessageBox.Show("���� ��������� ��� ����, ��� � ���� �� ������ ����� ���� �������?");
            }
            else
            {
                int R = Convert.ToInt32(moyLichniyTextBox1.Text,16);
                int G = Convert.ToInt32(moyLichniyTextBox2.Text, 16);
                int B = Convert.ToInt32(moyLichniyTextBox3.Text, 16);
                pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                if (textBox1.Text != "")
                {
                    try
                    {
                        int s = Convert.ToInt32(textBox1.Text);
                        s = Convert.ToInt32(textBox1.Text);
                        if (s < 0 || s > 255)
                        {
                            MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                            textBox1.Clear();
                        }
                        else
                        {
                            pictureBox1_Color();
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("�� ����� ������! ����������,������� ����y");
                        textBox1.Clear();
                    }
                }
                else
                { }
            else
                if (textBox1.Text != "")
            {
                try
                {
                    int s = Convert.ToInt32(textBox1.Text, 16);
                    s = Convert.ToInt32(textBox1.Text);
                    if (s < 0 || s > 255)
                    {
                        MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                        textBox1.Clear();
                    }
                    else { pictureBox1_Color(); }
                }
                catch
                {
                    MessageBox.Show("�� ����� ����� �� �� ����������������� �������! ����������,��������� ��, ��� ��������");
                    textBox1.Clear();
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                if (textBox2.Text != "")
                {
                    try
                    {
                        int s = Convert.ToInt32(textBox2.Text);
                        s = Convert.ToInt32(textBox2.Text);
                        if (s < 0 || s > 255)
                        {
                            MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                            textBox2.Clear();
                        }
                        else { pictureBox1_Color(); }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("�� ����� ������! ����������,������� ����y");
                        textBox2.Clear();
                    }
                }
                else
                { }
            else
                if (textBox2.Text != "")
                    {
                        try
                        {
                            int s = Convert.ToInt32(textBox2.Text, 16);
                            s = Convert.ToInt32(textBox2.Text);
                    if (s < 0 || s > 255)
                    {
                        MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                        textBox2.Clear();
                    }
                    else { pictureBox1_Color(); }
                        }
                        catch
                        {
                            MessageBox.Show("�� ����� ����� �� �� ����������������� �������! ����������,��������� ��, ��� ��������");
                            textBox2.Clear();
                        }
                    }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                if (textBox3.Text != "")
                {
                    try
                    {
                        int s = Convert.ToInt32(textBox3.Text);
                        s = Convert.ToInt32(textBox3.Text);
                        if (s < 0 || s > 255)
                        {
                            MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                            textBox3.Clear();
                        }
                        else { pictureBox1_Color(); }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("�� ����� ������! ����������,������� ����y");
                        textBox3.Clear();
                    }
                }
                else
                { }
            else
                if (textBox3.Text != "")
            {
                try
                {
                    int s = Convert.ToInt32(textBox3.Text, 16);
                    s = Convert.ToInt32(textBox3.Text);
                    if (s < 0 || s > 255)
                    {
                        MessageBox.Show("����, �� �� ��, ���� ������� ����� �� ��������� [0;255]", "������");
                        textBox3.Clear();
                    }
                    else { pictureBox1_Color(); }
                }
                catch
                {
                    MessageBox.Show("�� ����� ����� �� �� ����������������� �������! ����������,��������� ��, ��� ��������");
                    textBox3.Clear();
                }
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MoyLichniyTextBox.Checked = true;
            }
            else
            {
                MoyLichniyTextBox.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void moyLichniyTextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1_Color();
        }

        private void moyLichniyTextBox2_TextChanged(object sender, EventArgs e)
        {
            pictureBox1_Color();
        }

        private void moyLichniyTextBox3_TextChanged(object sender, EventArgs e)
        {
            pictureBox1_Color();
        }
    }
}