// See https://aka.ms/new-console-template for more information

using WinOptimizationTool.Reader;

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Explorer UI.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Explorer UI.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Application.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Application.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Network.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Network.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Privacy.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Privacy.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Security.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Security.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Server Specific.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Server Specific.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Service.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Service.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\UI Tweaks.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\UI Tweaks.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\Unpinning.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\Unpinning.cs");

_ = new FileParser(
	@"C:\Users\kkass\OneDrive\Masaüstü\script\UWP Privacy.psm1",
	@"C:\Users\kkass\OneDrive\Masaüstü\script\out\UWP Privacy.cs");

Console.WriteLine("Hello, World!");
