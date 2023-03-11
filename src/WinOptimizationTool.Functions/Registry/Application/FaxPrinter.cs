namespace WinOptimizationTool.Functions.Registry.Application;

public class FaxPrinter : BaseFunction
{
	public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Remove-Printer -Name \"Fax\" -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("RemoveFaxPrinter");
	}
	public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Add-Printer -Name \"Fax\" -DriverName \"Microsoft Shared Fax Driver\" -PortName \"SHRFAX:\" -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("AddFaxPrinter");
	}
}
