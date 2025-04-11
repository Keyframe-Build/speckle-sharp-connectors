using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcShapeModel : IfcRepresentation
{
  public IfcShapeModel(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
