# QuickNoodle
Quickly apply basic Noodle Extension modifiers for sections of a map.

# Documentation
<br>
B: value of blue notes and lighting events. (ex: B=1.0,0.2,0.4) (float with a range 0-1. 255 would = 1.0 and 0 would = 0.0) <br>
  - planned future support for hex color codes, and also rgb values.<br>
<br>
R: value of red notes and lighting events. (ex: R=0.1,0.2,0.8) (float with a range 0-1. 255 would = 1.0 and 0 would = 0.0) <br>
  - planned future support for hex color codes, and also rgb values.<br>
<br>
NJS: NJS of the notes bombs, and walls. (ex: njs=25) (float. will change the offset like normal. ex: a 250 bpm map with a custom njs of 10 will make the notes spawn at a distance of 19 away from the player. you are going to want to add custom offset to compinsate for that.)<br>
<br>
offset: spawn offset for notes, bombs, and walls. (Ex: offset=0.1) (float)<br>
<br>
WorldRotation: rotation and movement direction of notes, walls and bombs (like how 360 maps look). (Ex: WorldRotation=0,90,0) (float of any x,y,z coordinates between 0-360)<br>
<br>
NoteRotation: rotatates the look direction of a note (like making the note look towards the left) (Ex: NoteRotation=0,0,10) (float of any x,y,z coordinates between 0-360) <br>
<br>
standard: skips placing any custom data for that bookmark until the next one (bool: default is false) (Ex: normal=true)<br>
<br>
<br>
Full bookmark example: R=0.1,0.2,0.9 NoteRotation=0,0,10 WorldRotation=0,90,0 njs=25 offset=0.1<br>
<br>
Syntax is capitalisation frendly.

# Build yourself
use vs 2017<br>
it requires newtonsoft.json <br>
build it <br>
