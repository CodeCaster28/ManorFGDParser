---
title: env_fog
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity which creates a fog effect within a specific area around it. Fog, unfortunately, will only show to players who have it enabled in their options.</div>
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
Set name of {{ entname }} so other entities can trigger it to control fog. Depending on trigger use-type: 'On'- enable fog, 'Off'- disable fog, 'Toggle'- toggle fog. Can be kill-targeted which removes fog effect as well.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fog Color (RGB)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
The color of the fog.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Start Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">iuser2</kbd> :
Distance, in units, at which the fog starts to be visible. This needs to be greater than zero.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>End Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">iuser3</kbd> :
Distance, in units, at which the fog appears opaque. This needs to be greater than the start distance.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Start Off</span> : The env_fog entity will start disabled and needs to be triggered in order for fog to show.</li>
</ul>
</div>
<div class="notices red" markdown="1">Fog works only for OpenGL graphics mode.</div>
<div class="notices red" markdown="1">Entities with 'Render mode' set to other than 'Normal' (including sprites) are not affected by env_fog.</div>
