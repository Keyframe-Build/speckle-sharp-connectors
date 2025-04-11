using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcValue : IfcNode
{
    public IfcValue(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
