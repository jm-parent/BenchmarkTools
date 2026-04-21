# BenchmarkTools — MauiDevFlow Agent Guide

## Installation

### CLI Tool
```bash
# Nouveau CLI unifié (dotnet/maui-labs)
dotnet tool install -g Microsoft.Maui.Cli --prerelease

# Ou ancien CLI archivé (Redth/MauiDevFlow)
dotnet tool install -g Redth.MauiDevFlow.CLI
```

## Lancer l'application
```bash
dotnet build -t:Run -f net10.0-windows10.0.19041.0 -p:WindowsPackageType=None -p:Configuration=Debug BMTApps/BenchmarkTools/BenchmarkTools.csproj
```

## Commandes DevFlow

### Visual Tree
```bash
maui devflow ui tree
# Ou ancien CLI:
maui-devflow MAUI tree
```

### Screenshot
```bash
maui devflow ui screenshot -o screenshot.png
```

### Tap un élément
```bash
maui devflow ui tap --automationid CounterButton
```

### Navigation Shell
```bash
maui devflow ui navigate --route //home/HomePage
```

### Status agent
```bash
maui devflow agent status
```

## AutomationIds disponibles

| Page | AutomationId | Type |
|------|-------------|------|
| Home | `CounterButton` | Button |
| Home | `CounterLabel` | Label |
| Dashboard | `DashboardRefreshButton` | Button |
| Dashboard | `DashboardClicksLabel` | Label |
| About | `AboutAppNameLabel` | Label |
| About | `AboutVersionLabel` | Label |
| About | `AboutDescriptionLabel` | Label |
| Settings | `SettingsThemePicker` | Picker |
| Settings | `SettingsApplyThemeButton` | Button |

## Shell Routes

| Route | Page |
|-------|------|
| `//home/HomePage` | HomePage |
| `//dashboard/DashboardPage` | DashboardPage |
| `//about/AboutPage` | AboutPage |
| `//settings/SettingsPage` | SettingsPage |
