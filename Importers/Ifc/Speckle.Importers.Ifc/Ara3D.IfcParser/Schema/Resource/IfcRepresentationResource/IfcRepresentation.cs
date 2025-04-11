using System.Collections.Generic;
using System.Linq;
using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcRepresentation : IfcNode
{
    public IfcRepresentationContext ContextOfItems
    {
        get
        {
            var context = this[0] as StepId;
            return Graph.GetNode(context) as IfcRepresentationContext;
        }
    }
    public string? RepresentationIdentifier => (this[1] as StepString)?.Value.ToString();
    public string? RepresentationType => (this[2] as StepString)?.Value.ToString();
    public StepList? Items => this[3] as StepList;

    public IfcRepresentation(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
