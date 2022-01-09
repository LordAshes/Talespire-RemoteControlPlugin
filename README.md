# Remote Control Plugin

This unofficial TaleSpire allows players toi move their minis in a Talespire game without having Talespire. 

Video Demo: https://youtu.be/aLRPOsEqA0s

This plugin, like all others, is free but if you want to donate, use: http://198.91.243.185/TalespireDonate/Donate.php

## Change Log

```
1.0.0: Initial release
```

## Install

Use R2ModMan or similar installer to install this plugin.

Use R2ModMan to configure optional settings (port) for the plugin.

## Usage

This plugin does not provide any way for the players to see the Talespire environment. Typically to get around this
the GM would stream a Talespire view for the players. Check out the Stream Views Plugin for the ability to stream
different views for the players while still maintaining the GM account view as secret.

Once this is done, the players can launch the Remote Control App. Currently this is a simple Win Forms app.

The player enters the IP address of the GM's machine (that the GM provides to the players) and the port. The default
port is 11000 but can be changed using the R2ModMan configuration for the Remote Control Plugin (i.e. the Talespire
component run by the GM).

The player then enters the mini name that they wish to control. Typically this would be the name of their own mini.

After that the player can press the directional buttons on the Remote Control App in order to move his/her mini.

The RemoteControlApp.exe can be found in the plugins install directory.
