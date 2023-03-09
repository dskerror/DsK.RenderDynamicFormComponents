using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsK.RenderDynamicFormComponents.Shared
{
    public class Element
    {
        public virtual string ElementType { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }
    }

    public class TextInput : Element
    {
        public override string ElementType { get => "TextInput"; }

        public string? PlaceHolder { get; set; }

        public string? Value { get; set; }
    }

    public class RadioButton : Element
    {
        public override string ElementType { get => "RadioButton"; }

        public Dictionary<string, string> Options { get; set; }
    }

    public class Form
    {
        public List<Element> Elements { get; set; } = new List<Element>();
    }
}
