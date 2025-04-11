using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcAnnotation : IfcSpatialStructureElement
{
  public StepSymbol? PredefinedType => this[7] as StepSymbol;

  public IfcAnnotation(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
