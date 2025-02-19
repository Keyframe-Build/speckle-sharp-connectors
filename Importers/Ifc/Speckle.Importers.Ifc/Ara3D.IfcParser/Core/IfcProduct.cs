using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser;

public class IfcProduct : IfcObject
{
  public StepId? ObjectPlacement => this[5] as StepId;
  public StepId? Representation => this[6] as StepId;

  public IfcProduct(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData)
  {
  }
}