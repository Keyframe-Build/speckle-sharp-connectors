using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcTrackElement : IfcElement
{
  public StepSymbol? PredefinedType => this[8] as StepSymbol;

  public IfcTrackElement(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
