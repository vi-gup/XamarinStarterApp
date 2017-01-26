using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStarter.Models
{
    public class Attribute
    {
        public string Name { get; set;}
        public string Description { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public Xamarin.Forms.ImageSource Image { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
