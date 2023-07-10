namespace WinOptimizationTool.Functions.Registry.Application;

public class FaxPrinter : BaseFunction
{
    [NotImplemented]
    public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Remove-Printer -Name \"Fax\" -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("RemoveFaxPrinter");
	}
    [NotImplemented]
    public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Add-Printer -Name \"Fax\" -DriverName \"Microsoft Shared Fax Driver\" -PortName \"SHRFAX:\" -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("AddFaxPrinter");
	}
}
