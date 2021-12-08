using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brigadires
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                if ((textBox1.Text == "") || (textBox2.Text == "")) MessageBox.Show("Заполните поля");
                else
                {
                    Autorizetion userObj = db.Autorizetions.FirstOrDefault(user => user.EMail.Equals(textBox1.Text) && user.Password_user.Equals(textBox2.Text));
                    if (userObj != null)
                    {
                        switch (Convert.ToInt32(userObj.Status_auto))
                        {

                            case 0:
                                {
                                    MessageBox.Show("Вы вошли как Админ");
                                    /* Form1 f;
                                     f = new Form1();
                                     f.Show();
                                     this.Hide();*/
                                    break;
                                }
                            case 1:
                                {
                                    MessageBox.Show("Вы вошли как Пользователь");
                                    /*Form4 form3;
                                    form3 = new Form4();
                                    form3.Show();*/
                                    break;
                                }
                            case 2:
                                {
                                    MessageBox.Show("Вы вошли как Сотрудник");
                                    /*Form3 form4;
                                    form4 = new Form3();
                                    form4.Show();*/
                                    break;
                                }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неверный логин/пароль");
                        return;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
            label4.Text = "Дата: " + DateTime.Now.ToString("MM/dd/yy");
        }
    }
}
