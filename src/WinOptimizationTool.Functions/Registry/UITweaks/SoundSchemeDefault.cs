namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class SoundScheme : BaseFunction
{
	public static Result Default()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$SoundScheme = \".Default\""),
			Result.Error("Not Implemented","Get-ChildItem -Path \"HKCU:\\AppEvents\\Schemes\\Apps\\*\\*\" | ForEach-Object {"),
			Result.Error("Not Implemented","# If scheme keys do not exist in an event, create empty ones (similar behavior to Sound control panel)."),
			Result.Error("Not Implemented","# Get a regular string from any possible kind of value, i.e. resolve REG_EXPAND_SZ, copy REG_SZ or empty from non-existing."),
			Result.Error("Not Implemented","$Data = (Get-ItemProperty -Path \"$($_.PsPath)\\$($SoundScheme)\" -Name \"(Default)\" -ErrorAction SilentlyContinue).\"(Default)\""),
			Result.Error("Not Implemented","# Replace any kind of value with a regular string (similar behavior to Sound control panel)."),
			Result.Error("Not Implemented","# Copy data from source scheme to current."),
		};
		return list.CombineAll("SetSoundSchemeDefault");
	}
    public static Result None()
    {
        var list = new List<Result>()
        {
            Result.Error("Not Implemented","$SoundScheme = \".None\""),
            Result.Error("Not Implemented","Get-ChildItem -Path \"HKCU:\\AppEvents\\Schemes\\Apps\\*\\*\" | ForEach-Object {"),
            Result.Error("Not Implemented","# If scheme keys do not exist in an event, create empty ones (similar behavior to Sound control panel)."),
            Result.Error("Not Implemented","# Get a regular string from any possible kind of value, i.e. resolve REG_EXPAND_SZ, copy REG_SZ or empty from non-existing."),
            Result.Error("Not Implemented","$Data = (Get-ItemProperty -Path \"$($_.PsPath)\\$($SoundScheme)\" -Name \"(Default)\" -ErrorAction SilentlyContinue).\"(Default)\""),
            Result.Error("Not Implemented","# Replace any kind of value with a regular string (similar behavior to Sound control panel)."),
            Result.Error("Not Implemented","# Copy data from source scheme to current."),
        };
        return list.CombineAll("SetSoundSchemeNone");
    }
}
