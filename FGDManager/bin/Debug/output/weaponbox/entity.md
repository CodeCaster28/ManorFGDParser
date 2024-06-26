---
title: weaponbox
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The weaponbox originates from Half-Life, where it would be dropped by dead players, containing the weapon they held in the moment of their deaths as well as all their ammunition. In Sven Co-op, the weaponbox can only be explicitly placed into the map by the mapper.</div>
</div>
</div>
<div>
<table class="titletable">
<tbody>
<tr>
<td markdown="1">###Keyvalues</td>
<td class="titletablecheck" id="checkboxandlabel"><input type="checkbox" id="displaycommon"><label for="displaycommon"> Display Common Keyvalues</label></input></td>
</tr>
</tbody>
</table>
<hr>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }}. Can't be triggered. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
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
<li><b>19</b> : Glow Shell : Applies nice animated glowing shell on model. Color can be applied. "FX Amount" manipulates glow shell size.</li>
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
<span style="color:#9fc5e8;"><b>Gravity Setting</b></span> <kbd  class="tooltip" data-tooltip="choices">movetype</kbd> :
Determines how items behave after spawn.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1</b> : Unmoveable : Make item completely unmovable by any external influence, unless changed at runtime by e.g. trigger_changevalue.</li>
<li><b>0</b> : Fall to the ground (default) : Entity fall to first brush beneath it. Note that not all entities with collision may block items to fall through them.</li>
<li><b>5</b> : Hover in the air : Items won't fall from it's starting position.</li>
<li><b>8</b> : Hover in the air, ignore brush collision : Items won't fall from it's starting position and won't be affected by brush collision.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom respawn time</b></span> <kbd  class="tooltip" data-tooltip="string">m_flCustomRespawnTime</kbd> :
Customize pickup respawn delay in seconds.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="studio">model</kbd> :
You can set the custom model (w_model) for this item here. Can be any model or sprite (it will not animate). That will NOT replace default v_model and p_model of weapon.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Skin</b></span> <kbd  class="tooltip" data-tooltip="integer">skin</kbd> :
Model skin to use, if model have multiple skins.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="integer">body</kbd> :
Model body to use, if model have multiple bodies.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence Name</b></span> <kbd  class="tooltip" data-tooltip="string">sequencename</kbd> :
Default model sequence name to set.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence Number (overrides name)</b></span> <kbd  class="tooltip" data-tooltip="integer">sequence</kbd> :
Change model sequence by specifying it's number.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Scale Model</b></span> <kbd  class="tooltip" data-tooltip="string">scale</kbd> :
Scale multiplier for this model.
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
Set the path to a sound replacement file for the item. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a [custom_precache](../custom_precache) point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed 9mm rounds</b></span> <kbd  class="tooltip" data-tooltip="integer">bullet9mm</kbd> :
Amount of 9mm ammo.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed 357 rounds</b></span> <kbd  class="tooltip" data-tooltip="integer">bullet357</kbd> :
Amount of 357 ammo.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed shotgun shells</b></span> <kbd  class="tooltip" data-tooltip="integer">buckshot</kbd> :
Amount of buckshot ammo
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed crossbow bolts</b></span> <kbd  class="tooltip" data-tooltip="integer">bolts</kbd> :
Amount of crossbow bolts ammo.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed 5.56mm rounds</b></span> <kbd  class="tooltip" data-tooltip="integer">bullet556</kbd> :
Amount of 556 ammo.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed assault rifle grenades</b></span> <kbd  class="tooltip" data-tooltip="integer">ARgrenades</kbd> :
Amount of grenades for 9mmAR.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed rockets</b></span> <kbd  class="tooltip" data-tooltip="integer">rockets</kbd> :
Amount of RPG rockets.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed gauss charges</b></span> <kbd  class="tooltip" data-tooltip="integer">uranium</kbd> :
Amount of gaussclip ammp.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed hand grenades</b></span> <kbd  class="tooltip" data-tooltip="integer">handgrenade</kbd> :
Amount of hand grenades.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed satchels</b></span> <kbd  class="tooltip" data-tooltip="integer">satchelcharge</kbd> :
Amount of satchels.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed trip mines</b></span> <kbd  class="tooltip" data-tooltip="integer">tripmine</kbd> :
Amount of tripmines.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed snarks</b></span> <kbd  class="tooltip" data-tooltip="integer">Snarks</kbd> :
Amount of snarks.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed 7.62mm rounds</b></span> <kbd  class="tooltip" data-tooltip="integer">m40a1</kbd> :
Amount of 762 ammo.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Packed spores</b></span> <kbd  class="tooltip" data-tooltip="integer">sporeclip</kbd> :
Amount of spores.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>128 </b> : <span style="color:#9fc5e8;">TOUCH Only</span> : Pick this item up only by touching it.</li>
<li class="imagepadding" markdown="1"><b>256 </b> : <span style="color:#9fc5e8;">USE Only</span> : Pick this item up only by using it ('USE' key).</li>
<li class="imagepadding" markdown="1"><b>512 </b> : <span style="color:#9fc5e8;">Can Use w/o LoS</span> : Player can pick up this item even when it's not within his line of sight.</li>
<li class="imagepadding" markdown="1"><b>1024</b> : <span style="color:#9fc5e8;">Disable Respawn</span> : Disables default item respawning.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue" markdown="1">If either 'TOUCH only' and 'USE only' flags are selected, the item can only be collected via trigger, but only if player is the !activator.</div>
<div class="notices blue" markdown="1">Item can be collected on trigger, touch and use when none of flags above are selected.</div>
