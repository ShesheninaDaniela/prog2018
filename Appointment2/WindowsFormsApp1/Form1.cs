using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment ;
using ЗаписьНаПрием;

namespace Appointment 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //получить модель заказа на основании введенных данных
        AppointmentToTheDentist GetModelFromUI()
        {
            return new AppointmentToTheDentist()
            {
                FilledTime = dateTimePicker2.Value,
                
                Person = new PersonalData
                {
                    LastName= textBox1.Text,
                    FirstName = textBox3.Text,
                    Patronymic = textBox2.Text,
                    DateBirth = dateTimePicker3.Value,
                    Document= textBox6.Text,
                    Series= maskedTextBox1.Text,
                    Number= maskedTextBox2.Text,
                },
                                          
                Admission = new AdmissionDate
                {
                    Admission = dateTimePicker1.Value,
                },
                Service = checkedListBox1.Items.OfType<ChoiceOfService>().ToList(),
            };
        }
        //загрузить данные по заказу на форму
        private void SetModelToUI(AppointmentToTheDentist ord)
        {
            dateTimePicker2.Value = ord.FilledTime;
            textBox1.Text = ord.Person.LastName;
            textBox3.Text = ord.Person.FirstName;
            textBox2.Text = ord.Person.Patronymic;
            dateTimePicker3.Value = ord.Person.DateBirth;
            textBox6.Text = ord.Person.Document;
            maskedTextBox1.Text = ord.Person.Series;
            maskedTextBox2.Text = ord.Person.Number;
            dateTimePicker1.Value = ord.Admission.Admission;
            checkedListBox1.Items.OfType<ChoiceOfService>().ToList();
            foreach (var e in ord.Service)
            {
                checkedListBox1.Items.Add(e);
            }
        }
        //сохранить в файл
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd= new SaveFileDialog() { Filter = "Файлы заявок|*.txt" };
                var result = sfd.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var dto = GetModelFromUI();
                    OrderHelper.WriteToFile(sfd.FileName, dto);
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность заполнения данных", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
        //загрузить из файла
        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заявки|*.txt" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = OrderHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }
    }
}
