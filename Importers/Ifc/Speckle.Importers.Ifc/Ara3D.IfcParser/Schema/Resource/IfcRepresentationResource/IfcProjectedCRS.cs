using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcProjectedCRS : IfcCoordinateReferenceSystem
{
    public string? VerticalDatum => (this[3] as StepString)?.Value.ToString();
    public string? MapProjection => (this[4] as StepString)?.Value.ToString();
    public string? MapZone => (this[5] as StepString)?.Value.ToString();
    public IfcNamedUnit? MapUnit
    {
        get
        {
            var stepId = this[6] as StepId;
            return stepId != null ? Graph.GetNode(stepId) as IfcNamedUnit : null;
        }
    }

    public IfcProjectedCRS(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
