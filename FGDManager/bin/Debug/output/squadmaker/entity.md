---
title: squadmaker
---
<div>{% set entname = page.title|raw %}</div>
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
<li><b>0</b> : Normal : Choice_Description_here</li>
<li><b>1</b> : Slow Pulse : Choice_Description_here</li>
<li><b>2</b> : Fast Pulse : Choice_Description_here</li>
<li><b>3</b> : Slow Wide Pulse : Choice_Description_here</li>
<li><b>4</b> : Fast Wide Pulse : Choice_Description_here</li>
<li><b>9</b> : Slow Strobe : Choice_Description_here</li>
<li><b>10</b> : Fast Strobe : Choice_Description_here</li>
<li><b>11</b> : Faster Strobe : Choice_Description_here</li>
<li><b>12</b> : Slow Flicker : Choice_Description_here</li>
<li><b>13</b> : Fast Flicker : Choice_Description_here</li>
<li><b>5</b> : Slow Fade Away : Choice_Description_here</li>
<li><b>6</b> : Fast Fade Away : Choice_Description_here</li>
<li><b>7</b> : Slow Become Solid : Choice_Description_here</li>
<li><b>8</b> : Fast Become Solid : Choice_Description_here</li>
<li><b>14</b> : Constant Glow : Choice_Description_here</li>
<li><b>15</b> : Distort : Choice_Description_here</li>
<li><b>16</b> : Hologram (Distort + fade) : Choice_Description_here</li>
<li><b>17</b> : Dead Player (DONT USE!) : Choice_Description_here</li>
<li><b>18</b> : Explode (Garg Like) : Choice_Description_here</li>
<li><b>19</b> : Glow Shell : Choice_Description_here</li>
<li><b>20</b> : ClampMinScale (Sprites) : Choice_Description_here</li>
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
<li><b>0</b> : Normal : Choice_Description_here</li>
<li><b>1</b> : Color : Choice_Description_here</li>
<li><b>2</b> : Texture : Choice_Description_here</li>
<li><b>3</b> : Glow : Choice_Description_here</li>
<li><b>4</b> : Solid : Choice_Description_here</li>
<li><b>5</b> : Additive : Choice_Description_here</li>
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
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
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
<li><b>0 </b> : Legacy, no special handling : Choice_Description_here</li>
<li><b>1 </b> : Block, spawn as soon as clear : Choice_Description_here</li>
<li><b>2 </b> : Force spawn, never block : Choice_Description_here</li>
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
<li><b>0 </b> : No Trigger : Choice_Description_here</li>
<li><b>1 </b> : See Player, Mad at Player : Choice_Description_here</li>
<li><b>2 </b> : Take Damage : Choice_Description_here</li>
<li><b>3 </b> : 50% Health Remaining : Choice_Description_here</li>
<li><b>4 </b> : Death : Choice_Description_here</li>
<li><b>7 </b> : Hear World : Choice_Description_here</li>
<li><b>8 </b> : Hear Player : Choice_Description_here</li>
<li><b>9 </b> : Hear Combat : Choice_Description_here</li>
<li><b>10</b> : See Player Unconditional : Choice_Description_here</li>
<li><b>11</b> : See Player, Not In Combat : Choice_Description_here</li>
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
<li><b>0 </b> : Default (0) : Choice_Description_here</li>
<li><b>1 </b> : Opposite (1) : Choice_Description_here</li>
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
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
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
<li><b>-1 </b> : Default : Choice_Description_here</li>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
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
<li><b>-1 </b> : Default : Choice_Description_here</li>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
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
<li><b>0 </b> : Default / No setting : Choice_Description_here</li>
<li><b>1 </b> : MP5 : Choice_Description_here</li>
<li><b>3 </b> : MP5 + HG : Choice_Description_here</li>
<li><b>5 </b> : M16 + GL : Choice_Description_here</li>
<li><b>8 </b> : Shotgun / Sniper Rifle : Choice_Description_here</li>
<li><b>10 </b> : Shotgun / Sniper Rifle + HG : Choice_Description_here</li>
<li><b>16 </b> : SAW (human_grunt_ally only!) : Choice_Description_here</li>
<li><b>32 </b> : No Weapons (male_assassin only!) : Choice_Description_here</li>
<li><b>64 </b> : Rocket Launcher : Choice_Description_here</li>
<li><b>66 </b> : Rocket Launcher + HG : Choice_Description_here</li>
<li><b>128 </b> : Sniper Rifle (human_grunt only!) : Choice_Description_here</li>
<li><b>130 </b> : Sniper Rifle + HG (human_grunt only!) : Choice_Description_here</li>
<li><b>256 </b> : Don't drop weapon (HWG etc) : Choice_Description_here</li>
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
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
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
<li><b>0 </b> : Monster Default : Choice_Description_here</li>
<li><b>-1 </b> : No Blood : Choice_Description_here</li>
<li><b>1 </b> : Red : Choice_Description_here</li>
<li><b>2 </b> : Yellow : Choice_Description_here</li>
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
<li><b>0 </b> : Map Default : Choice_Description_here</li>
<li><b>1 </b> : Never : Choice_Description_here</li>
<li><b>2 </b> : Always : Choice_Description_here</li>
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
<li class="imagepadding" markdown="1"><b>1 </b> : Start ON : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Cyclic : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : MonsterClip : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>16 </b> : Prisoner : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32 </b> : Auto Size BBox : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64 </b> : Cyclic Backlog : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>128 </b> : WaitForScript : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>1024 </b> : No Respawn (Collectible) : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
