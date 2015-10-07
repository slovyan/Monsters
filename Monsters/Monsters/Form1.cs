using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monsters.Helpers;
using Monsters.Models;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Monsters
{
    public partial class MonstersTable : Form
    {
        List<Beast> monstersFamily; //monstersFamily or _monstarsFamily please pay attention. Property, Method, field (_field), CONSTANT, etc...
        public List<Beast> MonstersFamily { get { return monstersFamily; } set { monstersFamily = value; } }


        BindingList<Beast> tableDataSourceList;
        public BindingList<Beast> TableDataSourceList
        {
            get
            {
                return tableDataSourceList;
            }
            set
            {
                tableDataSourceList = value;
                dataGridView1.DataSource = value;
                countListItems.Text = tableDataSourceList.Count.ToString();
            }
        }

        Form2 addItemForm = new Form2();

        public MonstersTable()
        {
            InitializeComponent();
            monstersFamily = new List<Beast>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var beasts = from c in XElement.Load("DataBeastsProject.xml").Elements("Beast")
                        select c;
            

            foreach (var item in beasts)
            {
                int number = 0;
                Int32.TryParse(item.Element("Number").Value, out number);

                double speed = 0;
                Double.TryParse(item.Element("Speed").Value, out speed);

                int bittenpeople = 0;
                Int32.TryParse(item.Element("BittenPeople").Value, out bittenpeople);

                TypeOfBeast type;
                Enum.TryParse<TypeOfBeast>(item.Element("BeastType").Value, out type);

                monstersFamily.Add(new Beast()
                {
                    Number = number,
                    Name = item.Element("Name").Value,
                    Speed = speed,
                    CountryLocation = item.Element("CountryLocation").Value,
                    CityLocation = item.Element("CityLocation").Value,
                    BeastType = type,
                    BittenPeople = bittenpeople});
            };

            TableDataSourceList = new BindingList<Beast>(monstersFamily);
            TableDataSourceList.ListChanged += TableDataSourceList_ListChanged;
            dataGridView1.DataSource = TableDataSourceList;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.AllowUserToAddRows = false;
            countListItems.Text = dataGridView1.Rows.Count.ToString();
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.RowsRemoved += dataGridView1_RowsRemoved;            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataGridView1.ReadOnly = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.BeginEdit(false);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableDataSourceList.RemoveAt(dataGridView1.CurrentRow.Index);

            XDocument xDoc = XDocument.Load("DataBeastsProject.xml");

            Beast listItem = TableDataSourceList.ElementAt(dataGridView1.CurrentRow.Index);

            string numberList = listItem.Number.ToString();

            xDoc.Descendants("Number").Where(q => q.Value == numberList).Single().Parent.PreviousNode.Remove();
            
            xDoc.Save(@"..\..\DataBeastsProject.xml");

        }


        private void AddItem_Click(object sender, EventArgs e)
        {
            Form2 addItemForm = new Form2();
            addItemForm.Owner = this;
            addItemForm.ShowDialog();
            
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                TableDataSourceList = monstersFamily.OrderBy(monsters => monsters.Name).ToBindingList();
            }
            else if (e.ColumnIndex == 2)
            {
                TableDataSourceList = monstersFamily.OrderBy(monsters => monsters.Speed).ToBindingList();
            }
            else if (e.ColumnIndex == 6)
            {
                TableDataSourceList = monstersFamily.OrderBy(monsters => monsters.BittenPeople).ToBindingList();
            }

        }

        private void chooseZombie_Click(object sender, EventArgs e)
        {
            TableDataSourceList = monstersFamily.Where(monsters => monsters.BeastType == TypeOfBeast.Zombie).ToBindingList();

           // countListItems.Text = dataGridView1.Rows.Count.ToString();
        }

        private void strongBeasts_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            TableDataSourceList = monstersFamily.Where(strongMonsters => strongMonsters.BittenPeople > 15)
                                                     .OrderBy(strongMonsters => rand.Next())
                                                     .Take(2)
                                                     .ToBindingList();

            //countListItems.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.ClearSelection();
            countListItems.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dataGridView1.ClearSelection();
            countListItems.Text = dataGridView1.Rows.Count.ToString();
        }
        private void TableDataSourceList_ListChanged(object sender, ListChangedEventArgs e)
        {
            countListItems.Text = tableDataSourceList.Count.ToString();
        }
    }
}
