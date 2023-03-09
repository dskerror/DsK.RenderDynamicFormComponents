using DsK.RenderDynamicFormComponents.Shared;

namespace DsK.RenderDynamicFormComponents.Client.Pages;
public partial class DynamicForm2
{

    private List<HTMLInput> values = new List<HTMLInput>();


    private void AddInput(HTMLInputType inputType)
    {
        var newinput = new HTMLInput(string.Empty, inputType);
        values.Add(newinput);
    }
    private void AddValueTextBox()
    {
        var newinput = new HTMLInput(string.Empty, HTMLInputType.Textbox);   
        values.Add(newinput);
    }

    private void AddValueTextarea()
    {
        var newinput = new HTMLInput(string.Empty, HTMLInputType.Textarea); 
        values.Add(newinput);
    }

    private void AddValueCheckbox()
    {
        var newinput = new HTMLInput(string.Empty, HTMLInputType.Checkbox);
        values.Add(newinput);
    }
    private void UpdateValue(int i, string value)
    {
        values[i].Value = value;
    }

    private void RemoveValue(int i) => values.RemoveAt(i);
    private void HandleSubmit()
    {
        foreach (var item in values)
        {
            Console.WriteLine(item.Value);
        }
    }


}

public class HTMLInput
{
    public HTMLInput(string value, HTMLInputType type)
    {
        Value = value;
        Type = type;
    }
    public string Name { get; set; }
    public string Value { get; set; }
    public HTMLInputType Type { get; set; }
}

public enum HTMLInputType
{
    Textbox,
    Textarea,
    Checkbox
}
