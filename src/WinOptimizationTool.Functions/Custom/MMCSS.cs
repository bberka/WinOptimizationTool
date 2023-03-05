namespace WinOptimizationTool.Functions.Custom;

public class MMCSS : BaseFunction
{

    public static IReadOnlyCollection<Result> Apply()
    {
        return new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile","SystemResponsiveness", 00000000),
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile","NetworkThrottlingIndex", Convert.ToInt32("0xffffffff", 16)),
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Affinity", 00000000),
            RegHelper.SetString(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Background Only", "False"),
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Clock Rate", 00002710),
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 00000008),
            RegHelper.SetDword(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 00000006),
            RegHelper.SetString(RegistryHive.LocalMachine,"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High"),

        };
    }

    public static IReadOnlyCollection<Result> Revert()
    {
        throw new NotImplementedException();
    }
}