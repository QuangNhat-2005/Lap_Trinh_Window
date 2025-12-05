using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai4 : Form
    {
        string path = Application.StartupPath + "\\form_bai4.xml"; 
        public FormBai4()
        {
            InitializeComponent();
        }


        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch { }
        }


        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch { return null; }
        }


        private void FormBai4_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
               
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location;
            }
        }


        private void FormBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);

       
        }
    }
}