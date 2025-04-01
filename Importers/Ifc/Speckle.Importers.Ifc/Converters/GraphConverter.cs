using Speckle.Importers.Ifc.Ara3D.IfcParser;
using Speckle.Importers.Ifc.Services;
using Speckle.Importers.Ifc.Types;
using Speckle.InterfaceGenerator;
using Speckle.Sdk.Models;

namespace Speckle.Importers.Ifc.Converters;

[GenerateAutoInterface]
public sealed class GraphConverter(INodeConverter nodeConverter, IRenderMaterialProxyManager proxyManager)
  : IGraphConverter
{
  public Base Convert(IfcModel model, IfcGraph graph)
  {
    var collection = new Collection();
    var children = graph.GetPublishedSources().Select(x => nodeConverter.Convert(model, x)).ToList();
    collection.elements = children;
    return collection;
    Base rootCollection = nodeConverter.Convert(model, graph.GetIfcProject());

    //Grabing materials from ProxyManager
    rootCollection["renderMaterialProxies"] = proxyManager.RenderMaterialProxies.Values.ToList();

    return rootCollection;
  }
}
