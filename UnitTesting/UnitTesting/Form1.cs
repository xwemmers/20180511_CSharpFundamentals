using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Namen.Add("Xander");
            Namen.Add("Joell");
            Namen.Add("Ad");
            Namen.Add("Ad");
            Namen.Add("Marijn");
            Namen.Add("Hakan");

            listBox1.DataSource = Namen;
            
        }


        List<string> Namen = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            string Naam = listBox1.SelectedItem.ToString();

            //Person p = (Person)listBox1.SelectedItem;

            label1.Text = $"{listBox1.SelectedIndex} was removed";
            Namen.Remove(Naam);

            listBox1.DataSource = null;
            listBox1.DataSource = Namen;

            listBox1.SelectedIndex = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dit is de foute manier!
            int index = listBox1.SelectedIndex;
            Namen.RemoveAt(index);

            listBox1.DataSource = null;
            listBox1.DataSource = Namen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int getal1 = int.Parse(textBox1.Text);
                int getal2 = int.Parse(textBox2.Text);

                int antwoord = getal1 / getal2;

                label1.Text = $"{getal1} gedeeld door {getal2} is {antwoord}";
            }
            catch(CalculatorException ex)
            {
                label1.Text = ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                label1.Text = "Delen door nul mag niet!";
            }

            catch (Exception ex)
            {
                label1.Text = "Dat was niet erg best!" + ex.Message;
            }
        }
    }
}
