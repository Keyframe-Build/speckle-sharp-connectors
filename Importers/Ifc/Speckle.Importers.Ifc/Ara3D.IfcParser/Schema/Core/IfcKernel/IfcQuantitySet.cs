using System.Collections.Generic;
using System.Linq;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcQuantitySet : IfcPropertySetDefinition
{
  public IfcQuantitySet(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
