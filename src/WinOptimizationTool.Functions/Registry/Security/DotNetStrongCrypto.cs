namespace WinOptimizationTool.Functions.Registry.Security;

public class DotNetStrongCrypto : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Write-output \"Enabling .NET strong cryptography...\""),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\.NETFramework\v4.0.30319","SchUseStrongCrypto",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\.NETFramework\v4.0.30319","SchUseStrongCrypto",1),
		};
		return list.ToSingleResult("EnableDotNetStrongCrypto");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Write-output \"Disabling .NET strong cryptography...\""),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\.NETFramework\v4.0.30319", "SchUseStrongCrypto"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Wow6432Node\Microsoft\.NETFramework\v4.0.30319", "SchUseStrongCrypto"),
		};
		return list.ToSingleResult("DisableDotNetStrongCrypto");
	}
}
