---
title: monster_otis
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Part of Black Mesa Security Team. Uses desert eagle for defense.<br>Class: Player Ally or Human Military when relationship is inverted.</div>
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
Set name of {{ entname }} so other entities can trigger it to activate or deactivate it. Works only with "Start Inactive" flag. Depending on trigger use-type: 'On'- enable monster, 'Off'- disable monster, 'Toggle'- toggles monster. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Some monsters can have [path_corner](../path_corner) specified as a target. On map start they will try to reach path_corner with walk animation.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Set custom render FX effect. Only works when "Render Mode" is set to different than 'Normal'
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
Choose trigger condition for this monster. When condition is met, the entity specified in "Trigger Condition Target" is triggered.
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
<li><b>8 </b> : Hear Player : When monster hear a player for the first time, his footsteps or weapons. Note that crouching makes player harder to hear, just like some quieter weapons are harder to heard by monsters. Allies might ignore hearing player when they are moving behind monster's back, but still this trigger will fire when monster saw player.</li>
<li><b>9 </b> : Hear Combat : When monster hear combat sounds like weapon shooting or explosions.</li>
<li><b>10</b> : See Player Unconditional : When monster see a player for the first time.</li>
<li><b>11</b> : See Player, Not In Combat : When monster see a player for the first time, but it's not in combat of any kind. When player attack a monster before monster even saw him, the trigger will fire.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition Target</b></span> <kbd  class="tooltip" data-tooltip="String">TriggerTarget</kbd> :
Entity to trigger when condition in "Trigger Condition Target" is met. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="choices">body</kbd> :
This will set which body to use. Body's are different submodels/appearances in model files. Think of the different scientists. Not all models do have multiple body's. '-1' means random.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : 0 : Default body.</li>
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
<li><b>1 </b> : No : Invert relationship, e.g. monster_barney becomes enemy because he is friendly by default; monster_zombie becomes friendly because he is an enemy by default e.t.c.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>In-game Name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
If set, this will overwrite the monster's default in-game name, which appears in the HUD monster info, which can be enabled/disabled using the CVar 'mp_allowmonsterinfo'. You can use '\n' here to perform a line-break.
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
Set the path to a sound replacement file for the spawned monsters. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a [custom_precache](../custom_precache) point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Roaming (nodes)</b></span> <kbd  class="tooltip" data-tooltip="Choices">freeroam</kbd> :
Set whether monsters spawned by this squadmaker use nodes to free roam and find their way or don't use nodes at all.
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
Name of first [path_waypoint](../path_waypoint) to go to.
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
<span style="color:#9fc5e8;"><b>bodystate</b></span> <kbd  class="tooltip" data-tooltip="Choices">bodystate</kbd> :
Otis body state, holstered weapon, drawn weapon or... donut!
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : Random</li>
<li><b>0 </b> : Gun Holstered</li>
<li><b>1 </b> : Gun Drawn</li>
<li><b>3 </b> : Donut</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>head</b></span> <kbd  class="tooltip" data-tooltip="Choices">head</kbd> :
This will set which head to use. Heads are different submodels/appearances in model files. Not all models do have multiple heads. '-1' means random.
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : Random</li>
<li><b>0 </b> : Bald Head</li>
<li><b>1 </b> : Head with hair</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Animation Sequence (editor)</b></span> <kbd  class="tooltip" data-tooltip="Choices">sequence</kbd> :
Change model display sequence in editor by specifying it's number.
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : idle1</li>
<li><b>19 </b> : locked_door</li>
<li><b>21 </b> : barn_Wave</li>
<li><b>22 </b> : beat_grunt</li>
<li><b>23 </b> : beat_gruntidle</li>
<li><b>24 </b> : flashlight</li>
<li><b>41 </b> : cprbarney</li>
<li><b>42 </b> : cprbarneyrevive</li>
<li><b>43 </b> : barney_dragvent</li>
<li><b>44 </b> : dying_barney</li>
<li><b>45 </b> : dying_barneyidle</li>
<li><b>46 </b> : dying_friend</li>
<li><b>47 </b> : dying_friendidle</li>
<li><b>48 </b> : c1a3_bidle</li>
<li><b>49 </b> : intropush</li>
<li><b>50 </b> : fence</li>
<li><b>51 </b> : wave</li>
<li><b>52 </b> : unlatch</li>
<li><b>53 </b> : retina</li>
<li><b>54 </b> : relaxstand</li>
<li><b>55 </b> : trackswitch</li>
<li><b>56 </b> : pepsiswing</li>
<li><b>57 </b> : pepsipush</li>
<li><b>58 </b> : buttonpush</li>
<li><b>59 </b> : cowering</li>
<li><b>60 </b> : candygrab</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">WaitTillSeen</span> : Monster will have it's AI disabled until it sees player (even if something starts attacking monster).</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Gag</span> : Monster's idle sounds are muted at map start (until woken up).</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">MonsterClip</span> : Monster is affected by [func_monsterclip](../func_monsterclip).</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">Prisoner</span> : Causes the spawned monster to be an enemy regardless of the ally setting, but it won't attack or harm you in any way.</li>
<li class="imagepadding" markdown="1"><b>128</b> : <span style="color:#9fc5e8;">WaitForScript</span> : If set, monster won't react to anything after being spawned until it enters a scripted sequence.</li>
<li class="imagepadding" markdown="1"><b>256</b> : <span style="color:#9fc5e8;">Pre-Disaster</span> : Used for monster_scientist, monster_barneys e.t.c. Prevents player from using monster as his follower.</li>
<li class="imagepadding" markdown="1"><b>512</b> : <span style="color:#9fc5e8;">Don't Fade Corpse</span> : Prevents corpse from disappearing. Useful when we have essential (mostly friendly) NPC whose death would make map impossible to finish. If corpse never fades players can revive dead monster.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
<li class="imagepadding" markdown="1"><b>16384</b> : <span style="color:#9fc5e8;">No Dyn Collision</span> : Set whether the spawned monsters will appear solid to each other and the players or not.</li>
</ul>
</div>
