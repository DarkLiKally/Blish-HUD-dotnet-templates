# Blish HUD dotnet new templates

This is a collection of templates for the `dotnet new` command for creating new [Blish HUD](https://blishhud.com/)
modules.

Blish HUD is a modern Guild Wars 2 overlay with powerful module support.

Please read the [Module Development Guide](https://blishhud.com/docs/dev/) on the official website to get
started with creating Blish HUD modules.

## Installation

Install the templates by invoking the following command:

```bash
dotnet new --install BlishHUD.Templates
```

-- or --

When you've locally cloned this repo

```bash
dotnet pack ./Blish_HUD.TemplatePack.csproj
dotnet new --install .
```

## Default empty module

To quickly start a new Blish HUD module invoke the following command:

```bash
dotnet new blishhud-module -o MyCharacterBirthdayModule -mo CharacterBirthday -m "Character Birthdays" -p:m my.bh.characterbirthdays
```

In the shown example the parameters represent:
| Parameter | Example Value             | Description                                                                                                                           |
|-----------|---------------------------|---------------------------------------------------------------------------------------------------------------------------------------|
| -o        | MyCharacterBirthdayModule | The name of the project and also the root namespace. It can contain dots like in namespaces.                                          |
| -mo       | CharacterBirthday         | The actual name of your module without the `Module` suffix. In this example the module class will be named `CharacterBirthdayModule`. |
| -m        | "Character Birthdays"     | This is the display name of your module. This title will appear in the module manager in Blish HUD.                                   |
| -p:m      | my.bh.characterbirthdays  | This is the value for the `namespace` setting in your module manifest. This is also the unique identifier used by Blish HUD.          |

## Namespace naming suggestion

The official Blish HUD namespaces are like `bh.blishhud`. To avoid conflicts with official modules and also modules of other
module developers it is recommended to use a unique namespace pattern for your modules.

You could use a combination of your nickname, domain or anther personal identifier and some scoping path.

Exmaples:
```
yourUsername.gw2.bh.characterbirthdays
com.exmaple.domain.blish.characterbirthdays
yourUsername.module.characterbirthdays
```

## Uninstall templates

To uninstall the templates invoke the following command:

```bash
dotnet new --uninstall BlishHUD.Templates
```

-- or --

When you've locally cloned this repo

```bash
dotnet new --uninstall .
```