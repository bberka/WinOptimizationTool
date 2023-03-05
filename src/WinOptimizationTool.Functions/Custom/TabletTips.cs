namespace WinOptimizationTool.Functions.Custom;

public class TabletTips : BaseFunction
{
    public IReadOnlyCollection<Result> Enable()
    {
        throw new NotImplementedException();
    }
    public IReadOnlyCollection<Result> Disable()
    {
        throw new NotImplementedException();
        var regTabletTip = RegHelper.CreateCurrentUser("Software\\Microsoft\\TabletTip\\1.7");
        regTabletTip.SetDword("EnableAutocorrection", 0);
        regTabletTip.SetDword("EnableSpellchecking", 0);
        regTabletTip.SetDword("EnableTextPrediction", 0);
        regTabletTip.SetDword("EnablePredictionSpaceInsertion", 0);
        regTabletTip.SetDword("EnableDoubleTapSpace", 0);
        regTabletTip.SetDword("EnableInkingWithTouch", 0);
        var regPenWorkspace = RegHelper.CreateCurrentUser("Software\\Microsoft\\Windows\\CurrentVersion\\PenWorkspace");
        regPenWorkspace.SetDword("PenWorkspaceAppSuggestionsEnabled", 0);
    }
   
}