using DsK.RenderDynamicFormComponents.Shared;
using Microsoft.AspNetCore.Components;

namespace DsK.RenderDynamicFormComponents.Client.Pages;
public partial class DynamicForm2
{

    private List<HTMLInput> _values = new List<HTMLInput>();
    private string _selectedHTMLInputType = HTMLInputType.Textbox.ToString();

    private void SelecteHTMLInputType(ChangeEventArgs e)
    {
        _selectedHTMLInputType = e.Value.ToString();
    }

    private void CreateHTMLInput()
    {
        var newinput = new HTMLInput(string.Empty, Enum.Parse<HTMLInputType>(_selectedHTMLInputType));
        _values.Add(newinput);
    }

    private void UpdateValue(int i, string value)
    {
        _values[i].Value = value;
    }

    private void RemoveValue(int i) => _values.RemoveAt(i);
    private void HandleSubmit()
    {
        foreach (var item in _values)
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
