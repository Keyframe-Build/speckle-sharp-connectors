using System;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

[Obsolete("This definition will be removed in a future major release of this standard")]
public class IfcWallStandardCase : IfcWall
{
  public IfcWallStandardCase(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
