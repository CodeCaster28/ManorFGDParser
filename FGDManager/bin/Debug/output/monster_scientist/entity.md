---
title: monster_scientist
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity_Description_here</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Set custom render FX effect. Only works when "Render Mode" is set to different 'Normal'
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Default rendering.</li>
<li><b>1</b> : Slow Pulse : Transparency slow fading in and out in a loop.</li>
<li><b>2</b> : Fast Pulse : Transparency fast fading in and out in a loop.</li>
<li><b>3</b> : Slow Wide Pulse : Transparency slow fading in and out widely in a loop.</li>
<li><b>4</b> : Fast Wide Pulse : Transparency fast fading in and out widely in a loop.</li>
<li><b>9</b> : Slow Strobe : Regular slow appearing/dissapearing.</li>
<li><b>10</b> : Fast Strobe : Regular fast appearing/dissapearing.</li>
<li><b>11</b> : Faster Strobe : Regular very fast appearing/dissapearing.</li>
<li><b>12</b> : Slow Flicker : Random slow appearing/dissapearing.</li>
<li><b>13</b> : Fast Flicker : Random fast appearing/dissapearing.</li>
<li><b>5</b> : Slow Fade Away : Not working. Fading out slowly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>6</b> : Fast Fade Away : Not working. Fading out quickly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>7</b> : Slow Become Solid : Not working. Fading in slowly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>8</b> : Fast Become Solid : Not working. Fading in quickly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>14</b> : Constant Glow : Sprites with 'Glow' render mode only. Disables sprite resizing.</li>
<li><b>15</b> : Distort : Random distortion, looped.</li>
<li><b>16</b> : Hologram (Distort + fade) : 'Random distortion' + 'Pulse' applied, looped.</li>
<li><b>17</b> : Dead Player (DONT USE!)</li>
<li><b>18</b> : Explode (Garg Like)</li>
<li><b>19</b> : Glow Shell : Applies nice animated glowing shell on model. Color can be applied. "FX Amount" manipulates glow shell size.</li>
<li><b>20</b> : ClampMinScale (Sprites)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Render mode determines how this entity is rendered.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Normal rendering. Entity will receive light, except if it is a sprite. "FX Amount" is obsolete when this is used.</li>
<li><b>1</b> : Color : Brush entities only: Instead of rendering the texture, the whole entity will appear in one color, set by "FX Color". "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque.</li>
<li><b>2</b> : Texture : Texture-only rendering. Entity will not receive light. Instead, only the texture will be rendered as is. "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque. This is used for transparent things such as windows. Tip: If you have a window separating a dark and a bright room using only one entity, you can apply a brighter glass texture to the side of the window seen from within the dark room than to the side seen from the bright room. That way, the window's brightness will look realistic from both sides, instead of from just one. Generally, darker rooms require the render amount to be lower, making the glass more transparent, or it would look illogically bright.</li>
<li><b>3</b> : Glow : Sprites only. The sprite will appear in the same size regardless of your distance to it. In addition to that, the further away you are from it, the less visible it will be. (It's only barely visible at about 500 units far away) Good for light coronas. This renders the sprite in additive mode.</li>
<li><b>4</b> : Solid : Brush entities only. All textures of the brush entity starting with '{' will have the last color of their palette (usually blue, black or purple) be rendered fully transparent. This is used for textures with see-through parts, such as grates and railings. Requires "FX Amount" to be set to a value greater than 0, commonly 255.</li>
<li><b>5</b> : Additive : Works just as the "Render Mode" 'Texture', except that the entity's appearance will be added to the background instead of forming a mean. This means, black pixels of textures will be fully transparent, while full-bright pixels are added with a factor of "FX Amount" divided by 255. This is often used for sprites indicating a glowing light, as well as for overlay func_illusionaries to give a computer texture the appearance of having many small, glowing lights, screens and whatever other elements. Render-amount of 255 makes it bright. 0 makes it invisible.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Render amount to use when other than "Render Mode" 'Normal' is used.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Used with "Render Mode" 'Color' and 'Glow' to set color. Also sets color of 'Glow Shell' "Render Mode".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classification</b></span> <kbd  class="tooltip" data-tooltip="choices">classify</kbd> :
Set the class of the spawned {{ entname }}. Think of how even though zombies and human grunts, by default, both are the players' enemies, yet have a dislike for and attack each other as well. This relation is created through the respective classes of the two entity types. For a complete table of how different classes react to each other, see [monster class relation table](https://wiki.svencoop.com/Class_Relationship_Table).
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : None</li>
<li><b>0 </b> : Object Default : Keep default classification.</li>
<li><b>1 </b> : Machine</li>
<li><b>2 </b> : Player</li>
<li><b>3 </b> : Human Passive</li>
<li><b>4 </b> : Human Military</li>
<li><b>5 </b> : Alien Military</li>
<li><b>6 </b> : Alien Passive</li>
<li><b>7 </b> : Alien Monster</li>
<li><b>8 </b> : Alien Prey</li>
<li><b>9 </b> : Alien Predator</li>
<li><b>10 </b> : Insect</li>
<li><b>11 </b> : Player Ally</li>
<li><b>12 </b> : Player Hornet/Snark</li>
<li><b>13 </b> : Alien Hornet/Snark</li>
<li><b>14 </b> : X-Race</li>
<li><b>15 </b> : X-Race: Shocktrooper/Voltigore</li>
<li><b>16 </b> : Team 1 : Use it to classify to custom team.</li>
<li><b>17 </b> : Team 2 : Use it to classify to custom team.</li>
<li><b>18 </b> : Team 3 : Use it to classify to custom team.</li>
<li><b>19 </b> : Team 4 : Use it to classify to custom team.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is not revivable</b></span> <kbd  class="tooltip" data-tooltip="choices">is_not_revivable</kbd> :
If set to 'Yes', the monster cannot be revived by player's weapon_medkit or other allied monsters.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition</b></span> <kbd  class="tooltip" data-tooltip="Choices">TriggerCondition</kbd> :
Choose trigger condition for this monster. When condition is met, the "Trigger Condition Target" is fired.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Trigger</li>
<li><b>1 </b> : See Player, Mad at Player : When enemy player is seen by monster, or player became an enemy of this monster.</li>
<li><b>2 </b> : Take Damage : When damage is taken, no matter if it's ally, enemy or trigger.</li>
<li><b>3 </b> : 50% Health Remaining : When monster health drops to 50% or below.</li>
<li><b>4 </b> : Death : When monster dies.</li>
<li><b>7 </b> : Hear World : When monster hear environmental sounds like door opening/closing or glass breaking.</li>
<li><b>8 </b> : Hear Player : When monster hear a player for the first time, his footsteps or weapons. Note that crouching makes player harder to hear, just like some quiter weapons are harder to heard by monsters. Allies might ignore hearing player when they are moving behind monster's back, but still this trigger will fire when monster saw player.</li>
<li><b>9 </b> : Hear Combat : When monster hear combat sounds like weapon shooting or explosions.</li>
<li><b>10</b> : See Player Unconditional : When monster see a player for the first time.</li>
<li><b>11</b> : See Player, Not In Combat : When monster see a player for the first time, but it's not in combat of any kind. When player attack a monster before monster even saw him, the trigger will fire.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition Target</b></span> <kbd  class="tooltip" data-tooltip="String">TriggerTarget</kbd> :
Entity to fire when the above condition becomes true.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="Choices">body</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : Random : Choice_Description_here</li>
<li><b>0 </b> : Glasses : Choice_Description_here</li>
<li><b>1 </b> : Einstein : Choice_Description_here</li>
<li><b>2 </b> : Luther : Choice_Description_here</li>
<li><b>3 </b> : Slick : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Skin</b></span> <kbd  class="tooltip" data-tooltip="choices">skin</kbd> :
Monster's model skin to use, if model have multiple skins.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : 0 : Default skin.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is Player Ally?</b></span> <kbd  class="tooltip" data-tooltip="Choices">is_player_ally</kbd> :
Set whether the spawned monster is an ally or a foe of the players. Note that keyvalue name is misleading.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Yes (Default) : Keep game defaults.</li>
<li><b>1 </b> : No : Invert relationship (e.g. monster_barney becames enemy because he is friendly by default; monster_zombie becomes friendly because he is an enemy by default e.t.c.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>In-game Name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
If set, this will overwrite the monster's default in-game name, which appears in the HUD monsterinfo, which can be enabled/disabled using the CVar 'mp_allowmonsterinfo'. You can use '
' here to perform a line-break.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Blood Color</b></span> <kbd  class="tooltip" data-tooltip="choices">bloodcolor</kbd> :
Allows you to customize the monster's blood color (or disable it).
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Monster Default</li>
<li><b>-1 </b> : No Blood</li>
<li><b>1 </b> : Red</li>
<li><b>2 </b> : Yellow</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Health</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
If set, this will overwrite the monster's default health value managed by the skill configuration.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="studio">model</kbd> :
If set, this will overwrite the monster's default model. This needs to be precached using a [custom_precache](../custom_precache) entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Min Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">minhullsize</kbd> :
If set, this will overwrite the monster's default minimum hullsize. Minimum and maximum hullsize form a solid cuboid which define the monster's collision hull. Think of them as two span-vectors originating from the monster's origin.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Max Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">maxhullsize</kbd> :
If set, this will overwrite the monster's default maximum hullsize. Minimum and maximum hullsize form a solid cuboid which define the monster's collision hull. Think of them as two span-vectors originating from the monster's origin.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Set the path to a sound replacement file for the spawned monsters. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a custom_precache point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Roaming (nodes)</b></span> <kbd  class="tooltip" data-tooltip="Choices">freeroam</kbd> :
Set whether monsters spawned by this squadmaker use nodes to freeroam and find their way or don't use nodes at all.
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Map Default : Keep game defaults.</li>
<li><b>1 </b> : Never : Disable nodes roaming.</li>
<li><b>2 </b> : Always : Enable nodes roaming.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Name</b></span> <kbd  class="tooltip" data-tooltip="string">path_name</kbd> :
Name of first "path_waypoint" to go to.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity to Guard</b></span> <kbd  class="tooltip" data-tooltip="string">guard_ent</kbd> :
If set, the monster will try to follow and protect (attack its attackers) the given entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Use Sentence</b></span> <kbd  class="tooltip" data-tooltip="String">UseSentence</kbd> :
Name of audio or sentence to play when {{ entname }} is used by player to follow. Doesn't work when "Pre-Disaster" flag is selected. Use sentence name from "default_sentences.txt" or custom sentences file (which can be added in map properties). Sound file of sentence name from default_sentences.txt. To use sound file write '+' symbol and then filename with path (e.g. if you want to set file located in "svencoop/sound/mymap/bell1.wav", type '+mymap/bell1.wav'. Remember that you need to precache this sound! To do this, place [custom_precache](../custom_precache), and in the any "sound" keyvalue write 'mymap/bell1.wav'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Un-Use Sentence</b></span> <kbd  class="tooltip" data-tooltip="String">UnUseSentence</kbd> :
Name of audio or sentence to play when {{ entname }} is used by player to stop following. Doesn't work when "Pre-Disaster" flag is selected. Use sentence name from "default_sentences.txt" or custom sentences file (which can be added in map properties). Sound file of sentence name from default_sentences.txt. To use sound file write '+' symbol and then filename with path (e.g. if you want to set file located in "svencoop/sound/mymap/bell1.wav", type '+mymap/bell1.wav'. Remember that you need to precache this sound! To do this, place [custom_precache](../custom_precache), and in the any "sound" keyvalue write 'mymap/bell1.wav'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Animation Sequence (editor)</b></span> <kbd  class="tooltip" data-tooltip="Choices">sequence</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>13 </b> : idle1 : Choice_Description_here</li>
<li><b>27 </b> : eye_wipe : Choice_Description_here</li>
<li><b>28 </b> : pull_needle : Choice_Description_here</li>
<li><b>29 </b> : return_needle : Choice_Description_here</li>
<li><b>30 </b> : give_shot : Choice_Description_here</li>
<li><b>37 </b> : lying_on_back : Choice_Description_here</li>
<li><b>38 </b> : lying_on_stomach : Choice_Description_here</li>
<li><b>39 </b> : dead_sitting : Choice_Description_here</li>
<li><b>40 </b> : dead_table1 : Choice_Description_here</li>
<li><b>41 </b> : dead_table2 : Choice_Description_here</li>
<li><b>42 </b> : dead_table3 : Choice_Description_here</li>
<li><b>47 </b> : console : Choice_Description_here</li>
<li><b>48 </b> : checktie : Choice_Description_here</li>
<li><b>49 </b> : dryhands : Choice_Description_here</li>
<li><b>50 </b> : tieshoe : Choice_Description_here</li>
<li><b>51 </b> : whiteboard : Choice_Description_here</li>
<li><b>52 </b> : studycart : Choice_Description_here</li>
<li><b>53 </b> : lean : Choice_Description_here</li>
<li><b>54 </b> : pondering : Choice_Description_here</li>
<li><b>55 </b> : pondering2 : Choice_Description_here</li>
<li><b>56 </b> : pondering3 : Choice_Description_here</li>
<li><b>57 </b> : buysoda : Choice_Description_here</li>
<li><b>61 </b> : push_button : Choice_Description_here</li>
<li><b>62 </b> : converse1 : Choice_Description_here</li>
<li><b>63 </b> : converse2 : Choice_Description_here</li>
<li><b>64 </b> : retina : Choice_Description_here</li>
<li><b>65 </b> : talkleft : Choice_Description_here</li>
<li><b>66 </b> : talkright : Choice_Description_here</li>
<li><b>67 </b> : deskidle : Choice_Description_here</li>
<li><b>68 </b> : coffee : Choice_Description_here</li>
<li><b>69 </b> : franticbutton : Choice_Description_here</li>
<li><b>71 </b> : sitlookleft : Choice_Description_here</li>
<li><b>72 </b> : sitlookright : Choice_Description_here</li>
<li><b>73 </b> : sitscared : Choice_Description_here</li>
<li><b>74 </b> : sitting2 : Choice_Description_here</li>
<li><b>75 </b> : sitting3 : Choice_Description_here</li>
<li><b>76 </b> : cprscientist : Choice_Description_here</li>
<li><b>77 </b> : cprscientistrevive : Choice_Description_here</li>
<li><b>78 </b> : cowering_in_corner : Choice_Description_here</li>
<li><b>79 </b> : sstruggleidle : Choice_Description_here</li>
<li><b>80 </b> : sstruggle : Choice_Description_here</li>
<li><b>81 </b> : headcrabbed : Choice_Description_here</li>
<li><b>82 </b> : c1a0_catwalkidle : Choice_Description_here</li>
<li><b>83 </b> : c1a0_catwalk : Choice_Description_here</li>
<li><b>84 </b> : ceiling_dangle : Choice_Description_here</li>
<li><b>85 </b> : ventpull1 : Choice_Description_here</li>
<li><b>86 </b> : ventpull2 : Choice_Description_here</li>
<li><b>87 </b> : ventpullidle1 : Choice_Description_here</li>
<li><b>88 </b> : ventpullidle2 : Choice_Description_here</li>
<li><b>89 </b> : sitidle : Choice_Description_here</li>
<li><b>90 </b> : sitstand : Choice_Description_here</li>
<li><b>91 </b> : keypad : Choice_Description_here</li>
<li><b>93 </b> : lookwindow : Choice_Description_here</li>
<li><b>94 </b> : wave : Choice_Description_here</li>
<li><b>95 </b> : pulldoor : Choice_Description_here</li>
<li><b>96 </b> : beatdoor : Choice_Description_here</li>
<li><b>97 </b> : fallingloop : Choice_Description_here</li>
<li><b>98 </b> : crawlwindow : Choice_Description_here</li>
<li><b>99 </b> : divewindow : Choice_Description_here</li>
<li><b>100 </b> : locked_door : Choice_Description_here</li>
<li><b>101 </b> : push_button2 : Choice_Description_here</li>
<li><b>102 </b> : unlock_door : Choice_Description_here</li>
<li><b>104 </b> : handrailidle : Choice_Description_here</li>
<li><b>105 </b> : handrail : Choice_Description_here</li>
<li><b>106 </b> : hanging_idle : Choice_Description_here</li>
<li><b>107 </b> : fall : Choice_Description_here</li>
<li><b>108 </b> : scientist_get_pulled : Choice_Description_here</li>
<li><b>109 </b> : hanging_idle2 : Choice_Description_here</li>
<li><b>110 </b> : fall_elevator : Choice_Description_here</li>
<li><b>111 </b> : scientist_idlewall : Choice_Description_here</li>
<li><b>112 </b> : ickyjump_sci : Choice_Description_here</li>
<li><b>113 </b> : haulscientist : Choice_Description_here</li>
<li><b>114 </b> : c1a4_wounded_idle : Choice_Description_here</li>
<li><b>115 </b> : c1a4_dying_speech : Choice_Description_here</li>
<li><b>116 </b> : tentacle_grab : Choice_Description_here</li>
<li><b>117 </b> : helicack : Choice_Description_here</li>
<li><b>118 </b> : windive : Choice_Description_here</li>
<li><b>119 </b> : scicrashidle : Choice_Description_here</li>
<li><b>120 </b> : scicrash : Choice_Description_here</li>
<li><b>121 </b> : onguard : Choice_Description_here</li>
<li><b>122 </b> : seeya : Choice_Description_here</li>
<li><b>123 </b> : rocketcrawl : Choice_Description_here</li>
<li><b>124 </b> : portal : Choice_Description_here</li>
<li><b>125 </b> : gluonshow : Choice_Description_here</li>
<li><b>127 </b> : kneel : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : WaitTillSeen : Monster will have it's AI disabled until it sees player (even if something starts attacking monster).</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Gag : Monster's idle sounds are muted at map start (until woken up).</li>
<li class="imagepadding" markdown="1"><b>4 </b> : MonsterClip : Monster is affected by func_monsterclip.</li>
<li class="imagepadding" markdown="1"><b>16</b> : Prisoner : Causes the spawned monster to be an enemy regardless of the ally setting, but it won't attack or harm you in any way.</li>
<li class="imagepadding" markdown="1"><b>128</b> : WaitForScript : If set, monster won't react to anything after being spawned until it enters a scripted sequence.</li>
<li class="imagepadding" markdown="1"><b>256</b> : Pre-Disaster : Used for monster_scientist, monster_barneys e.t.c. Prevents player from using monster as his follower.</li>
<li class="imagepadding" markdown="1"><b>512</b> : Don't Fade Corpse : Prevents corpse from disappearing. Useful when we have essential (mostly friendly) NPC whose death would make map impossible to finish. If corpse never fades players can revive dead monster.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
<li class="imagepadding" markdown="1"><b>16384</b> : No Dyn Collision : Set whether the spawned monsters will appear solid to each other and the players or not.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
