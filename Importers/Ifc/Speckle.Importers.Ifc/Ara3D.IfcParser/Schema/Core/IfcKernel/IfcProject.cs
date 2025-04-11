using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Ara3D.StepParser;

namespace Speckle.Importers.Ifc.Ara3D.IfcParser.Schema;

public sealed class IfcProject(IfcGraph graph, StepInstance lineData) : IfcContext(graph, lineData)
{
}
