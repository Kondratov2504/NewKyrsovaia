﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КурсоваяНовыйВариант.classDataSetTableAdapters;

namespace КурсоваяНовыйВариант
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teacherDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.teacherDataSet.Teacher);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            teacherBindingSource.EndEdit();
            teacherTableAdapter.Update(teacherDataSet.Teacher);
            MessageBox.Show("Сохранено");
            this.teacherTableAdapter.Fill(this.teacherDataSet.Teacher);
        }
    }
}
