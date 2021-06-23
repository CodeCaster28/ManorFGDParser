---
title: env_laser
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
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target of Laser</b></span> <kbd  class="tooltip" data-tooltip="target_destination">LaserTarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Width of beam (pixels*0.1 0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">width</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of noise (0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">NoiseAmplitude</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Name</b></span> <kbd  class="tooltip" data-tooltip="sprite">texture</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>End Sprite</b></span> <kbd  class="tooltip" data-tooltip="sprite">EndSprite</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Scroll Rate (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">TextureScroll</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Starting Frame</b></span> <kbd  class="tooltip" data-tooltip="integer">framestart</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage / second</b></span> <kbd  class="tooltip" data-tooltip="string">damage</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>1 </b></span> : Start On : Choice_Description_here</li>
<li><b>16</b></span> : StartSparks : Choice_Description_here</li>
<li><b>32</b></span> : EndSparks : Choice_Description_here</li>
<li><b>64</b></span> : Decal End : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
