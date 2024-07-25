using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections;

namespace כתובה
{
    public partial class Form1 : Form
    {
        private string? _day;
        private string? _dayOfMonth;
        private string? _month;
        private string? _year;
        private int _index;
        private string? _nextMonth;
        Dictionary<string, string> years = new Dictionary<string, string>()
        {
               {"תשפ\"ד", "חמשת אלפים ושבע מאות שמונים וארבע"},
               {"תשפ\"ה", "חמשת אלפים ושבע מאות שמונים וחמש"},
               {"תשפ\"ו", "חמשת אלפים ושבע מאות שמונים ושש"},
               {"תשפ\"ז", "חמשת אלפים ושבע מאות שמונים ושבע"},
               {"תשפ\"ח", "חמשת אלפים ושבע מאות שמונים ושמונה"},
               {"תשפ\"ט", "חמשת אלפים ושבע מאות שמונים ותשע"},
               {"תש\"צ", "חמשת אלפים ושבע מאות ותשעים"},
               {"תשצ\"א", "חמשת אלפים ושבע מאות ותשעים ואחת"},
               {"תשצ\"ב", "חמשת אלפים ושבע מאות ותשעים ושתיים"},
               {"תשצ\"ג", "חמשת אלפים ושבע מאות ותשעים ושלוש"}
        };
        Dictionary<int, string> daysOfMonth = new Dictionary<int, string>()
        {
                { 1, "יום אחד" },
                { 2, "שני ימים" },
                {3, "שלשה ימים" },
                {4, "ארבעה ימים" },
                { 5, "חמישה ימים" },
                { 6, "שישה ימים" },
                { 7, "שבעה ימים" },
                { 8, "שמונה ימים" },
                { 9, "תשעה ימים" },
                { 10, "עשרה ימים" },
                { 11, "אחד עשר יום" },
                { 12, "שנים עשר יום" },
                { 13, "שלשה עשר יום" },
                { 14, "ארבעה עשר ימים" },
                { 15, "חמישה עשר ימים" },
                { 16, "ששה עשר יום" },
                { 17, "שבעה עשר ימים" },
                { 18, "שמונה עשר ימים" },
                { 19, "תשעה עשר ימים" },
                { 20, "עשרים ימים" },
                { 21, "עשרים ואחד ימים" },
                { 22, "עשרים ושתיים ימים" },
                { 23, "עשרים ושלושה ימים" },
                { 24, "עשרים וארבעה ימים" },
                { 25, "עשרים וחמישה ימים" },
                { 26, "עשרים וששה ימים" },
                { 27, "עשרים ושבעה ימים" },
                { 28, "עשרים ושמונה ימים" },
                { 29, "עשרים ותשע ימים" },
                { 30, "יום שלשים" }
        };
        Dictionary<string, string> daysOfWeek = new Dictionary<string, string>()
        {
            {"ראשון","באחד" },
            { "שני", "בשני"},
            {"שלישי", "בשלישי"},
            {"רביעי", "ברביעי" },
            { "חמישי", "בחמישי"},
            {"שישי","בששי" }
        };
        List<string> months = ["תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_confirm_Click(object sender, EventArgs e)
        {
            Model ctuba = new Model();
            if (ifNull())
            {
                ctuba.Year = comboBox_year.SelectedItem.ToString();
                ctuba.Month = comboBox_month.SelectedItem.ToString();
                ctuba.Day = comboBox_dayOfWeek.SelectedItem.ToString();
                ctuba.DayMonth = comboBox_DayOfMonth.SelectedItem.ToString();

                
                foreach (KeyValuePair<int, string> dayInMonth in daysOfMonth)
                {
                    if (dayInMonth.Key.ToString() == ctuba.DayMonth)
                    {
                        _dayOfMonth = dayInMonth.Value;
                        
                    }

                }
                foreach (KeyValuePair<string, string> year in years)
                {
                    if (year.Key == ctuba.Year)
                    {
                        _year = year.Value;
                    }

                }
                foreach (KeyValuePair<string, string> day in daysOfWeek)
                {
                    if (day.Key == ctuba.Day)
                    {
                        _day = day.Value;
                    }

                }
                int index = months.FindIndex(m => m.Contains(ctuba.Month));
                _month = months[index];
                _nextMonth = months[index + 1];
                ctuba.Result = ctuba.DayMonth switch
                {
                    "30" => $"{_day} בשבת {_dayOfMonth} לירח {_month} שהוא ראש חודש {_nextMonth} שנת {_year} לבריאת העולם",
                    _ => $"{_day} בשבת {_dayOfMonth} לירח {_month} שנת {_year} לבריאת העולם"
                };
                MessageBox.Show(ctuba.Result);
                add();
            }
            else
            {
                MessageBox.Show("Missing required fields.");
            }
            
            
            
            

        }
        
        private bool  ifNull()
        {
            if (string.IsNullOrEmpty(comboBox_year.Text) || 
                string.IsNullOrEmpty(comboBox_month.Text) ||
                string.IsNullOrEmpty(comboBox_dayOfWeek.Text)||
                string.IsNullOrEmpty(comboBox_DayOfMonth.Text))
            {
                
                return false;
            }
            else
            {
                
                return true;
            }
            
        }
        private void add()
        {
            XDocument doc = XDocument.Load(@"C:\Users\97258\source\repos\כתובה\כתובה\XMLFile1.xml");
            if (doc == null)
            {
                throw new InvalidOperationException("The XML document could not be loaded.");
            }
            else
            {
                XElement? root = doc.Root;
                if (root == null)
                {
                    throw new InvalidOperationException("The XML document does not have a root element.");
                }
                else
                {
                    root.Add(
                         new XElement("query",
                         new XElement("day", _day),
                         new XElement("datMonth", _dayOfMonth),
                         new XElement("month", _month),
                         new XElement("year", _year)
                         ));
                    doc.Save(@"C:\Users\97258\source\repos\כתובה\כתובה\XMLFile1.xml");
                }
                
            }
            
        }
    }
}

