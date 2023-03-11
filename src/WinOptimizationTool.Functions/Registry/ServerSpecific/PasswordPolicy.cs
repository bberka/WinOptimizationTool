namespace WinOptimizationTool.Functions.Registry.ServerSpecific;

public class PasswordPolicy : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$tmpfile = New-TemporaryFile"),
			Result.MultipleErrors("Not Implemented","secedit /export /cfg $tmpfile /quiet"),
			Result.MultipleErrors("Not Implemented","(Get-Content $tmpfile).Replace(\"PasswordComplexity = 1\", \"PasswordComplexity = 0\").Replace(\"MaximumPasswordAge = 42\", \"MaximumPasswordAge = -1\") | Out-File $tmpfile"),
			Result.MultipleErrors("Not Implemented","secedit /configure /db \"$env:SYSTEMROOT\\security\\database\\local.sdb\" /cfg $tmpfile /areas SECURITYPOLICY | Out-Null"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path $tmpfile"),
		};
		return list.ToSingleResult("DisablePasswordPolicy");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$tmpfile = New-TemporaryFile"),
			Result.MultipleErrors("Not Implemented","secedit /export /cfg $tmpfile /quiet"),
			Result.MultipleErrors("Not Implemented","(Get-Content $tmpfile).Replace(\"PasswordComplexity = 0\", \"PasswordComplexity = 1\").Replace(\"MaximumPasswordAge = -1\", \"MaximumPasswordAge = 42\") | Out-File $tmpfile"),
			Result.MultipleErrors("Not Implemented","secedit /configure /db \"$env:SYSTEMROOT\\security\\database\\local.sdb\" /cfg $tmpfile /areas SECURITYPOLICY | Out-Null"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path $tmpfile"),
		};
		return list.ToSingleResult("EnablePasswordPolicy");
	}
}
