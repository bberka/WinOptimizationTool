namespace WinOptimizationTool.Functions.Registry.Application;

public class FaxPrinter : BaseFunction
{
    [NotImplemented]
    public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Remove-Printer -Name \"Fax\" -ErrorAction SilentlyContinue"),
		};
		return list.Combine(true,"RemoveFaxPrinter");
	}
    [NotImplemented]
    public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Add-Printer -Name \"Fax\" -DriverName \"Microsoft Shared Fax Driver\" -PortName \"SHRFAX:\" -ErrorAction SilentlyContinue"),
		};
		return list.Combine(true,"AddFaxPrinter");
	}
}
