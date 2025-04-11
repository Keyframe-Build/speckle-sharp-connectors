using System;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcRoad : IfcSpatialStructureElement
{
  public StepSymbol? PredefinedType => this[9] as StepSymbol;

  public IfcRoad(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
