using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcGeographicCRS : IfcCoordinateReferenceSystem
{
    public string? PrimeMeridian => (this[3] as StepString)?.Value.ToString();
    public IfcNamedUnit? AngleUnit
    {
        get
        {
            var stepId = this[4] as StepId;
            return stepId != null ? Graph.GetNode(stepId) as IfcNamedUnit : null;
        }
    }
    public IfcNamedUnit? HeightUnit
    {
        get
        {
            var stepId = this[5] as StepId;
            return stepId != null ? Graph.GetNode(stepId) as IfcNamedUnit : null;
        }
    }

    public IfcGeographicCRS(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
