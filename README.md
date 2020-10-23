# QuickNoodle
Quickly apply basic Noodle Extension modifiers for sections of a map.
# Note
This does not add "Noodle Extensions" to the list of requirements, while it is a requirement, so you have to do that yourself.
# Documentation
Please forgive my terrible syntaxes 
## Colors
#### B: value of Blue Notes and Lighting Events. (ex: B=0,128,255 OR B=#0080ff*) (float. with a range 0-255 OR #00000-#ffffff*) (can applied using a bookmark)
#### R: value of Red Notes and Lighting Events. (ex: B=255,128,0 OR B=#ff8000*) (float. with a range 0-255 OR #00000-#ffffff*) (can applied using a bookmark)
#### BN: the same syntax as [B] or [R] but Specifically for Blue Notes (will not chromatise Blue Lights) (can applied using a bookmark)
#### RN: the same syntax as [B] or [R] but Specifically for Red Notes (will not chromatise Red Lights) (can applied using a bookmark)
#### BL: the same syntax as [B] or [R] but Specifically for Blue Lights (will not chromatise Blue Notes) (can applied using a bookmark)
#### RL: the same syntax as [B] or [R] but Specifically for Red Lights (will not chromatise Red Notes) (can applied using a bookmark)
### Note:
#### BN, RN, BL, and RL will override B and R.
#### * not implemented yet.
#### Syntax is capitalisation frendly.
## Misc
#### NJS: Note Jump Speed of the notes bombs, and walls.<br>
#### Offset: spawn offset for notes, bombs, and walls. (Ex: offset=0.1) (float)<br>
#### WorldRotation: rotation and movement direction of notes, walls and bombs (like how 360 maps look). (Ex: WorldRotation=0,90,0) (float of any x,y,z coordinates between 0-360)>
#### NoteRotation: rotatates the look direction of a note (like making the note look towards the left) (Ex: NoteRotation=0,0,10) (float of any x,y,z coordinates between 0-360) 
#### standard: skips placing any custom data for that bookmark until the next one (bool: default is false) (Ex: normal=true)<br>

## Examples
#### R=150,40,200 nB=20,75,200 NoteRotation=0,0,10 WorldRotation=0,90,0 njs=25 offset=0.1
#### r=20,10,10 b=100,120,255


# Usage
Open QuickNoodle, click "Open" and select your map file with bookmarks. <i>thats it!</i>. <br>
now save your file wherever you want.

# Help
idk what to put here but if youre having issues dm me on discord shobie#1577
# Soon™
- [x] 1-255 RGB Color support
- [ ] Move Away from bookmarks to QUN files
- [ ] Support for hex colors
- [ ] Add wall colors, njs, offset (this is really easy just not a priority)
- [ ] Animation (big task)
