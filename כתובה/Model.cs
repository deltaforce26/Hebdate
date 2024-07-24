using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace כתובה
{
    [Serializable]
    public class Model
    {
        public string? Day { get; set; }
        public string? DayMonth { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public string? Result { get; set; }
        
    }
}
