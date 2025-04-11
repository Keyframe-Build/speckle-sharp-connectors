using System;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcFurnishingElement : IfcElement
{
  public IfcFurnishingElement(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
