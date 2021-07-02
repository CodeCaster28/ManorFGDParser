---
title: light
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
This always means an identifier for the entity in question so other entities can trigger or refer to it. Many entities need no name, or behave differently depending on whether they have one or not.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Appearance</b></span> <kbd  class="tooltip" data-tooltip="Choices">style</kbd> :

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
<li class="imagepadding" markdown="1"><b>1 </b> : Initially dark : If set, the light will be turned off at map start. This will only work when a targetname is set. This counts as an additional lightstyle. If you have multiple lights by the same name, they will count as one additional lightstyle, even if some of the lights are initially dark while others are not. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Remove Entity : This flag is obsolete.</li>
</ul>
</div>
