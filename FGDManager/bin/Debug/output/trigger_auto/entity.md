---
title: trigger_auto
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Trigger_auto is a simple point entity which will trigger in the first server frame, right after the map has loaded. Because some entities still set themselves up properly in the first server frame, it is advised to set a little delay of about 0.5 seconds, so trigger_auto does fire in a later frame and no unwanted behaviour is exhibited.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger on map start. Trigger use-type is defined at "Trigger State" keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove on map start.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global State to Read</b></span> <kbd  class="tooltip" data-tooltip="string">globalstate</kbd> :
Reads a global state variable (from env_global) to use as use-type/trigger-state.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Changes trigger use-type in which target will be triggered.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off : Trigger use-type 'Off'.</li>
<li><b>1 </b> : On : Trigger use-type 'On'.</li>
<li><b>2 </b> : Toggle : Trigger use-type 'Toggle'.</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Remove On fire</span> : Remove this entity when it's done triggering. This should be always selected due to performance reasons.</li>
</ul>
</div>
