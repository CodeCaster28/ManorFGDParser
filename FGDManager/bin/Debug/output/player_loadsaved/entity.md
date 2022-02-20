---
title: player_loadsaved
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Player_loadsaved is used to restart map after screen fade and custom on-screen message.</div>
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
Set name of {{ entname }} so other entities can trigger this to restart map.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Duration (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">duration</kbd> :
Time, in seconds, the fade effect will fade in.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hold Fade (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">holdtime</kbd> :
Time, in seconds, the fully faded-in screen will stay.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Alpha</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Set how transparent/opaque the effect is at its peak (Hold fade). 0 means transparent. 255 means opaque.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Fade color to use.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Show Message delay</b></span> <kbd  class="tooltip" data-tooltip="string">messagetime</kbd> :
Delay after triggering this entity to display text.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Message To Display</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Text to show on screen.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Reload delay</b></span> <kbd  class="tooltip" data-tooltip="string">loadtime</kbd> :
Delay after triggering this entity to restart level. Note that this time is not calculated after screen finished fading so by setting this value you should consider "Fade Duration" and "Hold Fade Time". E.g. "Fade Duration" is 2 and "Hold Fade Time" is 1.5. Preferable value for reload delay would be 2 + 1.5 = 3.5.
</div>
