---
title: env_laser
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A less advanced version of [env_beam](../env_beam). Creates a toggleable laser between itself and its target.</div>
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
Set name of {{ entname }} so other entities can trigger it to enable/disable laser. Depending on trigger use-type: 'On'- enable laser, 'Off'- disable laser, 'Toggle'- toggle laser. Can be kill-targeted.
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
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target of Laser</b></span> <kbd  class="tooltip" data-tooltip="target_destination">LaserTarget</kbd> :
Entity at which the beam ends.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Set how bright/visible/transparent the beam shall be on a scale from '0' (invisible) to '255' (very bright).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Set the beam's color. Note that, because of bolts being rendered additively, darker colors mean greater transparency.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Width of beam (pixels*0.1 0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">width</kbd> :
Set the width of the bolt-/beam-texture in inches * 0.25. Note that one unit in Valve Hammer Editor equals one inch and the beam texture you are using possibly has entirely transparent sides, so the beam may appear a bit thinner than expected.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of noise (0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">NoiseAmplitude</kbd> :
Set how much the bolt shivers on a scale from 0 (not at all) to 255 (very much).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Name</b></span> <kbd  class="tooltip" data-tooltip="sprite">texture</kbd> :
Set the sprite to use to display the bolt. Path starts in mod-folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>End Sprite</b></span> <kbd  class="tooltip" data-tooltip="sprite">EndSprite</kbd> :
This sprite is placed where the laser beam ends.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Scroll Rate (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">TextureScroll</kbd> :
The texture of the laser is not supposed to be displayed statically. Setting a texture scroll rate gives a visual effect of an actual, moving electric current. The value you set here specifies how often the texture will scroll for the length of its own height per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Starting Frame</b></span> <kbd  class="tooltip" data-tooltip="integer">framestart</kbd> :
Set the number of the frame of the sprite to start animating at. This is rarely ever useful, e.g. when you have two identical beams next to each other and need them to look slightly different. Setting '0' here is safe.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage / second</b></span> <kbd  class="tooltip" data-tooltip="string">damage</kbd> :
Average damage per second for the laser.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start On</span> : Causes the laser to be activated from map load onwards.</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">StartSparks</span> : If set, sparks will be emitted at the env_laser.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">EndSparks</span> : If set, sparks will be emitted at the target of the laser.</li>
<li class="imagepadding" markdown="1"><b>64</b> : <span style="color:#9fc5e8;">Decal End</span> : If set, a bullethole decal will be created whenever the beam hits a surface.</li>
</ul>
</div>
<div class="notices blue">The only thing this entity has that the env_beam doesn't is "End Sprite". Unless you need this, it's probably best to use env_beam instead.</div>
<div class="notices blue">In case multiple entities match the name specified under "Target of Laser", the env_laser entity will pick one randomly.</div>
<div class="notices blue">Contrary to what you may have read elsewhere, it is not possible to alter how fine a laser will be, as in, of how many segments it will consist.</div>
<div class="notices blue">The noise-value does not affect the area in which damage will be applied. The damage area only depends on starting point, ending point and the laser's width.</div>
<div class="notices red">Setting a "Render FX" makes no change whatsoever.</div>
