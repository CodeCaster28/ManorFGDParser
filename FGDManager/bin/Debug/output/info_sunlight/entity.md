---
title: info_sunlight
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Overrides [light_environment](../light_environment) light affecting, making all models affected by light_environment(s) picks lightning settings from this info_sunlight instead of environment lights. Helpful when light_environment produces dim light, but we need models to be more brightened. Also useful when multiple light_environments are used, and light doesn't suit both lights, so mapper can specify light color and brightness by his own for environmental lights.</div>
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Not tested.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (Y Z X)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch</b></span> <kbd  class="tooltip" data-tooltip="integer">pitch</kbd> :
Determines position of the virtual sun. Pitch '0' for sun casting light from the ground level (minimal light, shadows simulates eclipse-like blackout), '90' for most top position (yaw value don't need to be set if pitch is 90 or -90). Negative values places sun beneath ground level, so in the basic sky configuration (sky textures above the ground) the map is full-lit (no shadows).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
Red, green and blue amounts of the light color, from 0 to 255, followed by the brightness, which can have pretty much any value greater than 0. It is not limited to 200 or 255 and can be a decimal, although that level of precision is rarely required.
</div>
</div>
