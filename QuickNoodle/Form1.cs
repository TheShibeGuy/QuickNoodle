﻿using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNoodle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dynamic mapObject;
        

        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "DAT files (*.dat)|*.dat";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        this.Text = "QuickNoodle - Open File // " + openFileDialog.FileName;
                        this.welcome.Text = "Opened file";
                        mapObject = JsonConvert.DeserializeObject(fileContent);

                        dynamic bookmarks = mapObject._customData._bookmarks;
                        if (bookmarks.Count > 0)
                        {
                            List<string> flags = parseBookmarks(bookmarks, mapObject);
                            // fancyProcessingTime(mapObject, flags);
                        }
                        else
                        {
                            MessageBox.Show("map no have bookmark :flushed:");
                        }


                    }
                }
            }



        }
        private List<string> parseBookmarks(dynamic bookmarks, dynamic map)
        {
            List<string> marks = new List<string>();
            int index = 0;
            
            foreach(dynamic bookmark in bookmarks)
            {
                int l = bookmarks.Count;
                dynamic nextMark = bookmarks[index == l-1 ? index : index + 1];
                index++;
                Console.WriteLine($"{index}st bookmark. {Environment.NewLine}");
                welcome.Text = $"Processing {index}th bookmark.";
                float time = float.Parse(bookmark._time.ToString());
                string name = bookmark._name.ToString().ToLower();
                string[] arguments = new string[] { "njs", "offset", "r", "b", "worldrotation", "noterotation", "standard" };

                string[] commands = name.Split(' ');
                List<string> parsedCommands = new List<string>();
                // {"r=0.0,0.0,0.0", "b=1.0,1.0,1.0", "offset=-0.1"}

                #region defining stuff for later use
                float[] reds = new float[3] { 4.0f, 4.0f, 4.0f };
                float[] blues = new float[3] { 4.0f, 4.0f, 4.0f };

                float[] worldRotation = new float[3] { 0.0f, 0.0f, 0.0f };
                float[] noteRotation = new float[3] { 0.0f, 0.0f, 0.0f };
                float noteSpawnOffset = -10.25f;
                float noteJumpSpeed = -1;
                bool isNull = false;
                #endregion

                foreach (string command in commands)
                {
                    // "r=0.0, 0.0, 0.0"
                    string[] fullCommand = command.Split('=');
                    // {"r", "0.0, 0.0, 0.0"}
                    bool contains = arguments.Contains(fullCommand[0]);

                    if(contains)
                    {
                        // Console.WriteLine(command);
                        string[] commandAndArgs = command.Split('=');
                        string args = commandAndArgs[1];
                        JArray array = new JArray();


                        switch (commandAndArgs[0])
                        {
                            case "r":

                                string[] red = args.Split(',');
                                if (red.Length != 3)
                                {
                                    Console.WriteLine("Red color only has one value, skipping");
                                    reds = new float[3] { 4.0f, 4.0f, 4.0f };
                                    break;
                                }


                                for (int i = 0; i < 3; i++)
                                {
                                    string flot = red[i];
                                    
                                    if (float.TryParse(flot, out float fa))
                                    {
                                        reds[i] = fa;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error whilst decoding red colors on bookmark at {time}, skipping");
                                        reds = new float[3] { 4.0f, 4.0f, 4.0f };

                                        break;
                                    }
                                    if(i == 2)
                                    {
                                        Console.WriteLine($"Red Colors: {reds[0]}, {reds[1]}, {reds[2]}");
                                    }
                                }
                                break;
                            case "b":
                                string[] blue = args.Split(',');

                                if (blue.Length != 3)
                                {
                                    Console.WriteLine("Blue color only has one value, skipping");
                                    blues = new float[3] { 4.0f, 4.0f, 4.0f };
                                    break;
                                }
                                for (int i = 0; i < 3; i++)
                                {
                                    string flot = blue[i];
                                    if (float.TryParse(flot, out float fl))
                                    {
                                        blues[i] = fl;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error whilst decoding blue color value on bookmark at {time}, skipping");
                                        blues = new float[3] { 4.0f, 4.0f, 4.0f };

                                        break;
                                    }
                                    if (i == 2)
                                    {
                                        Console.WriteLine($"Blue Colors: {blues[0]}, {blues[1]}, {blues[2]}");
                                    }
                                }
                                break;
                            case "worldrotation":
                                string[] wR = args.Split(',');

                                if (wR.Length != 3)
                                {
                                    Console.WriteLine("World Rotation only has one value, skipping");
                                    worldRotation = new float[3] { 0.0f, 0.0f, 0.0f };
                                    break;
                                }
                                for (int i = 0; i < 3; i++)
                                {
                                    string flot = wR[i];
                                    if (float.TryParse(flot, out float fl))
                                    {
                                        worldRotation[i] = fl;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error whilst decoding worldrotation value on bookmark at {time}, skipping");
                                        worldRotation = new float[3] { 0.0f, 0.0f, 0.0f };

                                        break;
                                    }
                                    if (i == 2)
                                    {
                                        Console.WriteLine($"WorldRotation: {worldRotation[0]}, {worldRotation[1]}, {worldRotation[2]}");
                                    }
                                }
                                break;
                                
                            case "noterotation":
                                string[] nR = args.Split(',');

                                if (nR.Length != 3)
                                {
                                    Console.WriteLine("NoteRotation only has one value, skipping");
                                    noteRotation = new float[3] { 0.0f, 0.0f, 0.0f };
                                    break;
                                }
                                for (int i = 0; i < 3; i++)
                                {
                                    string flot = nR[i];
                                    if (float.TryParse(flot, out float fl))
                                    {
                                        noteRotation[i] = fl;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error whilst decoding noterotation value on bookmark at {time}, skipping");
                                        noteRotation = new float[3] { 0.0f, 0.0f, 0.0f };

                                        break;
                                    }
                                    if (i == 2)
                                    {
                                        Console.WriteLine($"NoteRotation: {noteRotation[0]}, {noteRotation[1]}, {noteRotation[2]}");
                                    }
                                }
                                break;

                            case "standard":
                                isNull = true;
                                Console.WriteLine($"isNull: true ");
                                break;
                            case "njs":
                                float f;
                                if (float.TryParse(args, out f))
                                {
                                    noteJumpSpeed = f;
                                    Console.WriteLine($"NJS: {f}");
                                }
                                else
                                {
                                    Console.WriteLine($"Error whilst decoding NJS on bookmark at {time}, skipping.");
                                    break;
                                }
                                    break;
                            case "offset":
                                float flo;
                                if (float.TryParse(args, out flo))
                                {
                                    noteSpawnOffset = flo;
                                    Console.WriteLine($"Offset: {flo}");
                                }
                                else
                                {
                                    Console.WriteLine($"Error whilst decoding Offset on bookmark at {time}, skipping.");
                                    break;
                                }
                                break;
                            default:
                                break;

                        }

                        welcome.Text = $"Processing {index}th bookmark";

                        
                        // ForEach(Console.WriteLine);
                        //Console.WriteLine($"Right colors: R: {blues[0].ToString()} G: {blues[1].ToString()} B: {blues[2].ToString()} ::: Left colors: R: {reds[0].ToString()} G: {reds[1].ToString()} B: {reds[2].ToString()}");
                        //Console.WriteLine($"");
                    }
                }

                newProcessing(reds, blues, worldRotation, noteRotation, noteSpawnOffset, noteJumpSpeed, isNull, time, map, nextMark);
                /*parsedCommands.ForEach(Console.WriteLine);
                parsedCommands.ForEach(delegate(string command)
                {

                });*/
            }




            return marks;
        }
        public void newProcessing(float[] reds, float[] blues, float[] worldRotation, float[] noteRotation, float noteSpawnOffset, float noteJumpSpeed, bool isNull, float time, dynamic map, dynamic next)
        {
            // Start processing data
            
            // Do the Notes
            for( int i = 0; i < map._notes.Count; i++)
            {
                    dynamic _note = map._notes[i];
                welcome.Text = $"Processing note {i}/{map._notes.Count - 1}";
                // Time of note
                float _time = _note._time;
                float _nextTime = next._time;
                // Console.WriteLine($"{_time} < {_nextTime}");
                // Console.WriteLine($"{time} < {_nextTime}");
                if(time <= _time /* if time of bookmark is less than time of note && _time < _nextTime*/)
                {
                    if (isNull)
                        continue;
                    if (!_note.ContainsKey("_customData"))
                    {
                            _note.Add(new JProperty("_customData", new JObject()));
                    }
                    /*                        {
                            new JProperty("_rotation", worldRotation),
                            new JProperty("_localRotation", noteRotation),
                            new JProperty("_noteJumpMovementSpeed", noteJumpSpeed),
                            new JProperty("_noteJumpStartBeatOffset", noteSpawnOffset),
                            new JProperty("_color", reds)
                        }
                   */
                    if (!_note._customData.ContainsKey("_rotation"))
                    {
                        _note._customData.Add(new JProperty("_rotation", worldRotation));
                    }
                    else
                    {
                        _note._customData._rotation = worldRotation;
                    }
                    if (!_note._customData.ContainsKey("_localRotation"))
                    {
                        _note._customData.Add(new JProperty("_localRotation", noteRotation));
                    }
                    else
                    {
                        _note._customData._localRotation = noteRotation;
                    }
                    if (!_note._customData.ContainsKey("_noteJumpMovementSpeed"))
                    {
                        _note._customData.Add(new JProperty("_noteJumpMovementSpeed", noteJumpSpeed));
                    }
                    else
                    {
                        _note._customData._noteJumpMovementSpeed = noteJumpSpeed;
                    }
                    if (!_note._customData.ContainsKey("_noteJumpStartBeatOffset"))
                    {
                        _note._customData.Add(new JProperty("_noteJumpStartBeatOffset", noteSpawnOffset));
                    }
                    else
                    {
                        _note._customData._noteJumpStartBeatOffset = noteSpawnOffset;
                    }
                    if (!_note._customData.ContainsKey("_color"))
                    {
                        _note._customData.Add(new JProperty("_color", reds));
                    }
                    else
                    {
                        _note._customData._color = reds;
                    }

                    // The note happens after the currently selected bookmark.
                    // type 0 is red, type 1 is blue
                    if (_note._type == 0)
                    {
                        if(reds[0] < 4)
                        {
                            _note._customData._color = new JArray(reds);
                        }
                        else
                        {
                            _note._customData.Remove("_color");
                        }
                        
                    } else if (_note._type == 1)
                    {
                        if (blues[0] < 4)
                        {
                            _note._customData._color = new JArray(blues);
                        }
                        else
                        {
                            _note._customData.Remove("_color");
                        }

                    }
                    




                    if (noteJumpSpeed > 0) { _note._customData._noteJumpMovementSpeed = noteJumpSpeed; } else { _note._customData.Remove("_noteJumpMovementSpeed"); }

                    if (noteSpawnOffset != -10.25) { _note._customData._noteJumpStartBeatOffset = noteSpawnOffset; } else { _note._customData.Remove("_noteJumpStartBeatOffset");  }


                    //Console.WriteLine(_note);


                    map._notes[i] = _note;
                }

                
            }
        }
        private List<string> parseText(String s, float time)
        {
            
            string[] converted = s.ToLower().Split(' ');


            string[] arguments = new string[] { "njs", "offset", "r", "b", "worldrotation", "noterotation", "standard"};
            
            float njs = 0.0f;
            float offset = -69420;

            float[] redColor = new float[] { 1000, 0, 0 };
            float[] blueColor = new float[] { 1000, 0, 0 };

            float[] worldRotation = new float[] { 0, 0, 0 };
            float[] noteRotation = new float[] { 0, 0, 0 };
            List<string> flags = new List<string>();
            foreach (string arg in converted)
            {
                
                string[] argument = arg.Split('=');
                int index = Array.IndexOf(arguments, argument[0]);
                if (index > -1)
                {
                    #region sex
                    /* {
	                    "_time": 100,
	                    "_data": {
		                    "njs": 24,
		                    "offset": 0.1,
		                    "colors": [{
			                    "r": 1,
			                    "g": 1,
			                    "b": 1
		                    }, {
			                    "r": 1,
			                    "g": 1,
			                    "b": 1
		                    }],
		                    "worldRotation": {
			                    "x": 0,
			                    "y": 0,
			                    "z": 0
		                    },
		                    "noteRotation": {
			                    "x": 0,
			                    "y": 0,
			                    "z": 0
		                    }
	                    }
                    }*/
#endregion
                    switch (argument[0])
                    {
                        case "njs":
                            njs = float.Parse(argument[1]);
                            break;
                        case "offset":
                            offset = float.Parse(argument[1]);
                            break;
                        case "b":
                            string[] blue = argument[1].Split(',');
                            blueColor[0] = float.Parse(blue[0]);
                            blueColor[1] = float.Parse(blue[1]);
                            blueColor[2] = float.Parse(blue[2]);
                            break;
                        case "r":
                            string[] red = argument[1].Split(',');
                            redColor[0] = float.Parse(red[0]);
                            redColor[1] = float.Parse(red[1]);
                            redColor[2] = float.Parse(red[2]);
                            break;

                        case "worldrotation":
                            string[] rotate = argument[1].Split(',');
                            worldRotation[0] = float.Parse(rotate[0]);
                            worldRotation[1] = float.Parse(rotate[1]);
                            worldRotation[2] = float.Parse(rotate[2]);
                            break;
                        case "noterotation":
                            string[] noterotate = argument[1].Split(',');
                            noteRotation[0] = float.Parse(noterotate[0]);
                            noteRotation[1] = float.Parse(noterotate[1]);
                            noteRotation[2] = float.Parse(noterotate[2]);
                            break;
                        case "standard":
                            string galf = $"{{\"_time\":{time}, \"isNull\": true}}";
                            flags.Add(galf);
                            continue;
                            
                    }
                    // Success, is in array
                    // Console.WriteLine($"{{\"r\":{blueColor[0]},\"g\":{blueColor[1]},\"b\":{blueColor[2]}}}");
                    string flag = $"{{\"_time\":{time}, \"isNull\": false, \"_data\":{{\"njs\":{njs},\"offset\":{offset},\"colors\":[{{\"r\":{redColor[0]},\"g\":{redColor[1]},\"b\":{redColor[2]}}},{{\"r\":{blueColor[0]},\"g\":{blueColor[1]},\"b\":{blueColor[2]}}}],\"worldRotation\":{{\"x\":{worldRotation[0]},\"y\":{worldRotation[1]},\"z\":{worldRotation[2]}}},\"noteRotation\":{{\"x\":{noteRotation[0]},\"y\":{noteRotation[1]},\"z\":{noteRotation[2]}}}}}}}";
                    flags.Add(flag);
                } else
                {
                    continue;
                }

            }
            /*int pos = 0;
            for (int i = 0; i < flags.Count; i += 2, pos++)
            {
                flags[pos] = flags[i];
                flags[pos] = flags[i - 1];
            }
            flags.RemoveRange(pos, flags.Count - pos);*/
            IEnumerable<string> query = flags.Where((x, i) => i % 2 == 1);
            flags = query.ToList();
            return flags;
        }
        /*private void fancyProcessingTime(dynamic map, List<String> flags)
        {
            
            welcome.Text = "Go get some coffee and wait...";
            for (int index = 0; index < flags.Count; index++)
                {
                string flag = flags[index];
                
                dynamic currentFlag = JsonConvert.DeserializeObject(flag);
                
                float _time = float.Parse(currentFlag._time.ToString());
                int i = 0;
                foreach (dynamic _note in map._notes)
                {

                    float time = float.Parse(_note._time.ToString());
                    int type = int.Parse(_note._type.ToString());

                    if (time >= _time)
                    {
                        if (bool.Parse(currentFlag.isNull.ToString()))
                        {
                            continue;
                        }
                        if(currentFlag._data.njs != 0.0f)
                        {
                            map._notes[i]._customData._noteJumpMovementSpeed = currentFlag._data.njs;
                        }
                        if(currentFlag._data.offset != -69420)
                        {
                            map._notes[i]._customData._noteJumpStartBeatOffset = currentFlag._data.offset;
                        }
                        if(currentFlag._data.colors[0].r < 2 && currentFlag._data.colors[1].r < 2)
                        {
                            switch(type)
                            {
                                case 0: // red
                                    JArray jArray = new JArray();
                                    float rR = float.Parse(currentFlag._data.colors[0].r.ToString());
                                    float rG = float.Parse(currentFlag._data.colors[0].g.ToString());
                                    float rB = float.Parse(currentFlag._data.colors[0].b.ToString());
                                    jArray.Add(rR);
                                    jArray.Add(rG);
                                    jArray.Add(rB);
                                    map._notes[i]._customData._color = jArray;
                                    break;
                                case 1: // blue
                                    jArray = new JArray();
                                    float bR = float.Parse(currentFlag._data.colors[1].r.ToString());
                                    float bG = float.Parse(currentFlag._data.colors[1].g.ToString());
                                    float bB = float.Parse(currentFlag._data.colors[1].b.ToString());
                                    jArray.Add(bR);
                                    jArray.Add(bG);
                                    jArray.Add(bB);
                                    // Console.WriteLine($"{{{bR}, {bG}, {bB}}}");
                                    map._notes[i]._customData._color = jArray;
                                    //map._notes[i]._customData._color[0] = bR;
                                    break;

                            }
                        }
                        
                        // apply facts and logic
                    }


                    i++;
                }
            };
            welcome.Text = "Done!";

            // red is _type 0, blue is _type 1, bombs type 3

        }
        */
        private void button4_Click(object sender, EventArgs e)
        {
            string[] cyan = new string[] { "My toes are hungry", "AAAAAAAAAAAAAAAAA", "Kinda quirky uwu", "I have a poop fetish", "My entire existence is pain. My body is numb.", "Minority moment", "Being gay is kinda gay", "lmao", $"karen if you're seeing this please bring the kids back {Environment.NewLine} they're my kids too", "Help im being help hostage", "SOMEBODY SCREAM", "Poob", "Schwank writes ghetto code", "Shrado is gay", "logantheobald, rank 5 in THE WORLD beat saber player", $"Pac-Man, more like Pakistan has no fucking reason to {Environment.NewLine} exist and if I had my way the US Military would go in there and {Environment.NewLine} bomb their sad mudhuts.", $"bcdill more like bckill me because my fucking mom took my xbox {Environment.NewLine} retweet if you have abusive parents", "Are you ready to become a ninja warrior... Virtual reality style", $"I assume all of the physical, psychological, and financial risks associated with the use of VR equipment including, {Environment.NewLine} but not limited to broken bones, sprained or torn ligaments, paralysis, death, or other bodily or property damage to myself, my child(ren), or to third parties.", "peeb", "Why the fuck can't I disable auto updates per game Valve? Its half my fault for updating and I'm not super mad or anything but I could pirate the game and have more functionality than I do right now.", "Hi there mr streamer can you please play the hardest map in the game, reality check through the skull, i bet it will have you sweating lmao, your arms will be so dead", "Yeah - Garsh", "Look at Mr. Five digit over here trying to prove himself. Have you know I’m rank 7821 and I could kick your sorry little butt any day of the week. I’m both a god like accuracy and challenge map player! I have a 67.45% on my favorite map Reality Check Through The Skull. (That’s a freak’n A rank buddy) The only thing holding me back from being number one is my tracking. If I used 100% of my strength my WMR controller loses connection. Also screw mappers that make maps that I can’t beat. (My favorite thing about Hex maps is the downvote button)", "Why doesn't anyone know how to map properly? Seriously, this is all starting to piss me off. It's becoming increasingly apparent to me that no matter what gets made, it's utter garbage by default. Mappers need to get off of their asses, and stop being lazy. It's time to actually wake up, and start putting actual effort into maps. I'm tired of seeing the same shit over and over, time and time again. Every map feels the same, just the same shitty patterns placed in the same shitty way, trying to get ranked status. Ranking a map is not important. What's important is getting your act together so that the maps being constantly churned out can start to have a degree of quality to them. This is ridiculous, and it needs to stop.", "Hey anybody see the time? It looks like its time to miss a couple notes. Miss. Miss. Miss. You are going to miss.", "I feel like I'm getting near my limit in Beat Saber, I feel like I haven't progressed in the last month at all and I'm still stuck on the same songs and I don't know what to do, I have the vive and I literally feel like I can't move my arms faster than I do", "Mediocre mapper is a shit head cause it wont let me set the njs, I try and I resets and It wont let me, this is the level that was supposed to be harder than nisemono chuuihou but the njs wont set thats why its so slow, I quit mapping cause of mediocre mapper, fuck squeaksies and kill me", "hello ive been having some trouble with beat saber and its getting annoying and idk what to do. i bought the game on steam and its been lagging non stop and freezing every time i lunch it and its impossible to play. i have a gtx 1060, i7 7700k and 16 gb of ddr for ram. i have a oculus rift and every other game works fine except the vr games  on steam. it has told me that its the sensors but in reality is wasn't them because again in every other game they work perfectly fine and it runs well. I saw a guy on the beat saber reddit say that his issue was a program called Citrix but when I went through the uninstaller it didn't fix the issue. please help i really want to play the game.", "Hey Bandit you CAN beat TTFAF on expert, right? Someone said you couldnt on here yet i do not believe them based on the rest of your content", "You guys seen that new chart, Volcanic? It is made by Hexagonial. Honestly, all the map is are just randomly placed notes with random flow. The only thing the map has going for it is being on beat. The song requires no skill and it is just flailing. Kind of dumb that people from the \"competitive\" beat saber community even like the song, lol. But they're used to liking trash", "Just did a full practice of the Soulless 5 collab, and I must say, the Soulless 4 collab is THE WAY to do soulless maps in beat saber. low enough njs to be sightreadable, with only a few hard parts that feel mostly justified. The Soulless 5 collab feels like it's trying to be hard, and it just feels like completely artificial difficulty. I might make a video about this actually, it would be a fun little rant/level making guide thing...", "UH OH! sorry mate, looks like you've encountered a map not quite fit for your skill level. These premises are for REAL pro players, ONLY. That's right bub, get your 4 digit ass outta here.", "god these left handed map makers are pissing me off, as a (quite frankly) superior handed individual, i feel discriminated against, as my feeble left arm is struggling to compete, with the left handed cabal that runs this fucking game...", "Listen. I'm starting to get tired of people complaining about my maps AFTER they get ranked. Can we not fucking point out issues before it's ranked? Or are you guys only fucking obligated to play a map if it's ranked, seeing all the issues only then? This happened with Daisuki, Evolution too. How about you guys play maps you fuckin' like instead of playing maps solely for PP? Thanks.", "I can't believe the amount of garbage that comes out of Hexxygonial, all of his maps flow as good as a solid shit going through a needle. I think we need to map more like how Shing Shing Shing was mapped.", "If you think this chart is an improvement, you are clearly wrong. TTFAF v2 is nothing more than a conversion into another generic chart. The original TTFAF had unique patterns and moments that the second chart could never remotely improve upon. The patterns used in parts of the original chart were interesting and had their own special twist to the usual meta cr*p. Meanwhile the new chart just uses the same stream patterns you find in every single chart, making this new chart lose any value it originally had. Additionally, the 'dot spam' provided a unique challenge that other charters refuse to add just because it doesn't fit their 'meta'. To anyone that thinks this new chart is an improvement are nothing more than conformists. If you wanna see real charts that don't conform to this dumb meta, just look at Centipede, Mr Blue Sky, and most importantly the original TTFAF chart.", "Stop ranking hexagonial maps.Awful readability, boring pattern, feels like playing one of the earliest maps. Ranked maps shouldn't be so bad", "If you think it takes 400 hours to be this good you're wrong, by the time i hit 10 hours on beat saber id already completed reality check and ttfaf, im only at 50 hours now and i can do this", "It's not my fault that you think maps are 'too hard' or 'off beat' listen there are no bad maps just bad players. I'm getting sick and tired of you nerds on reddit whining because your arms and eyes can't move at the required speed to play my perfect maps. I mean jeeze maybe just try playing better once and a while? I swear nobody appreciates real genius until years later. AND STOP COMPLAINING ITS OFF BEAT YOU ARE JUST HEARING IT WRONG", "Beat saber fan boys are the worst. I'm tired of seeing every new VR music rhythm game and some idiot giving it a negative review because it's not Beat Saber. Beat saber did not invent music rhythm in VR. Beat saber is an awesome game. But they weren't original. There was this game called Beat Ninja VR way before Beat Saber if you want to look it up. There were also plenty of other music rhythm games in VR way before Beat Saber came into the mix.  Yes, they are the gold standard. But stop comparing everything to Beat Ninja and calling it a Beat Ninja ripoff. This is a music rhythm game. Harmonix has been doing them for many many years. And also, not everyone wants to get sweaty on their VR headset. So this game is very different than Beat Saber. Saying it's a ripoff is just lazy.", "For crying out loud... some children songs are mapped on EXPERT only... have you ever seen the disappointed look on a kid trying to play his favorite song and failing in the first 10seconds? What the hell were these assholes thinking...", "They should impose a normal difficulty requirement on most songs and an easy difficulty for children songs...", "I've made a severe and continuous lapse in my judgement, and I don't expect to be forgiven, I'm simply here to apologize. So what we came across that day in the woods was obviously unplanned, and the reactions you saw on tape were raw, they were unfiltered. None of us knew how to react, or how to feel. I should have never posted the video. I should have put the cameras down and stopped recording what we were going through. There's a lot of things I should have done differently but I didn't, and for that, from the bottom of my heart, I am sorry. I want to apologize to the Internet. I want to apologize to anyone who's seen the video. I want to apologize to anyone who has been affected or touched by mental illness, or depression, or suicide, but most importantly, I want to apologize to the victim and his family. For my fans who are defending my actions, please don't. They do not deserve to be defended. The goal with my content is always to entertain, to push the boundaries, to be all inclusive in the world I live in. I share almost everything I do. The intent is never to be heartless, cruel, or malicious. Like I said, I've made a huge mistake. I don't expect to be forgiven, I'm just here to apologize. I'm ashamed of myself. I'm disappointed in myself and I promise to be better. I will be better. Thank you.", "cursor on screen", $"OrangeW2: 'shill' {Environment.NewLine}OrangeW2: that tells me everything", $"Overlord_Mills: You can’t defend this tourney. It’s not playable {Environment.NewLine} Nuketime: ^ ", "The fact that this chat is more cursed than the tracking makes me concerned", "ScoreSaber has small dick energy", "He's not being good at the game, he's decent. Tempex is better because he knows how to play and actually hits the notes fairly, plus taichi has five 360 eyes or some weird eyes because as a fact no one can see a lot of notes, idk how he beat Ghost7. ...hacks, only way. I'm not gonna look at someone that cheats, idc if he's #1 and that's based on people saying it is. And plus she gets 100+ score on every hit, that plus ghost notes and fc, ...how?since he's in Japan I think, she probably found or made some aimbot thing or hack", "The ape is the greatest animal living on this Earth, second only to man. I was asked in my health class yesterday, “if you could be any animal what animal would you be?”. I found this a novel idea to begin with. How should I judge the the animal, what merit should they be judged on and what should I prioritize in having in my animal self? Is it survivability or longevity? Then I would have to be content with life as some kind of extremophile protozoa or other single celled creature. Is it power that I should seek in my beast body? Then it is the life of a rhino or cheetah that I should seek. However, this would be the life of the hunted, as in the world of man I would be short lived due to poaching. That is not the life I wish for myself. Is my intelligence preserved or am I given the brain of the beast? If it is preserved then I would need a creature with the limbs and dexterity needed to manipulate the Earth around me. This is a trait almost exclusively found in primates.  If my intelligence is not preserved then I would need to pick something smart to maintain some semblance of my past self. This makes the obvious choice the dolphin, or once again, a chimp or primate. Taking all of this into account, the ape is the greatest decision possible. It has strength, longevity, intelligence, and the ability to manipulate the world. Were my mind to be placed into the body of a silverback gorilla, I would be unstoppable. I would be the perfect melding of mind and body, unstoppable by any conventional warfare or weapon short of a nuclear fissile weapon. Were I able to contact someone to create weapons and armor to match my incredible size and musculature, it would be the birth of a grand simian overlord the likes unseen by mortal man in fact or fiction. This is why, by all accounts both metaphysical and physical, figurative, or factual, the ape is the only choice possible for the question and the second greatest creature to ever swim, walk, or fly upon the face of this Earth or any other.", "He's not being good at the game, he's decent. Tempex is better because he knows how to play and actually hits the notes fairly, plus taichi has five 360 eyes or some weird eyes because as a fact no one can see a lot of notes, idk how he beat Ghost7. ...hacks, only way. I'm not gonna look at someone that cheats, idc if he's #1 and that's based on people saying it is. And plus she gets 100+ score on every hit, that plus ghost notes and fc, ...how?since he's in Japan I think, she probably found or made some aimbot thing or hack.", "If you can do a cross-lane double-hand jump faster than two beats per second, your environment is scaled improperly, period. That move should not be possible for a human being at all, it's mechanically impossible. Your hands would have to break the sound barrier to swing your arms like that. If your saber is longer than your arm, your environment isn't scaled properly.", "It's not a playstyle choice. Milk crown at 40% speed is an extremely difficult map. At normal speed it's physically impossible unless you're improperly scaled.", "just play a song please stop ending the song early. it is kinda annoying lol"};

            Random random = new Random();

            MessageBox.Show(cyan[random.Next(cyan.Length)]);
            //MessageBox.Show($"@*@@@,,@  @,#% , @,,,,,,,%{Environment.NewLine}      &@@.@..,,,,,,,,,,,,,,@ .,,@{Environment.NewLine}      &&.,,,,,,,,,,,,,,,,,,.  @,@{Environment.NewLine}     &@,,,,,,,,,,,,,,,,,,,,,,,,,{Environment.NewLine}      (,,,,,,,,,,,,,,,,,,,,,,,,,,@*{Environment.NewLine}     ,,%/,,,,,,,,,,,,,,,,,,,,,,,,@{Environment.NewLine}     @,,@@@@@@,,,,,@@@@@@%,,,,,,/{Environment.NewLine}     @ ,,@  @@,,   ,,,@  @@,,,,,,,,{Environment.NewLine}    .          @@@@@(  ,,,,..     .{Environment.NewLine}   ...          #@#             .@{Environment.NewLine}     ,        @%@@            .@{Environment.NewLine}       @.                     /#@{Environment.NewLine}          #,@@.         @@**,,,@{Environment.NewLine}         /,,,,,*@ (. ,,,,,,,,,,,,,%");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("The button is a lie.");
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBoxManager.No = "Ok";
            MessageBoxManager.Register();
            MessageBox.Show("Why the fuck did you click the text???", "Retard", MessageBoxButtons.YesNo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mapfile = JsonConvert.SerializeObject(mapObject);

            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "dat files (*.dat)|*.dat";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, mapfile);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        // public static bool IsNumeric(this string text) => double.TryParse(text, out _);
    }

}