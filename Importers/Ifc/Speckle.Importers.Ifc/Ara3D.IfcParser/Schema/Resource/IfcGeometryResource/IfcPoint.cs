using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcPoint : IfcNode
{
    public IfcPoint(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
