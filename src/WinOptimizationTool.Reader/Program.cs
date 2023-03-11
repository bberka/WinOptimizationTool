// See https://aka.ms/new-console-template for more information

using EasMe.Logging;
using Microsoft.Extensions.Logging;
using WinOptimizationTool.Reader;

EasLogFactory.Configure(x =>
{
    x.ExceptionHideSensitiveInfo = false;
	x.MinimumLogLevel = LogLevel.Debug;
});
_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Explorer UI.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "ExplorerUI");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Application.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Application");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Network.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Network");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Privacy.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Privacy");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Security.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Security");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Server Specific.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "ServerSpecific");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Service.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Service");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\UI Tweaks.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "UITweaks");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Unpinning.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "Unpinning");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\UWP Privacy.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out",
    "UWPPrivacy");

Console.WriteLine("Hello, World!");
