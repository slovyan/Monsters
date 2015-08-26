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
        List<Beast> MonstersFamily;

        public MonstersTable()
        {
            InitializeComponent();
            MonstersFamily = new List<Beast>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MonstersFamily.Add(new Zombie()
            {
                Number = 1,
                Name = "Atomic",
                Speed = 100,
                CityLocation = "Kiev",
                CountryLocation = "Ukraine",
                EatenPeople = 0,
                Zomb = "Zombie"
            });

            MonstersFamily.Add(new Zombie()
            {
                Number = 2,
                Name = "King",
                Speed = 120,
                CityLocation = "London",
                CountryLocation = "England",
                EatenPeople = 55,
                Zomb = "Zombie"
            });

            MonstersFamily.Add(new Zombie()
            {
                Number = 3,
                Name = "Shadow",
                Speed = 80,
                CityLocation = "Tokio",
                CountryLocation = "Japan",
                EatenPeople = 12,
                Zomb = "Zombie"
            });

            MonstersFamily.Add(new Zombie()
            {
                Number = 4,
                Name = "Giant",
                Speed = 150,
                CityLocation = "Sydney ",
                CountryLocation = "Australia",
                EatenPeople = 80,
                Zomb = "Zombie"
            });

            MonstersFamily.Add(new Zombie()
            {
                Number = 5,
                Name = "Master",
                Speed = 200,
                CityLocation = "NewYork",
                CountryLocation = "USA",
                EatenPeople = 20,
                Zomb = "Zombie"
            });

            MonstersFamily.Add(new Vampire()
            {
                Number = 6,
                Name = "Demon",
                Speed = 300,
                CityLocation = "Moscow",
                CountryLocation = "Russia",
                BittenPeople = 10,
                Vamp = "Vampire"
            });

            MonstersFamily.Add(new Vampire()
            {
                Number = 7,
                Name = "Harlot",
                Speed = 420,
                CityLocation = "CapeTown",
                CountryLocation = "Africa",
                BittenPeople = 0,
                Vamp = "Vampire"
            });

            MonstersFamily.Add(new Vampire()
            {
                Number = 8,
                Name = "Concubine",
                Speed = 280,
                CityLocation = "BuenosAires",
                CountryLocation = "Argentina",
                BittenPeople = 38,
                Vamp = "Vampire"
            });

            MonstersFamily.Add(new Vampire()
            {
                Number = 9,
                Name = "Tramp",
                Speed = 550,
                CityLocation = "Pekin",
                CountryLocation = "China",
                BittenPeople = 95,
                Vamp = "Vampire"
            });

            MonstersFamily.Add(new Vampire()
            {
                Number = 10,
                Name = "Vixen",
                Speed = 600,
                CityLocation = "Habana",
                CountryLocation = "Cuba",
                BittenPeople = 2,
                Vamp = "Vampire"
            });

            dataGridView1.DataSource = MonstersFamily;

        }
    }
}
