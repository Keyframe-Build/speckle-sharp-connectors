using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser;

public class IfcNode : IfcEntity
{
  public bool Published { get; set; }
  
  public IfcNode(IfcGraph graph, StepInstance lineData)
    : base(graph, lineData) 
  { 
    Published = false;
  }
}
