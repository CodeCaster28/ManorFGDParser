---
title: light
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A point light source.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Non-functional in {{ entname }}, yet need to be left empty in order to make {{ entname }} toggleable.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to turn light on and off. Depending on trigger use-type: 'On'- turn light on, 'Off'- turn light off, 'Toggle'- toggle light. Kill-targeting this entity will remove {{ entname }} but won't remove lightstyles (you might just want to turn it off instead).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
Red, green and blue amounts of the light color, from 0 to 255, followed by the brightness, which can have pretty much any value greater than 0. It is not limited to 200 or 255 and can be a decimal, although that level of precision is rarely required.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Appearance</b></span> <kbd  class="tooltip" data-tooltip="Choices">style</kbd> :
Allows you to select a light style. This will only work when a targetname is NOT set. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Fade</b></span> <kbd  class="tooltip" data-tooltip="string">_fade</kbd> :
Controls light travel distance. You can either make light shorter (higher values above 1.0) or longer (smaller values approaching 0.0). The default value is 1.0.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Falloff</b></span> <kbd  class="tooltip" data-tooltip="choices">_falloff</kbd> :
This option can change the normal inverse square falloff of lighting in the direct lighting layer with inverse falloff.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
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
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Initially dark</span> : If set, the light will be turned off at map start. This will only work when a targetname is set. This counts as an additional lightstyle. If you have multiple lights by the same name, they will count as one additional lightstyle, even if some of the lights are initially dark while others are not. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Remove Entity</span></li>
</ul>
</div>
<div class="notices blue">The use of texlights is always more encouraged, as they usually produce more realistic lighting.</div>
