---
title: light_surface
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows you to create texture lights (textures that emits lights) in more advanced way than [info_texlights](../info_texlights) does. All keyvalues set to default, change "Texture Name" keyvalue and it will emit light of this texture color and power of 80. All other keyvalues and flag are optional.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture name</b></span> <kbd  class="tooltip" data-tooltip="string">_tex</kbd> :
Name of texture to emit light.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter max distance</b></span> <kbd  class="tooltip" data-tooltip="string">_frange</kbd> :
Excludes faces whose centers are far from this light_surface.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter max dist to plane</b></span> <kbd  class="tooltip" data-tooltip="string">_fdist</kbd> :
Same as above, but checking the distance to the whole texture plane (instead of face center).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter entity classname</b></span> <kbd  class="tooltip" data-tooltip="string">_fclass</kbd> :
Same as "Class In Filter" with <unknown> filter type.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter entity name</b></span> <kbd  class="tooltip" data-tooltip="string">_fname</kbd> :
Same as "Name In Filter" with <unknown> filter type.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
The brightness of texture. Works the same way as in [light](../light) and [light_spot](../light_spot).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Color(replace texture color)</b></span> <kbd  class="tooltip" data-tooltip="color255">_texcolor</kbd> :
Leave it empty, so color is auto-generated based on texture color.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inner(bright) angle(90default)</b></span> <kbd  class="tooltip" data-tooltip="string">_cone</kbd> :
Like in [light_spotlight](../light_spotlight), custom values used to simulate spotlight.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Outer(fading) angle(90default)</b></span> <kbd  class="tooltip" data-tooltip="string">_cone2</kbd> :
Like in [light_spotlight](../light_spotlight), custom values used to simulate spotlight.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Adjust emit scale(1.0default)</b></span> <kbd  class="tooltip" data-tooltip="string">_scale</kbd> :
When simulating [light_spotlight](../light_spotlight), this is scale value for light emission.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Grid size of sampling</b></span> <kbd  class="tooltip" data-tooltip="string">_chop</kbd> :
Grid size of sampling. However lightmap grid cannot be changed. This keyvalue functionality is very limited.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Dark gap in front of texlight</b></span> <kbd  class="tooltip" data-tooltip="choices">_texlightgap</kbd> :
Moves lights out of texture by few units (specified amount or chosen from pre-definied values). It's useful in situations where light leaking out of the brush in opposite direction of light. Example:
![](light_surface.jpg)
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>""</b> : Default (no gap)</li>
<li><b>"0.0"</b> : 0.0 - no gap</li>
<li><b>"3.0"</b> : 3.0 - small gap</li>
<li><b>"12.0"</b> : 12.0 - large gap</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fast</b></span> <kbd  class="tooltip" data-tooltip="choices">_fast</kbd> :
Determines usage of '-fast' compile parameter for light. Set it to 'Yes' if brightness is low and the face is large.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>""</b> : Auto</li>
<li><b>1</b> : Yes</li>
<li><b>2</b> : No</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classname in game</b></span> <kbd  class="tooltip" data-tooltip="choices">convertto</kbd> :
Used by compilers. You don't need to set this.

<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"light" </b> : light</li>
<li><b>"light_spot" </b> : light_spot</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to turn texture lights on and off. Works with 'On' (turns light on), 'Off' (turns light off) and 'Toggle' (toggles light) trigger state signals. Kill-targeting this entity will remove {{ entname }} but won't remove lightstyles (you might want to just turn it off instead).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Appearance (no name allowed)</b></span> <kbd  class="tooltip" data-tooltip="choices">style</kbd> :
Allows you to select a light style. This will only work when a targetname is NOT set. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"" </b> : Normal</li>
<li><b>10</b> : Fluorescent flicker</li>
<li><b>2 </b> : Slow, strong pulse</li>
<li><b>11</b> : Slow pulse, no black</li>
<li><b>5 </b> : Gentle pulse</li>
<li><b>1 </b> : Flicker A</li>
<li><b>6 </b> : Flicker B</li>
<li><b>3 </b> : Candle A</li>
<li><b>7 </b> : Candle B</li>
<li><b>8 </b> : Candle C</li>
<li><b>4 </b> : Fast strobe</li>
<li><b>9 </b> : Slow strobe</li>
<li><b>12 </b> : Underwater mutation</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Appearance</b></span> <kbd  class="tooltip" data-tooltip="string">pattern</kbd> :
Allows you to set up a custom appearance of light. To do this, you will have to enter 1 to 64 chars from the alphabet ('a' to 'z'), whereas 'a' stands for being dark and 'z' for very bright. Normal lights' appearances uses 'm'. The program [Custom Lightstyle Generator](https://twhl.info/wiki/page/VERC%3A_Custom_Lightstyle_Generator_v1.0) by Craig "CRAZG" McLaren might help you here. Whatever sequence you enter is stepped through at about 8 Hertz. This will only work when a targetname is set. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Initially dark : If set, the light emmited from textures will be turned off at map start. This will only work when a targetname is set. This counts as an additional lightstyle. If you have multiple lights by the same name, they will count as one additional lightstyle, even if some of the lights are initially dark while others are not. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">The brightness does not work in the same way as in the "info_texlight" (it does not scale with texture size) so you don't need to multiply "Texture brightness" value to achieve sufficient brightness.</div>
<div class="notices blue">When you want to set some of the values to '0', you'll need to set them to '0.0' instead. Editor ignores raw '0' value.</div>
