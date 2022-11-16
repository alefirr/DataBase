using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using System.Windows.Forms;


namespace DataBase
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\olefi\\Desktop\\DataBase\\DataBase\\XMLFile1.xml";
        List<Sights> final = new List<Sights>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)                 // TRANSFORM TO HTML
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("Trans.xslt");
            string input = "C:\\Users\\olefi\\Desktop\\DataBase\\DataBase\\XMLFile1.xml";
            string result = "C:\\Users\\olefi\\Desktop\\info.html";

            xslt.Transform(input, result);
            MessageBox.Show("Transformation is done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)             // CLEAR
        {
            richTextBox1.Clear();
            City.Checked = false;
            Name_.Checked = false;
            Type_.Checked = false;
            Height_.Checked = false;
            Age.Checked = false;
            CityBox.Text = null;
            NameBox.Text = null;
            TypeBox.Text = null;
            HeightBox.Text = null;
            AgeBox.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)            // SEARCH
        {
            Search();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeightBox.Sorted = true;
            if (HeightBox.SelectedItem != null)
                Height_.Checked = true;
        }

        public void GetAllSights()
        {
            XmlDocument doc = new XmlDocument();
            link1: try
            {
                doc.Load("C:\\Users\\olefi\\Desktop\\DataBase\\DataBase\\XMLFile1.xml");
            }
            catch {
                DialogResult result = MessageBox.Show("Invalid data in DataBase. The program can't be started until the error is fixed.", "DATABASE ERROR",
            MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Retry) goto link1;
                else Environment.Exit(0);
            }

            XmlNodeList elem = doc.SelectNodes("//SightsDataBase");
            foreach (XmlNode e in elem)
            {
                XmlNodeList list1 = e.ChildNodes;
                foreach (XmlNode el in list1)
                {
                        try
                        {
                            string city = el.Attributes.GetNamedItem("CITY").Value;
                            if (!CityBox.Items.Contains(city))
                                CityBox.Items.Add(city);
                        }
                        catch { }

                        try
                        {
                            string name = el.Attributes.GetNamedItem("NAME").Value;
                            if (!NameBox.Items.Contains(name))
                                NameBox.Items.Add(name);
                        }
                        catch { }
                        try
                        {
                            string type = el.Attributes.GetNamedItem("TYPE").Value;
                            if (!TypeBox.Items.Contains(type))
                                TypeBox.Items.Add(type);
                        }
                        catch { }
                        try
                        {
                            string height = el.Attributes.GetNamedItem("HEIGHT").Value;
                            if (!HeightBox.Items.Contains(height))
                                HeightBox.Items.Add(height);
                        }
                        catch { }
                        try
                        {
                            string age = el.Attributes.GetNamedItem("AGE").Value;
                            if (!AgeBox.Items.Contains(age))
                                AgeBox.Items.Add(age);
                        }
                        catch { }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GetAllSights();
        }

        private void DOM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void search(Sights si)
        {
            if (City.Checked)
                si.City = CityBox.SelectedItem.ToString();
            if (Name_.Checked)
                si.Name = NameBox.SelectedItem.ToString();
            if (Type_.Checked)
                si.Type = TypeBox.SelectedItem.ToString();
            if (Height_.Checked)
                si.Height = HeightBox.SelectedItem.ToString();
            if (Age.Checked)
                si.Age = AgeBox.SelectedItem.ToString();
        }

        private void Name__CheckedChanged(object sender, EventArgs e)
        {
            if (NameBox.SelectedItem == null && Name_.Checked)
            {
                Name_.Checked = false;
                MessageBox.Show("First choose one of the search filters for this category.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void City_CheckedChanged(object sender, EventArgs e)
        {
            if (CityBox.SelectedItem == null && City.Checked)
            {
                City.Checked = false;
                MessageBox.Show("First choose one of the search filters for this category.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Type__CheckedChanged(object sender, EventArgs e)
        {
            if (TypeBox.SelectedItem == null && Type_.Checked)
            {
                Type_.Checked = false;
                MessageBox.Show("First choose one of the search filters for this category.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Height__CheckedChanged(object sender, EventArgs e)
        {
            if (HeightBox.SelectedItem == null && Height_.Checked)
            {
                Height_.Checked = false;
                MessageBox.Show("First choose one of the search filters for this category.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Age_CheckedChanged(object sender, EventArgs e)
        {
            if (AgeBox.SelectedItem == null && Age.Checked)
            {
                Age.Checked = false;
                MessageBox.Show("First choose one of the search filters for this category.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityBox.SelectedItem != null)
                City.Checked = true;
        }

        private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameBox.SelectedItem != null)
                Name_.Checked = true;
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeBox.SelectedItem != null)
                Type_.Checked = true;
        }

        private void HeightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HeightBox.SelectedItem != null)
                Type_.Checked = true;
        }

        private void AgeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (AgeBox.SelectedItem != null)
                Age.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Search()
        {
            try
            {
                richTextBox1.Clear();
                Sights sight = ThisSight();
                search(sight);
                if (LINQ.Checked)
                {
                    IStrategy CurrentStrategy = new Linq(path);
                    final = CurrentStrategy.Algorithm(sight, path);
                    Output(final);
                }
                else if (DOM.Checked)
                {
                    IStrategy CurrentStrategy = new Dom(path);
                    final = CurrentStrategy.Algorithm(sight, path);
                    Output(final);
                }
                else if (SAX.Checked)
                {
                    IStrategy CurrentStrategy = new Sax(path);
                    final = CurrentStrategy.Algorithm(sight, path);
                    Output(final);
                }
                else MessageBox.Show("Choose the one of the search ways.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch { MessageBox.Show("Unknown DataBase error. The search can't be done.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        private void Output(List<Sights> final)
        {
            int i = 1;
            Console.WriteLine("Alg+");
            foreach (Sights n in final)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                if (n.Name != null)
                    richTextBox1.AppendText("Name: " + n.Name + "\n");
                if (n.City != null)
                    richTextBox1.AppendText("City: " + n.City + "\n");
                if (n.Type != null)
                    richTextBox1.AppendText("Type: " + n.Type + "\n");
                if (n.Height != null)
                    richTextBox1.AppendText("Height: " + n.Height + "\n");
                if (n.Age != null)
                    richTextBox1.AppendText("Age: " + n.Age + "\n");
                richTextBox1.AppendText("======================================\n");
            }
            if (richTextBox1.Text == "")
            {
                string spaces = "           ";
                richTextBox1.AppendText("\n\n" + spaces + "No information found.");
            }
        }

        private Sights ThisSight()
        {
            string[] info = new string[5];
            if (City.Checked) info[1] = Convert.ToString(CityBox);
            if (Name_.Checked) info[0] = Convert.ToString(NameBox);
            if (Type_.Checked) info[2] = Convert.ToString(TypeBox);
            if (Height_.Checked) info[3] = Convert.ToString(HeightBox);
            if (Age.Checked) info[4] = Convert.ToString(AgeBox);
            Sights PerfectSight = new Sights(info);
            return PerfectSight;
        }
    }
}
