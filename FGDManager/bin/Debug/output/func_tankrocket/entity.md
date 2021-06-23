---
title: func_tankrocket
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
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
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>(Team) Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Currently unsupported.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Yaw Rate</b></span> <kbd  class="tooltip" data-tooltip="string">yawrate</kbd> :
How fast the barrel rotates horizontally, in degrees per seconds.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Yaw Range</b></span> <kbd  class="tooltip" data-tooltip="string">yawrange</kbd> :
The range, in degrees, of the barrel horizontal rotation in each side- left and right. This value is doubled for the whole barrel range e.g. when it's set to 90, the barrel can rotate left by 90 degrees and right by 90 degrees, what gives the total of 180.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Yaw Tolerance</b></span> <kbd  class="tooltip" data-tooltip="string">yawtolerance</kbd> :
Additional left-right range. If the gun tries to turn beyond yaw range + yaw tolerance, the gun will snap back to the maximum yaw range.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Rate</b></span> <kbd  class="tooltip" data-tooltip="string">pitchrate</kbd> :
Vertical barrel rotating speed, in degrees per seconds.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Range</b></span> <kbd  class="tooltip" data-tooltip="string">pitchrange</kbd> :
Vertical range of the barrel rotation, up and down. This value is doubled for the whole barrel range e.g. when it's set to 10, the barrel can rotate up by 10 degrees and down by 10 degrees, what gives the total of 20.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Tolerance</b></span> <kbd  class="tooltip" data-tooltip="string">pitchtolerance</kbd> :
Additional up-down range. If the gun tries to turn beyond pitch range + pitch tolerance, the gun will snap back to the maximum pitch range.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Barrel Length</b></span> <kbd  class="tooltip" data-tooltip="string">barrel</kbd> :
Determines where bullets comes from. Distance is counted from origin brush to barrel end.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Barrel Horizontal</b></span> <kbd  class="tooltip" data-tooltip="string">barrely</kbd> :
How wide the barrel is, horizontaly (x axis).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Barrel Vertical</b></span> <kbd  class="tooltip" data-tooltip="string">barrelz</kbd> :
How wide the barrel is, veticaly (z axis).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Smoke Sprite</b></span> <kbd  class="tooltip" data-tooltip="string">spritesmoke</kbd> :
Name of the sprite to show whenever bullet is shoot. Starts with 'sprites/' folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Flash Sprite</b></span> <kbd  class="tooltip" data-tooltip="string">spriteflash</kbd> :
Name of the sprite to show as a muzzle flash of the barrel. Starts with 'sprites/' folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Scale</b></span> <kbd  class="tooltip" data-tooltip="string">spritescale</kbd> :
Scale of smoke and flash sprites.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Rotate Sound</b></span> <kbd  class="tooltip" data-tooltip="sound">rotatesound</kbd> :
Sound file to play in a loop while barrel is rotating.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Rate of Fire</b></span> <kbd  class="tooltip" data-tooltip="string">firerate</kbd> :
Number of bullets per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage Per Bullet</b></span> <kbd  class="tooltip" data-tooltip="string">bullet_damage</kbd> :
Damage to deal each shot.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Firing Persistence</b></span> <kbd  class="tooltip" data-tooltip="string">persistence</kbd> :
How many seconds this entity will continue shooting after losing player from field of view. Works only for automatic turrets.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Bullet Accuracy</b></span> <kbd  class="tooltip" data-tooltip="choices">firespread</kbd> :
Allows to customize bullet spreading, from perfect shot to Star Wars Stormtrooper accuracy.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Perfect Shot</li>
<li><b>1</b> : Small cone</li>
<li><b>2</b> : Medium cone</li>
<li><b>3</b> : Large cone</li>
<li><b>4</b> : Extra-large cone</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minmum target range</b></span> <kbd  class="tooltip" data-tooltip="string">minRange</kbd> :
Minimum view distance to shoot target, used for automatic turrets only.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum target range</b></span> <kbd  class="tooltip" data-tooltip="string">maxRange</kbd> :
Maximum view distance to shoot target, used for automatic turrets only. Values above 2048 doesn't work.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum light level</b></span> <kbd  class="tooltip" data-tooltip="string">_minlight</kbd> :
Sets the minimum light level. Useful for when textures should always appear brighter. Default is 0, max 1.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Player</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_player</kbd> :
Set relationship towards player.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Unknown</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_none</kbd> :
Set relationship towards entities classificated as "unknown".
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Machine</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_machine</kbd> :
Set relationship towards machines.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Human Passive</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_human_passive</kbd> :
Set relationship towards humans (passive).
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Human Military</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_human_militar</kbd> :
Set relationship towards military humans.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Alien Military</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_alien_militar</kbd> :
Set relationship towards military aliens.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Alien Passive</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_alien_passive</kbd> :
Set relationship towards passive aliens.
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Alien Monster</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_alien_monster</kbd> :
Set relationship towards alien monsters.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Alien Prey</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_alien_prey</kbd> :
Set relationship towards alien preys.
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Alien Predator</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_alien_predator</kbd> :
Set relationship towards alien predators.
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Insect</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_insect</kbd> :
Set relationship towards insect.
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Player Ally</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_player_ally</kbd> :
Set relationship towards player allies.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Player BioWeapon</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_player_bioweapon</kbd> :
Set relationship towards player's bioweapon (e.g. snarks thrown by player).
<div class="accordion">
<input type="checkbox" id="accordion-16" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-16">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Monster BioWeapon</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_monster_bioweapon</kbd> :
Set relationship towards monster's bioweapons (e.g. shockroach dropped by shocktroopers).
<div class="accordion">
<input type="checkbox" id="accordion-17" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-17">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>R Machine</b></span> <kbd  class="tooltip" data-tooltip="choices">relation_machine</kbd> :
Set relationship towards machines.
<div class="accordion">
<input type="checkbox" id="accordion-18" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-18">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-2</b> : Ally</li>
<li><b>-1</b> : Friend</li>
<li><b>0</b> : No Relation</li>
<li><b>1</b> : Dislike</li>
<li><b>2</b> : Hate</li>
<li><b>3</b> : Nemesis</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Template Model Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_usemodel</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Copy Lighting From Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_copylight</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Disable Clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-19" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-19">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Choice_Description_here</li>
<li><b>1 </b> : Always non-solid : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_invisible</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-20" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-20">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Visible (default) : Choice_Description_here</li>
<li><b>1 </b> : Invisible : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Custom Shadow (when opaque)</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_customshadow</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map (when translucent)</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_embedlightmap</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-21" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-21">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default) : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map Resolution</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_embedlightmapresolution</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Flags</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_lightflags</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-22" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-22">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Choice_Description_here</li>
<li><b>1 </b> : Embedded Fix : Choice_Description_here</li>
<li><b>2 </b> : Opaque (blocks light) : Choice_Description_here</li>
<li><b>3 </b> : Opaque + Embedded fix : Choice_Description_here</li>
<li><b>6 </b> : Opaque + Concave Fix : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Origin Target</b></span> <kbd  class="tooltip" data-tooltip="string">light_origin</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Active : Makes this {{ entname }} active on start, which means it will try to kill every enemies in it's view distance.</li>
<li class="imagepadding" markdown="1"><b>16</b> : Only Direct : If selected, the automatic {{ entname }} will fire it's target only when they are in it's line of sight.</li>
<li class="imagepadding" markdown="1"><b>32</b> : Controllable : If selected, player can control this turret. Keep in mind that [func_tankcontrols](../func_tankcontrols) is required for this.</li>
<li class="imagepadding" markdown="1"><b>512</b> : Use Relations : Enables usage of relation keyvalues (may be glitched).</li>
<li class="imagepadding" markdown="1"><b>1024</b> : Player can't fire : Prevent player from shooting (player might still mount the tank).</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
