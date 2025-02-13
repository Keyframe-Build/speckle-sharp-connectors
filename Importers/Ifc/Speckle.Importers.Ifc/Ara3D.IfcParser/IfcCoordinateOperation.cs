using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser;

public class IfcCoordinateOperation : IfcNode
{
  public StepId? SourceCRS => this[0] as StepId;
  public StepId? TargetCRS => this[1] as StepId;
  public IfcCoordinateOperation(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData)
  {
  }
}
