﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsDatagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Oszlopok.Items.Add("*");
            ListBox_Oszlopok_Feltoltese();
       
            listBox_Oszlopok.DisplayMember = "Megjegyzés";
            listBox_Oszlopok.ValueMember = "ColumnName";
            listBox_Oszlopok.SelectedIndex = -1;
            listBox_Oszlopok.SelectedIndexChanged += ListBox_Oszlopok_SelectedIndexChanged;
            listBox_Oszlopok.SelectionMode = SelectionMode.MultiSimple;
        }

        private void ListBox_Oszlopok_Feltoltese()
        {
            //-- oszlopok.json-ban lévő adatokból a ListBox_Oszlopok feltöltése
            var jsonString = File.ReadAllText("oszlopok.json");
            List<Oszlop> oszlopok = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Oszlop>>(jsonString);
            foreach (Oszlop oszlop in oszlopok)
            {
                listBox_Oszlopok.Items.Add(oszlop);
            }
            //listBox_Oszlopok.DataSource = oszlopok;
        }

        private void ListBox_Oszlopok_SelectedIndexChanged(object sender, EventArgs e)
        {
            return  ;
        }

        private void button_Frissit_Click(object sender, EventArgs e)
        {
         List<Oszlop> KivalasztottOszlopok = listBox_Oszlopok.SelectedItems.Cast<Oszlop>().ToList();
        }
    }
}
