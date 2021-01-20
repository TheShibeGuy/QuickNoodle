# QuickNoodle
Quickly apply basic Noodle Extensions and Chroma to large sections of a map.
## Note
This does not add "Noodle Extensions" to requirements or "Chroma" to recommendations/requirements to your map's info file, while those are required for it to work; you have to do that yourself.<br>
You must make sure that the syntax is correct for the entire bookmark or else it will be skipped. look in **Show Log** if you suspect your bookmark is being skipped.<br>

**Data in is broken up with spaces. ex: R=150,40,200 nB=20,75,200 NoteRotation=0,0,10 WorldRotation=0,90,0 njs=25 offset=0.1**<br>
**Syntax is capitalisation friendly.**<br>
Please forgive my terrible syntaxes<br>
# Known Bugs
Currently in alpha. Some things will just not work.<br>
Argument Editor does nothing and is a stand in currently.<br>
Preset does nothing and is a stand in too.<br>
#### Click [here](https://github.com/ShibeGuy/QuickNoodle/blob/master/AnimationDocs.md) for animation docs.
### Chroma
**All Color values can be RGB (ex: B=0,128,255) OR HexRGB (ex: B=#0080ff)<br>
**B:** Syntax of Blue Notes and Lighting Events (ex: B=20,75,200)<br>
**R:** Syntax of Red Notes and Lighting Events (ex: B=200,75,20)<br>

**All syntax below is specific to what is specified. It will not chromatize anything outside of what is specified**<br>
**NB and NR** are the syntax specific to Blue Notes and Red Notes respectively (ex: NB=20,75,200)<br>
**LB and LR** are the syntax specific to Blue Lights and Red Lights respectively (ex: LR=20,75,200)<br>
**WC** is the syntax specific to Walls (ex: WC=8f008f)<br>
**NB, NR, LB, and LR will override B and R.**<br>

### Custom Spins
**ringName:** you can have Small or Big here. This determines what the custom spin affects (ex: ringName=Big) (string)<br>
**Speed:** Determines how fast your spins will move (ex: Speed=2.0) (float)<br>
**Prop OR Propagation OR Delay:** higher numbers will make the rings move snappier and make the back rings more in sync with the front (ex: Delay=2.0) (float)<br>
**Length OR Rotation:** determines how far the back rings (closest to the player) will rotate in degrees (ex: Lengthy=360) (float)
**Direction:** you can have CW (clockwise) or CCW (counter-clockwise) (ex: Direction=CW) (string)<br>

### Noodle Extensions
**NJS:** Note Jump Speed of the notes bombs, and walls. (Ex: NJS=23.5) (float)<br>
**Offset:** spawn offset for notes, bombs, and walls. (Ex: offset=0.1) (float)<br>

**WorldRotation:** rotation and movement direction of notes, walls and bombs (like how 360 maps look). (Ex: WorldRotation=0,90,0) (float of any x,y,z coordinates between 0-360) (float)<br>
**NoteRotation:** rotates the look direction of a note (like making the note look towards the left) (Ex: NoteRotation=0,0,10) (float of any x,y,z coordinates between 0-360) (float)<br>
**360:** Adds a 360 rotation event  (Ex: 360=-30) (Note that because Beat Games is dumb the only supported rotations are: -60, -45, -30, -15, 15, 30, 45, 60) (int)<br>

# Usage
**Open QN and select your map file of choice.**<br>
**Has to have bookmarks of some sort or else it will be angry**<br>
**~~import .QUN/YAML file~~ (soon™)**<br>
**Click "convert"**<br>
**Wait.**<br>
**Save your file**<br>

# Help
idk what to put here but if you're having issues dm me on discord shobie#1577
# Soon™
- [x] 1-255 RGB Color support
- [x] Support for hex colors
- [x] Add wall colors. (also super easy)
- [x] Add wall njs, offset (this is really easy just not a priority)
- [ ] Add Arguments editor to QN to allow for user custom data
- [ ] Move Away from bookmarks to QUN files
- [ ] Animation (big task)
- [ ] Add Presets for animation sets
