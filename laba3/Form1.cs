using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            fPerson ft = new fPerson(person);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPersonInfo.Text += string.Format(
                    "Повне ім'я: {0} {1}. Стать: {2}, вік: {3}. Зріст: {4} м, вага: {5} кг. [{6} | {7}] | ІМТ: {8:0.000}\r\n",
                    person.FirstName, person.LastName, person.Gender, person.Age, person.Height, person.Weight,
                    person.HasAuto ? "Є автомобіль" : "Немає автомобіля",
                    person.HasBike ? "Є велосипед" : "Немає велосипеда",
                    person.CalculateBMI());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
