# Remote Control Plugin

This unofficial TaleSpire allows players toi move their minis in a Talespire game without having Talespire. 

Video Demo: https://youtu.be/aLRPOsEqA0s

This plugin, like all others, is free but if you want to donate, use: http://198.91.243.185/TalespireDonate/Donate.php

## Change Log

```
1.2.0: Added chat feature speaking as the indicated character or GM (if character name is GM).
       This function allows use of chat services such as Chat Roll if installed.
1.1.0: Updated Remote Control App and plugin to support rotation and camera operations.
1.0.0: Initial release
```

## Install

Use R2ModMan or similar installer to install this plugin.

Use R2ModMan to configure optional settings (port) for the plugin.

## Usage

This plugin does not provide any way for the players to see the Talespire environment. Typically to get around this
the GM would stream a Talespire view for the players. Check out the Stream Views Plugin for the ability to stream
different views for the players while still maintaining the GM account view as secret.

To prevent the Remote Controls from controlling both the Player and GM instances of Talespire, the Remote Control
Server is started manually by keyboard shortcut (default RCTRL+C). It should be started on the Player instance but
not the GM (to prevent players from controlling the GM camera).

Once this is done, the players can launch the Remote Control App. Currently this is a simple Win Forms app.

The player enters the IP address of the GM's machine (that the GM provides to the players) and the port. The default
port is 11000 but can be changed using the R2ModMan configuration for the Remote Control Plugin (i.e. the Talespire
component run by the GM).

The player then enters the mini name that they wish to control. Typically this would be the name of their own mini.

After that the player can press the directional buttons on the Remote Control App in order to move his/her mini,
rotate his/her mini, move the camera, and/or rotate the camwera.

Settings on the remote are provided to determine how much each button press moves, how much each button press rotates,
and if the mini is to change facing whem moving.

The RemoteControlApp.exe can be found in the plugins install directory.

### Chat Function

When using the Chat function, by default, the content will be spoken by the character whose name is in the Remote
Control and the results are also written to the log. If the character name is changed to GM on the Remote Control,
the message will be sent as the local player (GM or not) and will show up in the chat.

If any Chat Service plugins are installed (such as Chat Roll), the chat content will be processed through these
Chat Service plugin. For example, if the Chat Roll plugin is installed, the Remote Control Chat function can be used
to make Chat Roll requests. 

## Limitations

1. The Remote Control App has no permission checking. You can use it to control any mini that you know the name of.
2. The control over the camera is shared between all remotes, thus two or more players can be fighting for control.
