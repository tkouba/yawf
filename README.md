# yawf - Yet Another Weather Forecast

Weather forecast application in .Net MAUI. Simple .Net MAUI course in czech language.

## Lekce 1 - Vytvoøení aplikace

1. Založíme si projekt z šablony .Net MAUI
2. Aktualizujeme vèechny balíèky
3. Smažeme z `MainPage.xaml.cs` pøedka. Ten je urèený v XAML definici stránky a není nutné jej duplikovat.
```csharp
public partial class MainPage
```
4. Smažeme z `MainPage.xaml` tlaèítko. Mùžeme vlastnì nechat jen ` <ScrollView>` všechno ostatní budeme pøidávat znovu.
5. Smažeme z `MainPage.xaml.cs` kód pro obsluhu tlaèítka. Necháme v `MainPage` jen
```csharp
public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
```
6. Vytvoøíme adresáøe Views a ViewModels a pøesunout do Views MainPage
    Pozn: U vìtších projektù je struktura Views/Pages a ViewModels/Pages, protože view mùže být nejen stránka. A mùže být i rozdìlení na oblasti.
7. Vytvoøíme spoleèného pøedka pro všechny naše view modely `BaseViewModel`
8. Vztvoøíme potomka `MainViewModel` pro naši hlavní obrazovku.
9. Nastavíme Android práva (podle
https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/geolocation?view=net-maui-9.0&tabs=android#get-started). Tedy pøidáme do `MainApplication.cs` toto
```csharp
[assembly: UsesPermission(Android.Manifest.Permission.AccessCoarseLocation)]
[assembly: UsesPermission(Android.Manifest.Permission.AccessFineLocation)]
[assembly: UsesFeature("android.hardware.location", Required = false)]
[assembly: UsesFeature("android.hardware.location.gps", Required = false)]
[assembly: UsesFeature("android.hardware.location.network", Required = false)]
```
10. Do `MainViewModel` pøidáme property a command
11. Do `MainPage` pøidáme `RefreshView` a doplníme textová pole s aktuální polohou. Tedy základní funkcionalitu pro urèení místa, pro které chceme pøedpovìd poèasí.


