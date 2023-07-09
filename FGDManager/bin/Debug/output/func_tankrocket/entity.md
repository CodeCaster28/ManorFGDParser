---
title: func_tankrocket
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Same as [func_tank](../func_tank) but launches rockets. Func_tankrocket is used to represent a mounted cannon which can be controlled by players as well as monsters, if allowed. For either to be able to use this, it must be hooked up to a single func_tankcontrols entity. If you want func_tankrocket to be controllable by player, you need to specify a name of func_tankrocket and use func_tankcontrols entity in addition of this entity. Automatic turret needs "Active" flag enabled. Entity requires origin brush tied to barrel, so it can rotate around it.</div>
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
Set name of {{ entname }} so other entities can trigger it to take control, preferably [func_tankcontrols](../func_tankcontrols). Some others entities like [func_button](../func_button) works as well. Does not accept 'Off' use-type. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger whenever a controlled {{ entname }} shot. Trigger use-type is 'Toggle'.
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
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Global name of entity, allows to have one entity in the multiple maps (e.g. elevator in map1 and map2 have the same "Global Entity Name" which tells the engine to treat those entities as a one single entity, so all elevator settings, positions, actions e.t.c. are copied to another map in a moment of map transitions.
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
How wide the barrel is, horizontally (x axis).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Barrel Vertical</b></span> <kbd  class="tooltip" data-tooltip="string">barrelz</kbd> :
How wide the barrel is, vetically (z axis).
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
Sets the minimum light level. Set this value if entity is too dark on compiled map. Also useful for things like computer screens or holograms. Default is 0, max 1.
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
Set relationship towards entities classified as "unknown".
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
<span style="color:#9fc5e8;"><b>ZHLT Template Model Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_usemodel</kbd> :
For Brush entities: sets brush model template of this entity. Set it to the name of other brush entity (now called a template) and it's brush model will be used instead. Templates might save server resources by "copying" single brush entity (template identified by name) and using it in multiple places (can be used for entities like tables, columns, barrels, cars e.t.c.). Also one template occupies only one entity slot when compiling a map, no matter how many entities refers to it. For model-based point entities: copy display model of specified entity, to use it's model instead. Using "Custom model" is more appropriate in most cases, however, when it's not possible, use "ZHLT Copy Lighting From Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Copy Lighting From Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_copylight</kbd> :
For Brush entities: copies light info from specified entity. This can be useful when we want this entity to be light up in a similar way the other entity of the map is, e.g. we have few func_pushables on map, and they are lit differently, tough they can be moved (and lightning is not updated on dynamic entities), it may looks shabby. With this keyvalue we can prevent this making all func_pushables received light in a same way. Another example: we have few windows in corridor (e.g. func_breakables), all of them receive a light in acceptable way, but the last window receive part of the light from another room and breaking whole atmosphere. We can set this window "Copy Lightning From Target" to any other window to fix this. Note that this can be also used for completely different entities, so we copy lightning from func_door to func_breakable as well.
For model-based point entities: if model lightning does not satisfy you (e.g. it's too dark) you can specify a name of entity here to copy it's lightning values- it can be other model-based entity or simply [info_target](../info_target).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Disable Clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Enable or disable collision of entity.
<div class="accordion">
<input type="checkbox" id="accordion-18" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-18">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Keep default collision.</li>
<li><b>1 </b> : Always non-solid : This makes entity non-solid- all collision info from this entity will be ignored. Use it in case when entity have no build-in collision disabling ability (e.g. by selecting "Passable" flag in func_door) and you much desire to disable collision for this entity.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_invisible</kbd> :
Brush entities only. Determines if entity should be visible.
<div class="accordion">
<input type="checkbox" id="accordion-19" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-19">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Visible (default)</li>
<li><b>1 </b> : Invisible</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Custom Shadow (when opaque)</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_customshadow</kbd> :
Opaque brush entities only. If "ZHLT Ligth Flags" of this entity uses any of the option with 'Opaque' word, this will allow to customize shadow dropped by this entity. Value format: [0 - 1.0] [0 - 1.0] [0 - 1.0], use three values for color or only one for transparency.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map (when translucent)</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_embedlightmap</kbd> :
Transparent brush entities only. Set it to 'Yes' and this transparent entity will take a light from environment making it looks much more natural. Use it when entities (e.g. glass represented by func_wall) omits lightning from surrounding. Note that this is expensive so shouldn't be used too often, but resolution of those lightmaps can be controlled by keyvalue explained below.
<div class="accordion">
<input type="checkbox" id="accordion-20" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-20">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default)</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map Resolution</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_embedlightmapresolution</kbd> :
Value of power of two that controls the resolution of embedded lightmaps of transparent textures (see keyvalue above). Higher value for better optimization. Default and recommended value is 4.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Flags</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_lightflags</kbd> :
Brush entities only. Changes light casting or receiving setting.
<div class="accordion">
<input type="checkbox" id="accordion-21" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-21">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Let the entity decide about lightning setting.</li>
<li><b>1 </b> : Embedded Fix : Disables bleed fix on given entity. Sometimes when entity gets trough the wall, it may get wrong lighting in one of the site. Use this flag when this problem appear.</li>
<li><b>2 </b> : Opaque (blocks light) : May be useful for func_door or func_illusionary to generate shadows. Can also generate shadows on transparent '{' textures with 'Solid' Render Mode (amount: 255). Note that shadow sharpness depends on '-blur' compile value. The blur value of map above is 0.5 (it's 1.5 by default).</li>
<li><b>3 </b> : Opaque + Embedded fix : both 'Opaque' and 'Embedded Fix' settings.</li>
<li><b>6 </b> : Opaque + Concave Fix : Instead of using 'Embedded Fix' you can use 'Concave Fix'. It's generally used for curved entities, use it when you spot a black seems on curved (arched) entities.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Origin Target</b></span> <kbd  class="tooltip" data-tooltip="string">light_origin</kbd> :
Set it to the name of [info_target](../info_target), this entity will receive lights from specified [info_taget](../info_taget) position instead of it's own position. As a lot of entites can moves and lightning is not updated dynamically you can choose how your entity will be lit in game (e.g. elevators, pushables e.t.c.). Now you don't need to put the whole entity in the well-lit room at map start to make them look desirable.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Active</span> : Makes this {{ entname }} active on start, which means it will try to kill every enemies in it's view distance.</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">Only Direct</span> : If selected, the automatic {{ entname }} will trigger it's target only when they are in it's line of sight.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">Controllable</span> : If selected, player can control this turret. Keep in mind that [func_tankcontrols](../func_tankcontrols) is required for this.</li>
<li class="imagepadding" markdown="1"><b>512</b> : <span style="color:#9fc5e8;">Use Relations</span> : Enables usage of relation keyvalues (may be glitched).</li>
<li class="imagepadding" markdown="1"><b>1024</b> : <span style="color:#9fc5e8;">Player can't fire</span> : Prevent player from shooting (player might still mount the tank).</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Turret can be both controllable and automatic- attacks player until he gets control over this func_tank.</div>
<div class="notices blue" markdown="1">Entity must be facing east at x/y view of the editor, the angle of barrel must be customized with 'Yaw' compass in object properties.</div>
<div class="notices red" markdown="1">Max range of all func_tank entities cannot be set to higher that 2048.</div>
