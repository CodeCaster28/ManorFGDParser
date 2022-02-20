---
title: trigger_auto
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity_Description_here</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Same as target, except that this supposedly causes the specified entity/entities to be removed from the game. Not all entities which have a target to trigger will also handle killtarget. You may want to use a [trigger_relay](../trigger_relay) to make sure it is working.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global State to Read</b></span> <kbd  class="tooltip" data-tooltip="string">globalstate</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off : Choice_Description_here</li>
<li><b>1 </b> : On : Choice_Description_here</li>
<li><b>2 </b> : Toggle : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Remove On fire</span> : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
