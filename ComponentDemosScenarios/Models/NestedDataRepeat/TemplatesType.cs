namespace ComponentDemosScenarios.Models.NestedDataRepeat;

public class TemplatesType
{
    public string Name { get; set; }
    public DefaultPropValuesType[] DefaultPropValues { get; set; } = Array.Empty<DefaultPropValuesType>();
}
