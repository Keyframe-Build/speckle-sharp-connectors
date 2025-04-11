using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcBearing : IfcElement
{
  public StepSymbol? PredefinedType => this[8] as StepSymbol;

  public IfcBearing(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
