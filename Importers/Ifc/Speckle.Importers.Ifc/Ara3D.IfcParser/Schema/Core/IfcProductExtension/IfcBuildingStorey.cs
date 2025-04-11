using System;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcBuildingStorey : IfcSpatialStructureElement
{
  [Obsolete("This attribute is deprecated and shall no longer be used")]
  public double? Elevation => (this[9] as StepNumber)?.Value;

  public IfcBuildingStorey(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }
}
