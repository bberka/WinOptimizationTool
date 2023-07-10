namespace WinOptimizationTool.Functions.Registry.ServerSpecific;

public class PasswordPolicy : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$tmpfile = New-TemporaryFile"),
			Result.Error("Not Implemented","secedit /export /cfg $tmpfile /quiet"),
			Result.Error("Not Implemented","(Get-Content $tmpfile).Replace(\"PasswordComplexity = 1\", \"PasswordComplexity = 0\").Replace(\"MaximumPasswordAge = 42\", \"MaximumPasswordAge = -1\") | Out-File $tmpfile"),
			Result.Error("Not Implemented","secedit /configure /db \"$env:SYSTEMROOT\\security\\database\\local.sdb\" /cfg $tmpfile /areas SECURITYPOLICY | Out-Null"),
			Result.Error("Not Implemented","Remove-Item -Path $tmpfile"),
		};
		return list.CombineAll("DisablePasswordPolicy");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$tmpfile = New-TemporaryFile"),
			Result.Error("Not Implemented","secedit /export /cfg $tmpfile /quiet"),
			Result.Error("Not Implemented","(Get-Content $tmpfile).Replace(\"PasswordComplexity = 0\", \"PasswordComplexity = 1\").Replace(\"MaximumPasswordAge = -1\", \"MaximumPasswordAge = 42\") | Out-File $tmpfile"),
			Result.Error("Not Implemented","secedit /configure /db \"$env:SYSTEMROOT\\security\\database\\local.sdb\" /cfg $tmpfile /areas SECURITYPOLICY | Out-Null"),
			Result.Error("Not Implemented","Remove-Item -Path $tmpfile"),
		};
		return list.CombineAll("EnablePasswordPolicy");
	}
}
