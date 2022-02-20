---
title: info_monster_goal
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Non-functional. Use [path_waypoint](../path_waypoint) for monster control.</div>
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
Set name of {{ entname }} so other entities can trigger it.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Priority</b></span> <kbd  class="tooltip" data-tooltip="Choices">priority</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No enemy</li>
<li><b>1 </b> : No enemy/Enemy occluded</li>
<li><b>2 </b> : Ignore enemy</li>
<li><b>3 </b> : Goal closer than enemy</li>
<li><b>4 </b> : G.C.T.E./Enemy occluded</li>
<li><b>5 </b> : Stop only if can attack</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Movement Type</b></span> <kbd  class="tooltip" data-tooltip="Choices">movementtype</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Walk</li>
<li><b>1 </b> : Run</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait before trigger</b></span> <kbd  class="tooltip" data-tooltip="integer">delay</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move-Complete Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">radius</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Distance For Inactivity</b></span> <kbd  class="tooltip" data-tooltip="integer">triggerradius</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum Required Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">requiredradius</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Health Bonus</b></span> <kbd  class="tooltip" data-tooltip="integer">healthbonus</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action Animation</b></span> <kbd  class="tooltip" data-tooltip="string">sequence</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Enemy</b></span> <kbd  class="tooltip" data-tooltip="string">enemy</kbd> :

</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>8  </b> : <span style="color:#9fc5e8;">Start Off</span></li>
<li class="imagepadding" markdown="1"><b>16 </b> : <span style="color:#9fc5e8;">Multithreaded</span></li>
<li class="imagepadding" markdown="1"><b>32 </b> : <span style="color:#9fc5e8;">Toggle On Reach</span></li>
</ul>
</div>
