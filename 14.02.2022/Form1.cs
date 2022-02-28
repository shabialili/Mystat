using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._02._2022
{
    public partial class Mystat : Form
    {
        public Mystat()
        {
            InitializeComponent();
        }

        private void Əsas_müəllim_CheckedChanged(object sender, EventArgs e)
        {
            if(Əsas_müəllim.Checked||Əzəvedici_müəllim.Checked)
            {
                Note.Visible = true;
            }
        }
        private void Note_Click(object sender, EventArgs e)
        {
            textBox_LessonName.Visible= true;   
            Save.Visible = true;    
            DontSave.Visible = true;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            radioButton_choose.Enabled = true;
            i_e_1.Visible = true;   
            i_e_2.Visible = true;   
            i_e_3.Visible = true;
            i_e_4.Visible = true;
            i_e_5.Visible = true;
            i_e_6.Visible = true;
            g_1.Visible = true;
            g_2.Visible = true;
            g_3.Visible = true;
            g_4.Visible = true;
            g_5.Visible = true;
            g_6.Visible = true;
            q_1.Visible = true;
            q_2.Visible = true;
            q_3.Visible = true;
            q_4.Visible = true;
            q_5.Visible = true;
            q_6.Visible = true;
            comboBox_Y1.Visible= true;  
            comboBox_Y2.Visible= true;  
            comboBox_Y3.Visible= true;
            comboBox_Y4.Visible= true;
            comboBox_Y5.Visible= true;
            comboBox_Y6.Visible= true;
            comboBox_S1.Visible= true;
            comboBox_S2.Visible= true;
            comboBox_S3.Visible= true;  
            comboBox_S4.Visible= true;
            comboBox_S5.Visible= true;
            comboBox_S6.Visible= true;
            i_e_1.Enabled = true;
            i_e_2.Enabled = true;
            i_e_3.Enabled = true;
            i_e_4.Enabled = true;
            i_e_5.Enabled = true;
            i_e_6.Enabled = true;
            g_1.Enabled = true;
            g_2.Enabled = true;
            g_3.Enabled = true;
            g_4.Enabled = true;
            g_5.Enabled = true;
            g_6.Enabled = true;
            q_1.Enabled = true;
            q_2.Enabled = true;
            q_3.Enabled = true;
            q_4.Enabled = true;
            q_5.Enabled = true;
            q_6.Enabled = true;
            comboBox_Y1.Enabled = true;
            comboBox_Y2.Enabled = true;
            comboBox_Y3.Enabled = true;
            comboBox_Y4.Enabled = true;
            comboBox_Y5.Enabled = true;
            comboBox_Y6.Enabled = true;
            comboBox_S1.Enabled = true;
            comboBox_S2.Enabled = true;
            comboBox_S3.Enabled = true;
            comboBox_S4.Enabled = true;
            comboBox_S5.Enabled = true;
            comboBox_S6.Enabled = true;
            foreach (var item in groupBox_kristal.Controls)
            {
                (item as CheckBox).Visible = true;
            }
        }
        private void DontSave_Click(object sender, EventArgs e)
        {
            Note.Text = "";
        }

        private void radioButton_choose_CheckedChanged(object sender, EventArgs e)
        {
            i_e_1.Checked = true;
            i_e_2.Checked = true;
            i_e_3.Checked = true;   
            i_e_4.Checked = true;
            i_e_5.Checked = true;
            i_e_6.Checked = true;
        }
        private void checkBox1_1_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;

            textBox_kristal.Text = (int.Parse(textBox_kristal.Text) - 1).ToString();
            if (int.Parse(textBox_kristal.Text) == 0)
            {
                foreach (Control control in groupBox_kristal.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }
        private void checkBox1_2_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;

            foreach (Control control in groupBox_kristal.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                {
                    (control as CheckBox).Checked = true;
                }
            }
            textBox_kristal.Text = (int.Parse(textBox_kristal.Text) - 2).ToString();
            if (int.Parse(textBox_kristal.Text) == 0)
            {
                foreach (Control control in groupBox_kristal.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }
        private void checkBox1_3_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;

            foreach (Control control in groupBox_kristal.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                {
                    (control as CheckBox).Checked = true;
                }
            }
            foreach (Control control in groupBox_kristal.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 2)
                {
                    (control as CheckBox).Checked = true;
                }
            }
            textBox_kristal.Text = (int.Parse(textBox_kristal.Text)).ToString();
            if (int.Parse(textBox_kristal.Text) == 0)
            {
                foreach (Control control in groupBox_kristal.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }

        private void Əzəvedici_müəllim_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                Note.Enabled = true;
                

            }
        }


    }
}
