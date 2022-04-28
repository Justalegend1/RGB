using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    public partial class MoyLichniyTextBox : TextBox
    {
        public MoyLichniyTextBox()
        {
            InitializeComponent();
        }

        public MoyLichniyTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
                if (Checked == true)
                    if (Text != "")
                    {
                        try
                        {
                            int s = Convert.ToInt32(Text);
                            s = Convert.ToInt32(Text);
                            if (s < 0 || s > 255)
                            {
                                MessageBox.Show("Дядя, ну ты шо, надо вводить числа из диапазона [0;255]", "Глупый");
                                Text = "0";
                            }
                            else {  }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
                            Text = "0"; 
                        }
                    }
                    else
                    { }
                else
                    if (Text != "")
                {
                    try
                    {
                        int s = Convert.ToInt32(Text, 16);
                        s = Convert.ToInt32(s);
                        if (s < 0 || s > 255)
                        {
                            MessageBox.Show("Дядя, ну ты шо, надо вводить числа из диапазона [0;255]", "Глупый");
                            Text = "0";
                        }
                        else { }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели число не из шестнадцатиричной системы! Пожалуйста,исправьте то, что наделали");
                        Text = "0";
                    }
                }
            base.OnTextChanged(e);
        }

        int value { get; set; }
        public static bool Checked {get; set;}
    }
}
