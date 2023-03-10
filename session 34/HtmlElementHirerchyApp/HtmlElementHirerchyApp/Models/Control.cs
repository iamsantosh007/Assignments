using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElementHirerchyApp.Models
{
    internal class Control : IDomElement
    {
        private readonly string _elemeentType;
        private readonly int _id;
        private readonly string _displayText;

        public Control(string elementType,int id,string displayText)
        {
            _elemeentType = elementType;
            _id = id;
            _displayText = displayText;
        }
        public string ElementType { get { return _elemeentType; } }
        public int Id { get { return _id; } }
        public string DisplayText { get { return _displayText; } }

        public string Render()
        {
            return $"<{ElementType} id=\"{Id}\">\n{DisplayText}\n</{ElementType}>";
        }
    }
}
