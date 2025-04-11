using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcNavigationElement : IfcElement
{
  public StepSymbol? PredefinedType => this[8] as StepSymbol;

  public IfcNavigationElement(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
