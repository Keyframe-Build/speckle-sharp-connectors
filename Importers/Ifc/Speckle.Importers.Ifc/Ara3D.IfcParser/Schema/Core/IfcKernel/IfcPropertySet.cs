using System.Collections.Generic;
using System.Linq;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcPropertySet(IfcGraph graph, StepInstance lineData) : IfcPropertySetDefinition(graph, lineData)
{
  public IEnumerable<IfcProperty> HasProperties
  {
    get
    {
      var properties = this[4] as StepList;
      return properties?.Values?.OfType<StepId>().Select(x => Graph.GetNode(x.Id)).OfType<IfcProperty>()
        ?? Enumerable.Empty<IfcProperty>();
    }
  }
}
