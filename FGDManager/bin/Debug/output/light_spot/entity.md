---
title: light_spot
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This works as [light](../light) does, except that the emitted light will be limited to a cone. You can customize cone size and brightness. Perfect for searchlight, car lights, streetlights etc. It's more atmospheric than point light, however areas inside of the cone won't be illuminated enough (higher '-bounce' hlrad compile parameter values may increase brightness outside the light_spot a bit).</div>
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
Set name of {{ entname }} so other entities can trigger it to turn light on and off. Depending on trigger use-type: 'On'- turn light on, 'Off'- turn light off, 'Toggle'- toggle light. Kill-targeting this entity will remove {{ entname }} but won't remove lightstyles (you might want to just turn it off instead).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
The name of an entity in the map that the spotlight will point at (preferably [info_null](../info_null)). This will override the spotlight's angles.
</div>
<div class="entityentry" markdown="1">
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
<span style="color:#9fc5e8;"><b>Inner (bright) angle</b></span> <kbd  class="tooltip" data-tooltip="integer">_cone</kbd> :
The angle, in inches, in which cone is full-lit. It works separately from outer angle, so you can use either both or one of those keyvalues.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Outer (fading) angle</b></span> <kbd  class="tooltip" data-tooltip="integer">_cone2</kbd> :
The angle, in inches, in which cone is fading out (outside of inner angle). It works separately from inner angle, so you can use either both or one of those keyvalues.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch</b></span> <kbd  class="tooltip" data-tooltip="integer">pitch</kbd> :
Pitch determines direction of the light, '0' is horizontal, '90' is vertical from top, '-90' is vertical from bottom. You can use info_target as a light target instead.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
Red, green and blue amounts of the light color, from 0 to 255, followed by the brightness, which can have pretty much any value greater than 0. It is not limited to 200 or 255 and can be a decimal, although that level of precision is rarely required.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is Sky</b></span> <kbd  class="tooltip" data-tooltip="Choices">_sky</kbd> :
Makes light_spot simulates [light_environment](../light_environment), it will emit light from all sky textures. It's useful for dark maps, models will be displayed correctly within light and light_spot entities, in normal light_environment all model lightning are generated from sky, and point/spot lights are ignored.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
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
<span style="color:#9fc5e8;"><b>Appearance</b></span> <kbd  class="tooltip" data-tooltip="Choices">style</kbd> :
Allows you to select a light style. This will only work when a targetname is NOT set. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Normal</li>
<li><b>10</b> : Fluorescent flicker</li>
<li><b>2 </b> : Slow, strong pulse</li>
<li><b>11</b> : Slow pulse, noblack</li>
<li><b>5 </b> : Gentle pulse</li>
<li><b>1 </b> : Flicker A</li>
<li><b>6 </b> : Flicker B</li>
<li><b>3 </b> : Candle A</li>
<li><b>7 </b> : Candle B</li>
<li><b>8 </b> : Candle C</li>
<li><b>4 </b> : Fast strobe</li>
<li><b>9 </b> : Slow strobe</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Appearance</b></span> <kbd  class="tooltip" data-tooltip="string">pattern</kbd> :
Allows you to set up a custom appearance of unnamed light. To do this, you will have to enter 1 to 64 chars from the alphabet ('a' to 'z'), whereas 'a' stands for being dark and 'z' for very bright. Normal lights' appearances uses 'm'. The program [Custom Lightstyle Generator](https://twhl.info/wiki/page/VERC%3A_Custom_Lightstyle_Generator_v1.0) by Craig "CRAZG" McLaren might help you here. Whatever sequence you enter is stepped through at about 8 Hertz. This will only work when a targetname is set. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Initially dark</span> : If set, the light will be turned off at map start. This will only work when a targetname is set. This counts as an additional lightstyle. If you have multiple lights by the same name, they will count as one additional lightstyle, even if some of the lights are initially dark while others are not. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.</li>
</ul>
</div>
