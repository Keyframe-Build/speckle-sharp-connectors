using System.Collections.Generic;
using System.Linq;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcElement : IfcProduct
{
  public string? Tag => (this[7] as StepString)?.Value.ToString();

  public IfcElement(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
