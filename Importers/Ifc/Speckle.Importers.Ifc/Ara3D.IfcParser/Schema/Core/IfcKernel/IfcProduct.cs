using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public abstract class IfcProduct(IfcGraph graph, StepInstance lineData) : IfcObject(graph, lineData) 
{
    public StepId? ObjectPlacement => this[5] as StepId;
    public IfcProductRepresentation? Representation
    {
        get
        {
            var representation = this[6] as StepId;
            return representation == null
                ? null
                : Graph.GetNode(representation) as IfcProductRepresentation;
        }
    }
}
