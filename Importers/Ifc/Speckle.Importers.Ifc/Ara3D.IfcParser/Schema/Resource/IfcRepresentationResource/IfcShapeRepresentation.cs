using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcShapeRepresentation : IfcShapeModel
{
  public IfcShapeRepresentation(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
