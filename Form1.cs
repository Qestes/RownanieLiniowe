﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RownanieLiniowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            format();
        }

        int n = 4;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            label5.Text = n.ToString();
            numericUpDown1.Value = n;
            format();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            label5.Text = n.ToString();
            trackBar1.Value = n;
            format();
        }
        private void format()
        {
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

            dataGridView2.RowCount = n;

            dataGridView3.RowCount = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random losuj = new Random();
            // Wygeneruj losowe liczby dla tabeli 1
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    dataGridView1[i,j].Value = (losuj.Next(-100,100)+losuj.NextDouble()).ToString("0.00");
                }
            }
            // Wygeneruj losowe liczby dla tabeli 3
            for (int i = 0; i < n; i++)
            {
                dataGridView3[0, i].Value = (losuj.Next(-100, 100) + losuj.NextDouble()).ToString("0.00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Zachowanie przycisku do testowania

            Random losuj = new Random();
            // Wygeneruj losowe liczby dla tabeli 1
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1[i, j].Value = losuj.Next(0, 20).ToString("0.00");
                }
            }
            // Wylicz sumę wiersza z tabeli 1 i wypisz w tabeli 3
            for (int i = 0; i < n; i++)
            {
;               double suma = 0;
                for(int j = 0; j < n; j++)
                {
                    suma += Double.Parse(dataGridView1[j,i].Value.ToString());
                }
                dataGridView3[0, i].Value = suma;
            }
        }
    }
}
