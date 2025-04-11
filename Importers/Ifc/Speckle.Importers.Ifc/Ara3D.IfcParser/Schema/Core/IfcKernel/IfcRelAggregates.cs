using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcRelAggregates : IfcRelationship
{
  public StepId RelatingObject
  {
    get { return this[4] as StepId ?? throw new SpeckleIfcException("RelatingObject cannot be null"); }
  }
  public StepList RelatedObjects
  {
    get { return this[5] as StepList ?? throw new SpeckleIfcException("RelatedObjects cannot be null"); }
  }

  public IfcRelAggregates(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }

  // Implement the From property
  public override StepId From => RelatingObject;

  // Implement the To property
  public override StepList To => RelatedObjects;
}
