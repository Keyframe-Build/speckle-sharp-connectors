using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcFastener : IfcElement
{
  public StepSymbol? PredefinedType => this[8] as StepSymbol;

  public IfcFastener(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
