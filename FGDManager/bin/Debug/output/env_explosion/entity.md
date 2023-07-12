---
title: env_explosion
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which, when triggered, creates an explosion which damages everything damageable around it.</div>
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
Set name of {{ entname }} so other entities can trigger it to create explosion. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Magnitude</b></span> <kbd  class="tooltip" data-tooltip="Integer">iMagnitude</kbd> :
Explosion magnitude. Greater values mean bigger explosion size and damage. Note that explosion damage values above 200 are known to cause damage even through walls.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">No Damage</span> : If set, the explosion deals no damage.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Repeatable</span> : If set, the env_explosion entity won't be removed after being triggered, so you can use it again.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">No Fireball</span> : If set, the explosion shows no fireball.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">No Smoke</span> : If set, the explosion shows no smoke.</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">No Decal</span> : If set, the explosion causes no decal.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">No Sparks</span> : If set, the explosion creates no sparks.</li>
</ul>
</div>
