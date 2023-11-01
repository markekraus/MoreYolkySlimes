# More Yolky Slimes

Slime Rancher 2 mod that increases (or decreases) the spawn chance of Yolky Slimes.
This mod does not add additional spawn points for Yolky Slimes.
It only adjusts the spawn chance on existing spawn points.

## Installing this mod

1. Install [Melon Loader](https://melonwiki.xyz/#/?id=automated-installation) for Slime Rancher 2
1. Download the [latest release](https://github.com/markekraus/MoreYolkySlimes/releases)
1. Copy `MoreYolkySlimes.dll` to the `Mods` folder in your Slime Rancher 2 install folder (i.e. `C:\Program Files (x86)\Steam\steamapps\common\Slime Rancher 2\Mods`)

## Configuration

The spawn chance is configurable in the `MelonPreferences.cfg` (i.e. `C:\Program Files (x86)\Steam\steamapps\common\Slime Rancher 2\UserData\MelonPreferences.cfg`).
The setting must be a valid float between 0.0 and 1.0.
The game's default setting is 0.004 and this mod uses a default of 0.05.
I don't know the specifics of how spawns rates are calculated, but it appears to be a percent chance every 12 in-game hours.

If you set this to 1.0, then every nest that can spawn Yolky Slimes will spawn one Yolky Slime every time you get near them once per in-game 12 hours.

If you set this to 0.0, then Yolky Slime spawn chances will be extremely rare.
There are some other spawn chance mechanics which may still result in Yolky Slimes spawning outside of what this mod touches.
Fully disabling the spawn chance of Yolky Slimes is not implemented in this mod, but at 0.0 the spawn rate will bo so small that it will seem like they are disabled.

At 0.05, I was able to get 3 Yolky Slimes doing a quick run through all the areas in about 30 minutes real-time.
At 0.75, they were popping out of almost every nest I passed by.

1. Launch the game once with the mod installed and then exit the game to pre-populate the configuration.
1. Open `MelonPreferences.cfg` in the text editor of your choice (e.g. `Notepad.exe`)
1. Locate the `[MoreYolkySlimes]` section
1. Change the `YolkySpawnChance` setting to a valid float between 0.0 and 1.0.

```toml
[MoreYolkySlimes]
# Percent chance (as a decimal: '5%' is '0.05') that Yolky Slimes will spawn from nests. Game default is 0.004. Mod default is 0.05
YolkySpawnChance = 0.05
```

Please note that the number in your config file may change automatically from `0.05` to something like `0.05000000074505806`.
This is part of how floating point variables work and is expected behavior.
You do not need to change it back to a simpler decimal number.

Any value above 1.0 will be treated as 1.0.
Any value below 0.0 (e.g. `-1.0`) will be treated as 0.0.

Settings for this mod are compatible other mods that can modify Melon Preferences in-game (e.g. MelonPreferencesManager).
