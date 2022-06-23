using System.Collections.ObjectModel;

namespace PapyrusDotNet.PexInspector.ViewModels
{
    public interface IPexTreeBuilder
    {
        ObservableCollection<PapyrusViewModel> BuildPexTree(ObservableCollection<PapyrusViewModel> pexTree, out bool forceReload, PapyrusViewModel target = null);
        bool BuildPexTree(int assemblyIndex, string[] asmnames, out PapyrusViewModel root, out bool forceReload);
    }
}