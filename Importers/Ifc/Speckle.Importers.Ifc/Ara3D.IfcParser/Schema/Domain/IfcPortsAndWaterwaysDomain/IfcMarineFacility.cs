using System;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcMarineFacility : IfcSpatialStructureElement
{
  public StepSymbol? PredefinedType => this[9] as StepSymbol;

  public IfcMarineFacility(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
