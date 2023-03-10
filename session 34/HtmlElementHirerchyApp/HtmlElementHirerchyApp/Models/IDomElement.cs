using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElementHirerchyApp.Models
{
    public interface IDomElement
    {
       // public string ElementType { get; set; }
        string Render();
    }
}
