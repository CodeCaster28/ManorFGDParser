---
title: env_shake
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Causes nearby players' screens to shake. Used for simulating earthquakes.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<span style="color:#cae4fc;"><b>OnDestroy Function</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to apply a screen shake. Every trigger use-type works uniformly. Multiple triggering will override previous shake. Can be kill-targeted but shake won't stop playing until finished.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amplitude (degrees; 0-16)</b></span> <kbd  class="tooltip" data-tooltip="string">amplitude</kbd> :
Ranging from 0.0 to 16.0, this sets the amplitude in degrees.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effect radius (if not global)</b></span> <kbd  class="tooltip" data-tooltip="string">radius</kbd> :
Radius around the entity in which the rumble affects players. Becomes less noticeable towards the outside of the radius.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Duration (seconds; fades out)</b></span> <kbd  class="tooltip" data-tooltip="string">duration</kbd> :
The duration, in seconds, which the rumble lasts. This includes a linear fade-out: The rumble starts with the set amplitude, which becomes less towards the duration time running out.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Frequency (Hz; 0-255)</b></span> <kbd  class="tooltip" data-tooltip="string">frequency</kbd> :
The frequency of the rumble. A value of 10 would mean that your screen will shake up and down ten times per second.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Global Shake</span> : The env_shake will affect the whole map equally, instead of a radius around it.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Env_shakes can safely be triggered while a rumble is still in progress, causing the new rumble to overwrite the old one entirely.</div>
