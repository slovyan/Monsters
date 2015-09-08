using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monsters.Models;


namespace Monsters
{
    public partial class Form2 : Form
    {
        BindingList<Beast> monstersFamily;

        public Form2()
        {
            InitializeComponent();            
            //monstersFamily = new BindingList<Beast>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //not a good idea
            //comboBox1.Items.Add(new Zombie());
            //comboBox1.Items.Add(new Vampire());

            comboBox1.Items.Add("Zombie");
            comboBox1.Items.Add("Vampire");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }      

        private void Add_Click(object sender, EventArgs e)
        {

            //a lot of exceptions here, you need to check inputed value before cast it. Int32.TryParce method may help you
            monstersFamily.Add(new Beast()
            {
                Number = Convert.ToInt32(textBox1.Text),
                Name = textBox2.Text,
                Speed = Convert.ToDouble(textBox3.Text),
                CityLocation = textBox6.Text,
                CountryLocation = textBox4.Text,
                BittenPeople = Convert.ToInt32(textBox7.Text)
            });
        }
        
    }
}