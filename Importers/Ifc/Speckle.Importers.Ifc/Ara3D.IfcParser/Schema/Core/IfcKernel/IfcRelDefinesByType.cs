using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcRelDefinesByType : IfcRelationship
{
  public StepList RelatedObjects
  {
    get { return this[4] as StepList ?? throw new SpeckleIfcException("RelatedObjects cannot be null"); }
  }
  public StepId RelatingType
  {
    get { return this[5] as StepId ?? throw new SpeckleIfcException("RelatingType cannot be null"); }
  }

  public IfcRelDefinesByType(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) { }

  // Implement the From property
  public override StepId From => RelatingType;

  // Implement the To property
  public override StepList To => RelatedObjects;
}
