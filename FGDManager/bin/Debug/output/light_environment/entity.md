---
title: light_environment
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity will cause light to be emitted from all sky-textured surfaces in the map. Use this for sunlight, or pale blue moonlight, or whatever other light the environment in your map may have. The light and brightness emitted by this should fit your environment map to look right. Arrange target of light by using Pitch value and Yaw compass at object properties. Note that brushes using "SKY" texture cannot have mixed face content (whole sky brush need to be textured).</div>
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
Set name of {{ entname }} so other entities can trigger it.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Fade</b></span> <kbd  class="tooltip" data-tooltip="string">_fade</kbd> :
Controls light travel distance. You can either make light shorter (higher values above 1.0) or longer (smaller values approaching 0.0). The default value is 1.0.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Falloff</b></span> <kbd  class="tooltip" data-tooltip="choices">_falloff</kbd> :
This option can change the normal inverse square falloff of lighting in the direct lighting layer with inverse falloff.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default</li>
<li><b>1 </b> : Inverse Linear</li>
<li><b>2 </b> : Inverse Square</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch</b></span> <kbd  class="tooltip" data-tooltip="integer">pitch</kbd> :
Determines position of the virtual sun. Pitch '0' for sun casting light from the ground level (minimal light, shadows simulates eclipse-like blackout), '90' for most top position (yaw value don't need to be set if pitch is 90 or -90). Negative values places sun beneath ground level, so in the basic sky configuration (sky textures above the ground) the map is full-lit (no shadows).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
Red, green and blue amounts of the light color, from 0 to 255, followed by the brightness, which can have pretty much any value greater than 0. It is not limited to 200 or 255 and can be a decimal, although that level of precision is rarely required.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ambient Color</b></span> <kbd  class="tooltip" data-tooltip="color255">_diffuse_light</kbd> :
Color and intensity of sky ambient color - light from sky itself, not directly from light source. E.g. ambient color for sunny cloudless day would be light blue. It will affect mostly shaded spots.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sun Spread</b></span> <kbd  class="tooltip" data-tooltip="string">_spread</kbd> :
You can control shadows of light_environment. It's useful when you want to add more realistic shadows depends on light type-for sunny day shadows will be sharper, when for cloudy or rainy weather more blurred:
![](light_environment.jpg)
</div>
</div>
<div class="notices red" markdown="1">Light and light_spot are ignored by models when light_environment is used, they will use lightning from sky only. Use light_spot with "Is sky" keyvalue set to "Yes" to fix this, but only if you need this (e.g. your map is dark and models not getting light from point lights).</div>
