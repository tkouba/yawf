﻿# yawf - Yet Another Weather Forecast

Weather forecast application in .Net MAUI. Simple .Net MAUI course in czech language.

## [Lekce 1](https://github.com/tkouba/yawf/tree/L1) - Vytvoření aplikace

1. Založíme si projekt z šablony .Net MAUI
2. Aktualizujeme včechny balíčky
3. Smažeme z `MainPage.xaml.cs` předka. Ten je určený v XAML definici stránky a není nutné jej duplikovat.
```csharp
public partial class MainPage
```
4. Smažeme z `MainPage.xaml` tlačítko. Můžeme vlastně nechat jen ` <ScrollView>` všechno ostatní budeme přidávat znovu.
5. Smažeme z `MainPage.xaml.cs` kód pro obsluhu tlačítka. Necháme v `MainPage` jen
```csharp
public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
```
6. Vytvoříme adresáře Views a ViewModels a přesunout do Views MainPage
    Pozn: U větších projektů je struktura Views/Pages a ViewModels/Pages, protože view může být nejen stránka. A může být i rozdělení na oblasti.
7. Vytvoříme společného předka pro všechny naše view modely `BaseViewModel`
8. Vztvoříme potomka `MainViewModel` pro naši hlavní obrazovku.
9. Nastavíme Android práva (podle
https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/geolocation?view=net-maui-9.0&tabs=android#get-started). Tedy přidáme do `MainApplication.cs` toto
```csharp
[assembly: UsesPermission(Android.Manifest.Permission.AccessCoarseLocation)]
[assembly: UsesPermission(Android.Manifest.Permission.AccessFineLocation)]
[assembly: UsesFeature("android.hardware.location", Required = false)]
[assembly: UsesFeature("android.hardware.location.gps", Required = false)]
[assembly: UsesFeature("android.hardware.location.network", Required = false)]
```
10. Do `MainViewModel` přidáme property a command
11. Do `MainPage` přidáme `RefreshView` a doplníme textová pole s aktuální polohou. Tedy základní funkcionalitu pro určení místa, pro které chceme předpověd počasí.


