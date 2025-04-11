using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcSpatialElement : IfcProduct
{
  public string? LongName => (this[7] as StepString)?.Value.ToString();

  public IfcSpatialElement(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
