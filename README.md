# yawf - Yet Another Weather Forecast

Weather forecast application in .Net MAUI. Simple .Net MAUI course in czech language.

## Lekce 1 - Vytvo�en� aplikace

1. Zalo��me si projekt z �ablony .Net MAUI
2. Aktualizujeme v�echny bal��ky
3. Sma�eme z `MainPage.xaml.cs` p�edka. Ten je ur�en� v XAML definici str�nky a nen� nutn� jej duplikovat.
```csharp
public partial class MainPage
```
4. Sma�eme z `MainPage.xaml` tla��tko. M��eme vlastn� nechat jen ` <ScrollView>` v�echno ostatn� budeme p�id�vat znovu.
5. Sma�eme z `MainPage.xaml.cs` k�d pro obsluhu tla��tka. Nech�me v `MainPage` jen
```csharp
public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
```
6. Vytvo��me adres��e Views a ViewModels a p�esunout do Views MainPage
    Pozn: U v�t��ch projekt� je struktura Views/Pages a ViewModels/Pages, proto�e view m��e b�t nejen str�nka. A m��e b�t i rozd�len� na oblasti.
7. Vytvo��me spole�n�ho p�edka pro v�echny na�e view modely `BaseViewModel`
8. Vztvo��me potomka `MainViewModel` pro na�i hlavn� obrazovku.
9. Nastav�me Android pr�va (podle
https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/geolocation?view=net-maui-9.0&tabs=android#get-started). Tedy p�id�me do `MainApplication.cs` toto
```csharp
[assembly: UsesPermission(Android.Manifest.Permission.AccessCoarseLocation)]
[assembly: UsesPermission(Android.Manifest.Permission.AccessFineLocation)]
[assembly: UsesFeature("android.hardware.location", Required = false)]
[assembly: UsesFeature("android.hardware.location.gps", Required = false)]
[assembly: UsesFeature("android.hardware.location.network", Required = false)]
```
10. Do `MainViewModel` p�id�me property a command
11. Do `MainPage` p�id�me `RefreshView` a dopln�me textov� pole s aktu�ln� polohou. Tedy z�kladn� funkcionalitu pro ur�en� m�sta, pro kter� chceme p�edpov�d po�as�.


