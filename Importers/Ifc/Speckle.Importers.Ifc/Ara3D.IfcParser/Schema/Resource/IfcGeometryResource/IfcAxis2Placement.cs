using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public class IfcAxis2Placement : IfcPlacement
{
    public IfcAxis2Placement(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}

public class IfcAxis2Placement2D : IfcAxis2Placement
{
    public IfcDirection? RefDirection
    {
        get
        {
            var direction = this[1] as StepId;
            return direction == null ? null : Graph.GetNode(direction) as IfcDirection;
        }
    }

    public IfcAxis2Placement2D(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}

public class IfcAxis2Placement3D : IfcAxis2Placement
{
    public IfcDirection? Axis
    {
        get
        {
            if (this[1] is StepId direction)
            {
                return Graph.GetNode(direction) as IfcDirection;
            }
            return null;
            //var direction = this[1] as StepId;
            //return direction == null ? null : Graph.GetNode(direction) as IfcDirection;
        }
    }
    public IfcDirection? RefDirection
    {
        get
        {
            var direction = this[2] as StepId;
            return direction == null ? null : Graph.GetNode(direction) as IfcDirection;
        }
    }

    public IfcAxis2Placement3D(IfcGraph graph, StepInstance lineData)
        : base(graph, lineData) { }
}
