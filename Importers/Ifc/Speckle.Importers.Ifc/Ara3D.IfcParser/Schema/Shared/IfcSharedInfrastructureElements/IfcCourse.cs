using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcCourse : IfcElement
{
  public StepSymbol? PredefinedType => this[8] as StepSymbol;

  public IfcCourse(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
