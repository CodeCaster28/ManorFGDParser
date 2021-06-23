---
title: squadmaker
---

<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column">Entity_Description_here</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Slow Pulse : Choice_Description_here</li>
<li><b>2</b></span> : Fast Pulse : Choice_Description_here</li>
<li><b>3</b></span> : Slow Wide Pulse : Choice_Description_here</li>
<li><b>4</b></span> : Fast Wide Pulse : Choice_Description_here</li>
<li><b>9</b></span> : Slow Strobe : Choice_Description_here</li>
<li><b>10</b></span> : Fast Strobe : Choice_Description_here</li>
<li><b>11</b></span> : Faster Strobe : Choice_Description_here</li>
<li><b>12</b></span> : Slow Flicker : Choice_Description_here</li>
<li><b>13</b></span> : Fast Flicker : Choice_Description_here</li>
<li><b>5</b></span> : Slow Fade Away : Choice_Description_here</li>
<li><b>6</b></span> : Fast Fade Away : Choice_Description_here</li>
<li><b>7</b></span> : Slow Become Solid : Choice_Description_here</li>
<li><b>8</b></span> : Fast Become Solid : Choice_Description_here</li>
<li><b>14</b></span> : Constant Glow : Choice_Description_here</li>
<li><b>15</b></span> : Distort : Choice_Description_here</li>
<li><b>16</b></span> : Hologram (Distort + fade) : Choice_Description_here</li>
<li><b>17</b></span> : Dead Player (DONT USE!) : Choice_Description_here</li>
<li><b>18</b></span> : Explode (Garg Like) : Choice_Description_here</li>
<li><b>19</b></span> : Glow Shell : Choice_Description_here</li>
<li><b>20</b></span> : ClampMinScale (Sprites) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Color : Choice_Description_here</li>
<li><b>2</b></span> : Texture : Choice_Description_here</li>
<li><b>3</b></span> : Glow : Choice_Description_here</li>
<li><b>4</b></span> : Solid : Choice_Description_here</li>
<li><b>5</b></span> : Additive : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classification</b></span> <kbd  class="tooltip" data-tooltip="choices">classify</kbd> :
Set the class of the spawned entity. Think of how even though zombies and human grunts, by default, both are the players' enemies, yet have a dislike for and attack each other as well. This relation is created through the respective classes of the two entity types. For a complete table of how different classes react to each other, see [monster class relation table](https://wiki.svencoop.com/Class_Relationship_Table).
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b></span> : None</li>
<li><b>0 </b></span> : Object Default : Keep default classification.</li>
<li><b>1 </b></span> : Machine</li>
<li><b>2 </b></span> : Player</li>
<li><b>3 </b></span> : Human Passive</li>
<li><b>4 </b></span> : Human Military</li>
<li><b>5 </b></span> : Alien Military</li>
<li><b>6 </b></span> : Alien Passive</li>
<li><b>7 </b></span> : Alien Monster</li>
<li><b>8 </b></span> : Alien Prey</li>
<li><b>9 </b></span> : Alien Predator</li>
<li><b>10 </b></span> : Insect</li>
<li><b>11 </b></span> : Player Ally</li>
<li><b>12 </b></span> : Player Hornet/Snark</li>
<li><b>13 </b></span> : Alien Hornet/Snark</li>
<li><b>14 </b></span> : X-Race</li>
<li><b>15 </b></span> : X-Race: Shocktrooper/Voltigore</li>
<li><b>16 </b></span> : Team 1 : Use it to classify to custom team.</li>
<li><b>17 </b></span> : Team 2 : Use it to classify to custom team.</li>
<li><b>18 </b></span> : Team 3 : Use it to classify to custom team.</li>
<li><b>19 </b></span> : Team 4 : Use it to classify to custom team.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is not revivable</b></span> <kbd  class="tooltip" data-tooltip="choices">is_not_revivable</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target On Release</b></span> <kbd  class="tooltip" data-tooltip="string">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Type</b></span> <kbd  class="tooltip" data-tooltip="string">monstertype</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Childrens' Name</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster count </b></span> <kbd  class="tooltip" data-tooltip="integer">monstercount</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay between spawns</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max live children</b></span> <kbd  class="tooltip" data-tooltip="integer">m_imaxlivechildren</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Blocked Spawn Handling</b></span> <kbd  class="tooltip" data-tooltip="Choices">spawn_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Legacy, no special handling : Choice_Description_here</li>
<li><b>1 </b></span> : Block, spawn as soon as clear : Choice_Description_here</li>
<li><b>2 </b></span> : Force spawn, never block : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of Telefrag Damage</b></span> <kbd  class="tooltip" data-tooltip="integer">dmg</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>TriggerTarget</b></span> <kbd  class="tooltip" data-tooltip="String">trigger_target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition</b></span> <kbd  class="tooltip" data-tooltip="Choices">trigger_condition</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Trigger : Choice_Description_here</li>
<li><b>1 </b></span> : See Player, Mad at Player : Choice_Description_here</li>
<li><b>2 </b></span> : Take Damage : Choice_Description_here</li>
<li><b>3 </b></span> : 50% Health Remaining : Choice_Description_here</li>
<li><b>4 </b></span> : Death : Choice_Description_here</li>
<li><b>7 </b></span> : Hear World : Choice_Description_here</li>
<li><b>8 </b></span> : Hear Player : Choice_Description_here</li>
<li><b>9 </b></span> : Hear Combat : Choice_Description_here</li>
<li><b>10</b></span> : See Player Unconditional : Choice_Description_here</li>
<li><b>11</b></span> : See Player, Not In Combat : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body (-1 off)</b></span> <kbd  class="tooltip" data-tooltip="integer">new_body</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is Player Ally</b></span> <kbd  class="tooltip" data-tooltip="choices">respawn_as_playerally</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Default (0) : Choice_Description_here</li>
<li><b>1 </b></span> : Opposite (1) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Override Render Mode</b></span> <kbd  class="tooltip" data-tooltip="Choices">change_rendermode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Xenmaker Template Name</b></span> <kbd  class="tooltip" data-tooltip="String">xenmaker</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Not Solid</b></span> <kbd  class="tooltip" data-tooltip="Choices">notsolid</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b></span> : Default : Choice_Description_here</li>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gag</b></span> <kbd  class="tooltip" data-tooltip="Choices">gag</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b></span> : Default : Choice_Description_here</li>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Weapons (Grunt/Massn/etc)</b></span> <kbd  class="tooltip" data-tooltip="Choices">weapons</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Default / No setting : Choice_Description_here</li>
<li><b>1 </b></span> : MP5 : Choice_Description_here</li>
<li><b>3 </b></span> : MP5 + HG : Choice_Description_here</li>
<li><b>5 </b></span> : M16 + GL : Choice_Description_here</li>
<li><b>8 </b></span> : Shotgun / Sniper Rifle : Choice_Description_here</li>
<li><b>10 </b></span> : Shotgun / Sniper Rifle + HG : Choice_Description_here</li>
<li><b>16 </b></span> : SAW (human_grunt_ally only!) : Choice_Description_here</li>
<li><b>32 </b></span> : No Weapons (male_assassin only!) : Choice_Description_here</li>
<li><b>64 </b></span> : Rocket Launcher : Choice_Description_here</li>
<li><b>66 </b></span> : Rocket Launcher + HG : Choice_Description_here</li>
<li><b>128 </b></span> : Sniper Rifle (human_grunt only!) : Choice_Description_here</li>
<li><b>130 </b></span> : Sniper Rifle + HG (human_grunt only!) : Choice_Description_here</li>
<li><b>256 </b></span> : Don't drop weapon (HWG etc) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Squad Name</b></span> <kbd  class="tooltip" data-tooltip="String">squadname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Squad Leader</b></span> <kbd  class="tooltip" data-tooltip="Choices">is_squad_leader</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>In-game Name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Blood Color</b></span> <kbd  class="tooltip" data-tooltip="choices">bloodcolor</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Monster Default : Choice_Description_here</li>
<li><b>-1 </b></span> : No Blood : Choice_Description_here</li>
<li><b>1 </b></span> : Red : Choice_Description_here</li>
<li><b>2 </b></span> : Yellow : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Health</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="studio">new_model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Min Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">minhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Max Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">maxhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Roaming (nodes)</b></span> <kbd  class="tooltip" data-tooltip="Choices">freeroam</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Map Default : Choice_Description_here</li>
<li><b>1 </b></span> : Never : Choice_Description_here</li>
<li><b>2 </b></span> : Always : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Name</b></span> <kbd  class="tooltip" data-tooltip="string">path_name</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity to Guard</b></span> <kbd  class="tooltip" data-tooltip="string">guard_ent</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>V_model (Weapons Only)</b></span> <kbd  class="tooltip" data-tooltip="String">wpn_v_model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>W_model (Weapons Only)</b></span> <kbd  class="tooltip" data-tooltip="String">wpn_w_model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>P_model (Weapons Only)</b></span> <kbd  class="tooltip" data-tooltip="String">wpn_p_model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Angelscript function name</b></span> <kbd  class="tooltip" data-tooltip="string">function_name</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>1 </b></span> : Start ON : Choice_Description_here</li>
<li><b>4 </b></span> : Cyclic : Choice_Description_here</li>
<li><b>8 </b></span> : MonsterClip : Choice_Description_here</li>
<li><b>16 </b></span> : Prisoner : Choice_Description_here</li>
<li><b>32 </b></span> : Auto Size BBox : Choice_Description_here</li>
<li><b>64 </b></span> : Cyclic Backlog : Choice_Description_here</li>
<li><b>128 </b></span> : WaitForScript : Choice_Description_here</li>
<li><b>1024 </b></span> : No Respawn (Collectible) : Choice_Description_here</li>
<li><b>2048 </b></span> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
