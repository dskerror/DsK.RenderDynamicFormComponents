using DsK.RenderDynamicFormComponents.Shared;

namespace DsK.RenderDynamicFormComponents.Client.Pages;
public partial class DynamicForm
{

    private List<string> values = new List<string>();

    private void AddValue() => values.Add("");
    private void UpdateValue(int i, string value) => values[i] = value;
    private void RemoveValue(int i) => values.RemoveAt(i);
    private void HandleSubmit()
    {
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }
    }
}