﻿using System;
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
    public partial class MonstersTable : Form
    {
        public BindingList<Beast> monstersFamily; //monstersFamily or _monstarsFamily please pay attention. Property, Method, field (_field), CONSTANT, etc...

        Form2 addItemForm = new Form2();
        
        public MonstersTable()
        {
            InitializeComponent();
            monstersFamily = new BindingList<Beast>();
            monstersFamily.ListChanged += monstersFamily_ListChanged;
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            monstersFamily.Add(new Zombie()
            {
                Number = 1,
                Name = "Atomic",
                Speed = 100,
                CityLocation = "Kiev",
                CountryLocation = "Ukraine",
                BittenPeople = 0
            });

            monstersFamily.Add(new Zombie()
            {
                Number = 2,
                Name = "King",
                Speed = 120,
                CityLocation = "London",
                CountryLocation = "England",
                BittenPeople = 55
            });

            monstersFamily.Add(new Zombie()
            {
                Number = 3,
                Name = "Shadow",
                Speed = 80,
                CityLocation = "Tokio",
                CountryLocation = "Japan",
                BittenPeople = 12
            });

            monstersFamily.Add(new Zombie()
            {
                Number = 4,
                Name = "Giant",
                Speed = 150,
                CityLocation = "Sydney ",
                CountryLocation = "Australia",
                BittenPeople = 80
            });

            monstersFamily.Add(new Zombie()
            {
                Number = 5,
                Name = "Master",
                Speed = 200,
                CityLocation = "NewYork",
                CountryLocation = "USA",
                BittenPeople = 20
            });

            monstersFamily.Add(new Vampire()
            {
                Number = 6,
                Name = "Demon",
                Speed = 300,
                CityLocation = "Moscow",
                CountryLocation = "Russia",
                BittenPeople = 10
            });

            monstersFamily.Add(new Vampire()
            {
                Number = 7,
                Name = "Harlot",
                Speed = 420,
                CityLocation = "CapeTown",
                CountryLocation = "Africa",
                BittenPeople = 0
            });

            monstersFamily.Add(new Vampire()
            {
                Number = 8,
                Name = "Concubine",
                Speed = 280,
                CityLocation = "BuenosAires",
                CountryLocation = "Argentina",
                BittenPeople = 38
            });

            monstersFamily.Add(new Vampire()
            {
                Number = 9,
                Name = "Tramp",
                Speed = 550,
                CityLocation = "Pekin",
                CountryLocation = "China",
                BittenPeople = 95
            });

            monstersFamily.Add(new Vampire()
            {
                Number = 10,
                Name = "Vixen",
                Speed = 600,
                CityLocation = "Habana",
                CountryLocation = "Cuba",
                BittenPeople = 2
            });

            dataGridView1.DataSource = monstersFamily;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
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
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
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
                dataGridView1.DataSource = monstersFamily.OrderBy(monsters => monsters.Name).ToList(); 
            }
            else if (e.ColumnIndex == 2)
            {
                dataGridView1.DataSource = monstersFamily.OrderBy(monsters => monsters.Speed).ToList();
            }
            else if(e.ColumnIndex == 6)
            {
                 dataGridView1.DataSource = monstersFamily.OrderBy(monsters => monsters.BittenPeople).ToList();
            }
              
        }

        private void chooseZombie_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = monstersFamily.Where(monsters => monsters.BeastType == TypeOfBeast.Zombie)
                                                     .ToList();
        }

        private void strongBeasts_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            dataGridView1.DataSource = monstersFamily.Where(strongMonsters => strongMonsters.BittenPeople > 15)
                                                     .OrderBy(strongMonsters => rand.Next())
                                                     .Take(2)
                                                     .ToList();
        }

        void monstersFamily_ListChanged(object sender, ListChangedEventArgs e)
        {
            countListItems.Text = String.Format("{0} items", monstersFamily.Count);
        }
    }
}
