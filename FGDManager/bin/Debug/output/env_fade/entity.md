---
title: env_fade
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which, when triggered, causes the players' screens to have an in- or out-fading color to be drawn over them. It's possible to create static screen color modulation by retriggering this entity in a loop.</div>
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
Set name of {{ entname }} so other entities can trigger it to start fade effect. Any trigger signal type accepted. Triggering fade that is in progress restarts fade. Can be killtargeted but fade effect will play to it's end.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Duration (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">duration</kbd> :
Time, in seconds, the effect will fade in/out.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hold Fade (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">holdtime</kbd> :
Time, in seconds, the fully faded-in/not yet faded-out state will stay.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Alpha</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Set how transparent/opaque the effect is at its peak (Hold fade). 0 means transparent. 255 means opaque.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
The color to use.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Fade From : If set, instead of fading to the color specified, the screen will fade out from it, meaning the color will apply suddenly. Good for a flashbang effect.</li>
<li class="imagepadding" markdown="1"><b>2</b> : Modulate : If set, instead of drawing the color layer over the screen, the color you set will be used as a color filter. E.g., when you set the color to pure green, any red and blue will be removed from the player's screen.</li>
<li class="imagepadding" markdown="1"><b>4</b> : Activator Only : If set, only the player who activated this entity will be affected by it.</li>
</ul>
</div>
<div class="notices red">Sum of "Duration" and "Hold Fade" time can be maximum ~18 seconds long, then env_fade ends. Trigger it multiple times to keep it for longer time, use more than one env_fade if you need first one for color transition, and second one for still target color.</div>
