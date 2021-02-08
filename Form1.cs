using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Xsl;
using System.Xml.Linq;

namespace XML_Laba3
{
    public partial class Form1 : Form
    {
        private string path = "D:\\2 курс\\ООП\\Лабораторна робота №3 - XML\\XML_Laba3\\Planes.xml";
        public Form1()
        {
            InitializeComponent();
            //CreateComboboxes();
        }
        public void CreateComboboxes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@path);
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("flight");
            for(int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                
                    if (!comboBoxPrice.Items.Contains(n.SelectSingleNode("@Price").Value))
                        comboBoxPrice.Items.Add(n.SelectSingleNode("@Price").Value);
                    if (!comboBoxDeparture.Items.Contains(n.SelectSingleNode("@Departure").Value))
                        comboBoxDeparture.Items.Add(n.SelectSingleNode("@Departure").Value);
                    if (!comboBoxArrival.Items.Contains(n.SelectSingleNode("@Arrival").Value))
                        comboBoxArrival.Items.Add(n.SelectSingleNode("@Arrival").Value);
                    if (!comboBoxDate.Items.Contains(n.SelectSingleNode("@Date").Value))
                        comboBoxDate.Items.Add(n.SelectSingleNode("@Date").Value);
                    if (!comboBoxDuration.Items.Contains(n.SelectSingleNode("@Duration").Value))
                        comboBoxDuration.Items.Add(n.SelectSingleNode("@Duration").Value);
                    if (!comboBoxAirline.Items.Contains(n.SelectSingleNode("@Airline").Value))
                        comboBoxAirline.Items.Add(n.SelectSingleNode("@Airline").Value);
                    //if(!comboBoxLunch.Items.Contains(n.SelectSingleNode("@IncludeLunch").Value))
                    if (!comboBoxTourOperator.Items.Contains(n.SelectSingleNode("@TourOperator").Value))
                        comboBoxTourOperator.Items.Add(n.SelectSingleNode("@TourOperator").Value);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateComboboxes();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Text = "";
                Flights flight = new Flights();
                if (priceCheckBox.Checked)
                    flight.Price = comboBoxPrice.SelectedItem.ToString();
                if (departureCheckBox.Checked)
                    flight.Departure = comboBoxDeparture.SelectedItem.ToString();
                if (arrivalCheckBox.Checked)
                    flight.Arrival = comboBoxArrival.SelectedItem.ToString();
                if (dateCheckBox.Checked)
                    flight.Date = comboBoxDate.SelectedItem.ToString();
                if (durationCheckBox.Checked)
                    flight.Duration = comboBoxDuration.SelectedItem.ToString();
                if (airlineCheckBox.Checked)
                    flight.Airline = comboBoxAirline.SelectedItem.ToString();
                if (lunchCheckBox.Checked)
                    flight.IncludeLunch = comboBoxLunch.SelectedItem.ToString();
                if (tourOperCheckBox.Checked)
                    flight.TourOperator = comboBoxTourOperator.SelectedItem.ToString();


                ISearch analisator = new LinqXML();
                if (domRadioButton.Checked)
                    analisator = new DOM();
                if (saxRadioButton.Checked)
                    analisator = new SAX();
                if (linqRadioButton.Checked)
                    analisator = new LinqXML();

                flight.MyFlight = analisator;
                List<Flights> results = flight.Search(flight, path);
                Output(results);
            }
            catch (Exception) { }
        }
        private void Output(List<Flights> flights)
        {
            foreach(Flights flight in flights)
            {
                richTextBox.AppendText("Departure: " + flight.Departure + "\n");
                richTextBox.AppendText("Arrival: " + flight.Arrival + "\n");
                richTextBox.AppendText("Date: " + flight.Date + "\n");
                richTextBox.AppendText("Price: " + flight.Price + " UAH\n");
                richTextBox.AppendText("Duration: " + flight.Duration + " hours \n");
                richTextBox.AppendText("Airline: " + flight.Airline + "\n");
                richTextBox.AppendText("Include lunch: " + flight.IncludeLunch + "\n");
                richTextBox.AppendText("Tour operator: " + flight.TourOperator + "\n");
                richTextBox.AppendText("\n");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(@"D:\\2 курс\\ООП\\Лабораторна робота №3 - XML\\XML_Laba3\\FlightsHTML.xsl");
                string myXML = @path;
                string myHTML = "D:\\2 курс\\ООП\\Лабораторна робота №3 - XML\\XML_Laba3\\Flights.html";
                xslt.Transform(myXML, myHTML);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot transform file!", "Error");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Коротка інформація про програму:\n" +
                "Програма виконує пошук рейсів літаків одним з 3 запропонованих методів:\n - DOM\n - SAX\n - LINQ to XML\n"+
                "Оберіть потрібний вам метод через RadioButton\n"+
                "Ви можете задати потрібні йому параметри пошуку: для цього потрібно поставити галочку у CheckBox та обрати потрібний варіант у випадаючому списку\n"+
                "У текстовому полі з'являться результати пошуку\n"+
                "\nНатисніть кнопку Transform для транспортування файлу у html\n"+
                "Натисніть кнопку Clear для очистки текстового поля\n", "Help");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ви впевнені, що хочете вийти?", "Exit", MessageBoxButtons.YesNo))
                { }
            else
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SearchButton_Click(sender, e);
            XDocument document = XDocument.Load(@path);
            var result = (from flight in document.Descendants("flight")
                         where flight.Attribute("Arrival").Value == "Ukraine"
                         select new { 
                         /*price=(string)flight.Attribute("Price"),
                         dep = (string)flight.Attribute("Departure"),
                         arr= (string)flight.Attribute("Arrival")*/
                         avialin= (string)flight.Attribute("Airline")
                         }).ToList();
            foreach (var b in result)
            {
                richTextBox.Text += b.avialin+"\n";
            }
        }
    }
}
