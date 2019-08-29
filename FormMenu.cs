﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_0._0
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                Sounds.sound_on();
                box_sound.Text = "Звук есть";
                Sounds.play_press();
            }
            else
	{
                Sounds.sound_off();
                box_sound.Text = "Звука нет";
	}

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_level2();
            }
        }

             private void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_youwin();
                Sounds.play_win();
            }
        }
                 private void start_youwin()
                 {
                     Sounds.play_win();
                     MessageBox.Show("Вы прошли все лабиринты","Поздравляю!!!");
                 }




                
        }
    }

