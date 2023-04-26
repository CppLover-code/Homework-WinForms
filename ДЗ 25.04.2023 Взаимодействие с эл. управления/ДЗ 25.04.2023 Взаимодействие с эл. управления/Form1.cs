using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ДЗ_25._04._2023_Взаимодействие_с_эл.управления
{
    [Serializable]
    public partial class Form1 : Form
    {
        FileStream stream = null;
        XmlSerializer serializer = null;
        string filename = "PersonInfo.xml";
        public Form1()
        {
            InitializeComponent();
            this.Text = "Анкета";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 500);
            this.Width = 400;   
            this.Height = 480;
        }

        private void bSave_MouseClick(object sender, MouseEventArgs e)
        {
            Form frm = ActiveForm;
            var TextBInfo = new List<string>();
            foreach (var ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                    TextBInfo.Add(((TextBox)ctrl).Text);              
            }

            if (e.Button == MouseButtons.Left)
            {
                stream = new FileStream(filename, FileMode.Create);
                serializer = new XmlSerializer(typeof(List<string>));
                serializer.Serialize(stream, TextBInfo);              
                stream.Close();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void bLoad_MouseClick(object sender, MouseEventArgs e)
        {
           
            Form frm = ActiveForm;
            var contr = new List<string>();
            foreach (var ctrl in frm.Controls)
            {
                contr.Add(ctrl.ToString());
            }

            if (e.Button == MouseButtons.Left)
            {
                stream = new FileStream(filename, FileMode.Open);
                serializer = new XmlSerializer(typeof(List<string>));
                var copyTextBInfo = (List<string>)serializer.Deserialize(stream);

                int ind = 0;
                foreach (var ctrl in frm.Controls)
                {                   
                    if (ctrl is TextBox)
                    {
                       ((TextBox)ctrl).Text = copyTextBInfo[ind];  
                        ind++;
                    }
                }
                stream.Close();
                MessageBox.Show("Данные успешно загружены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
