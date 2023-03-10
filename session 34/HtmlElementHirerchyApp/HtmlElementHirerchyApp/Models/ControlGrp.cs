using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElementHirerchyApp.Models
{
    internal class ControlGrp : IDomElement
    {
        private  readonly string _elementType;
        private List<IDomElement> _controls;
        protected int _space = 0;
        public ControlGrp(string elementType)
        {
            _controls = new List<IDomElement>();
            _elementType = elementType;
        }
        public string ElementType { get { return _elementType; } }

        public void AddChild(IDomElement element)
        {
            _controls.Add(element);
        }
        public string SpaceIncrementer(int space)
        {
            string spaces = "";
            for (int i = 0;  i < space; i++){
                spaces += "-";
            }
            return spaces;
        }
        public string GetChildElement(List<IDomElement> domElement)
        {
            
            string childElements = "";
            foreach (IDomElement element in domElement)
            {
                if (element.GetType().Name == "ControlGrp")
                {
                    ControlGrp controlGrpElement = ((ControlGrp)element);
                    //controlGrpElement._space++;
                    GetChildElement(controlGrpElement._controls);
                    //childElements+=SpaceIncrementer(space+1);
                    childElements+= element.Render();
                    continue;
                }
                //childElements += SpaceIncrementer(space + 1);
                childElements += element.Render();
            }
            return childElements;
        }
        public void GenerateToHtml()
        {
            using(FileStream stream=new FileStream("E:\\Swabhav Assignments\\session 34\\generatedHtml.html", FileMode.OpenOrCreate))
            {
                string file = Render();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(file);
                writer.Close();
            }
        }
        public string Render()
        {
            
            return $"<{ElementType}>\n{GetChildElement(_controls)}\n</{ElementType}>";
        }
    }
}
