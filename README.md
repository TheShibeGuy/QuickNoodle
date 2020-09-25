# QuickNoodle
Quickly apply basic Noodle Extension modifiers for sections of a map.

# Syntax
Bookmark format
B: red value of notes and lighting events. (ex: B=1.0,0.2,0.4) (float[] range 0-1) -- planned future support for hex color codes, and also rgb values.
R: blue value of notes and lighting events. (ex: R=0.1,0.2,0.8) (float[] range 0-1)

NJS: NJS of the notes bombs, walls, (float) 
offset: Note spawn offset (float)

WorldRotation: rotation of notes walls and bombs (like how 360 maps look.) (float[]) (ex: WorldRotation=0,90,0)
NoteRotation: localrotation of a note, (float[])

standard: resets objects to normal values (bool: default is false)

Full bookmark example: 
r=0.1,0.2,0.9 noteRotation=0,0,10 WorldRotation=0,90,0 njs=25 offset=0.1 

# Build yourself
use vs 2017
it requires newtonsoft.json 
build it 
