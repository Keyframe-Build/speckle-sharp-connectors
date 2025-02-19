using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser;

public class IfcObject: IfcNode
{
  public string? ObjectType => (this[4] as StepString)?.Value.ToString();
  public IfcObject(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
