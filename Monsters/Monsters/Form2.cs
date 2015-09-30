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
using System.Xml;
using System.Xml.Linq;


namespace Monsters
{
    public partial class Form2 : Form
    {
        public BindingList<Beast> monstersFamily;

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

            comboBox1.DataSource = Enum.GetValues(typeof(TypeOfBeast));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }      

        private void Add_Click(object sender, EventArgs e)
        {
            
            //a lot of exceptions here, you need to check inputed value before cast it. Int32.TryParce method may help you

            int number = 0;
            Int32.TryParse(textBox1.Text, out number);
            
            double speed = 0;
            Double.TryParse(textBox3.Text, out speed);            

            int bittenpeople = 0;
            Int32.TryParse(textBox7.Text, out bittenpeople);

            TypeOfBeast type;
            Enum.TryParse<TypeOfBeast>(comboBox1.SelectedValue.ToString(), out type);

            MonstersTable addForm = this.Owner as MonstersTable;
            if (addForm != null)
            {                    

                addForm.TableDataSourceList.Add(new Beast()
                {
                    Number = number,
                    Name = textBox2.Text,
                    Speed = speed,
                    CityLocation = textBox6.Text,
                    CountryLocation = textBox4.Text,
                    BittenPeople = bittenpeople,
                    BeastType = type
                });  
            }


            XDocument xDoc = XDocument.Load("DataBeastsProject.xml");

            XElement elem = new XElement("Beast",
                                                new XElement("Number", textBox1.Text),
                                                new XElement("Name", textBox2.Text),
                                                new XElement("Speed", (textBox3.Text),
                                                new XElement("CountryLocation", textBox4.Text),
                                                new XElement("CityLocation", textBox6.Text),
                                                new XElement("BeastType", comboBox1.SelectedValue),
                                                new XElement("BittenPeople", textBox7.Text)
                                                ));

            xDoc.Element("MonstersFamily").Add(elem);
            xDoc.Save("DataBeastsProject.xml");

            Close();
        }
        
    }
}