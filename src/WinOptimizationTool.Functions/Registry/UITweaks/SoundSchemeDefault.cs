namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class SoundScheme : BaseFunction
{
	public static Result Default()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$SoundScheme = \".Default\""),
			Result.MultipleErrors("Not Implemented","Get-ChildItem -Path \"HKCU:\\AppEvents\\Schemes\\Apps\\*\\*\" | ForEach-Object {"),
			Result.MultipleErrors("Not Implemented","# If scheme keys do not exist in an event, create empty ones (similar behavior to Sound control panel)."),
			Result.MultipleErrors("Not Implemented","# Get a regular string from any possible kind of value, i.e. resolve REG_EXPAND_SZ, copy REG_SZ or empty from non-existing."),
			Result.MultipleErrors("Not Implemented","$Data = (Get-ItemProperty -Path \"$($_.PsPath)\\$($SoundScheme)\" -Name \"(Default)\" -ErrorAction SilentlyContinue).\"(Default)\""),
			Result.MultipleErrors("Not Implemented","# Replace any kind of value with a regular string (similar behavior to Sound control panel)."),
			Result.MultipleErrors("Not Implemented","# Copy data from source scheme to current."),
		};
		return list.Combine(true,"SetSoundSchemeDefault");
	}
    public static Result None()
    {
        var list = new List<Result>()
        {
            Result.MultipleErrors("Not Implemented","$SoundScheme = \".None\""),
            Result.MultipleErrors("Not Implemented","Get-ChildItem -Path \"HKCU:\\AppEvents\\Schemes\\Apps\\*\\*\" | ForEach-Object {"),
            Result.MultipleErrors("Not Implemented","# If scheme keys do not exist in an event, create empty ones (similar behavior to Sound control panel)."),
            Result.MultipleErrors("Not Implemented","# Get a regular string from any possible kind of value, i.e. resolve REG_EXPAND_SZ, copy REG_SZ or empty from non-existing."),
            Result.MultipleErrors("Not Implemented","$Data = (Get-ItemProperty -Path \"$($_.PsPath)\\$($SoundScheme)\" -Name \"(Default)\" -ErrorAction SilentlyContinue).\"(Default)\""),
            Result.MultipleErrors("Not Implemented","# Replace any kind of value with a regular string (similar behavior to Sound control panel)."),
            Result.MultipleErrors("Not Implemented","# Copy data from source scheme to current."),
        };
        return list.Combine(true,"SetSoundSchemeNone");
    }
}
