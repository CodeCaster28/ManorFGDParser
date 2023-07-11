---
title: player_weaponstrip
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Removes all weapons and ammo from player. It's possible to also remove HEV suit.</div>
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
Set name of {{ entname }} so other entities can trigger it to remove player's weapons. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Players to strip</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iAffected</kbd> :
Allows to change which players will be affected by player_weaponstrip.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Activator only (default) : Strip only !activator of the script e.g. player who pressed a button that targeted this entity.</li>
<li><b>1 </b> : All players : Strip everyone on map.</li>
<li><b>2 </b> : All players except activator : Strip everyone except the !activator of the script- e.g. strip everyone except player who pressed a button that targeted this entity.</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Strip suit, too</span> : (Also) remove HEV suit.</li>
</ul>
</div>
