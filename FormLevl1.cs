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
    public partial class FormLevel1 : Form
    {
        public FormLevel1()
        {
            InitializeComponent();
            start_game();
        }

        private void start_game()
    {
        Point point;
        point = label_start.Location;
        point.Offset(label_start.Width / 2, label_start.Height / 2);
        Cursor.Position = PointToScreen (point);
        Sounds.play_start();
    }
        private void finish_game()
        {
            Sounds.play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли, ещё разок попробуем?", "Сообщение",
               MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                start_game();
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

        }

        private void FormLevl1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }



    }
}
