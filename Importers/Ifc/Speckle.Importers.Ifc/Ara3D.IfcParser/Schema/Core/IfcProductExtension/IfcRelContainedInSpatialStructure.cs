using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcRelContainedInSpatialStructure : IfcRelationship
{
  public StepList RelatedElements
  {
    get { return this[4] as StepList ?? throw new SpeckleIfcException("RelatedElements cannot be null"); }
  }
  public StepId RelatingStructure
  {
    get { return this[5] as StepId ?? throw new SpeckleIfcException("RelatingStructure cannot be null"); }
  }

  public IfcRelContainedInSpatialStructure(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }

  // Implement the From property
  public override StepId From => RelatingStructure;

  // Implement the To property
  public override StepList To => RelatedElements;
}
