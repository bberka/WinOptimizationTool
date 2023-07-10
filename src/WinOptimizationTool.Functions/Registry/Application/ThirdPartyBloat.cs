namespace WinOptimizationTool.Functions.Registry.Application;

public class ThirdPartyBloat : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"2414FC7A.Viber\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"41038Axilesoft.ACGMediaPlayer\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"46928bounde.EclipseManager\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"4DF9E0F8.Netflix\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"64885BlueEdge.OneCalendar\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"7EE7776C.LinkedInforWindows\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"828B5831.HiddenCityMysteryofShadows\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"89006A2E.AutodeskSketchBook\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"9E2F88E3.Twitter\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"A278AB0D.DisneyMagicKingdoms\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"A278AB0D.DragonManiaLegends\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"A278AB0D.MarchofEmpires\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"ActiproSoftwareLLC.562882FEEB491\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"AD2F1837.GettingStartedwithWindows8\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"AD2F1837.HPJumpStart\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"AD2F1837.HPRegistration\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"AdobeSystemsIncorporated.AdobePhotoshopExpress\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Amazon.com.Amazon\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"C27EB4BA.DropboxOEM\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"CAF9E577.Plex\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"CyberLinkCorp.hs.PowerMediaPlayer14forHPConsumerPC\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"D52A8D61.FarmVille2CountryEscape\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"D5EA27B7.Duolingo-LearnLanguagesforFree\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"DB6EA5DB.CyberLinkMediaSuiteEssentials\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"DolbyLaboratories.DolbyAccess\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Drawboard.DrawboardPDF\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Facebook.Facebook\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Fitbit.FitbitCoach\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"flaregamesGmbH.RoyalRevolt2\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"GAMELOFTSA.Asphalt8Airborne\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"KeeperSecurityInc.Keeper\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"king.com.BubbleWitch3Saga\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"king.com.CandyCrushFriends\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"king.com.CandyCrushSaga\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"king.com.CandyCrushSodaSaga\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"king.com.FarmHeroesSaga\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Nordcurrent.CookingFever\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"PandoraMediaInc.29680B314EFC2\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"PricelinePartnerNetwork.Booking.comBigsavingsonhot\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"SpotifyAB.SpotifyMusic\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"ThumbmunkeysLtd.PhototasticCollage\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"WinZipComputing.WinZipUniversal\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"XINGAG.XING\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
		};
		return list.CombineAll("InstallThirdPartyBloat");
	}
}
