---
title: trigger_relay
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which relays a triggering action, and overrides the activator entity with itself to the target entity when triggered. It allows you to choose a specific use-type to trigger the target with, and a delay time value for when to trigger the target. These features make it useful for controlling specifically how and when an entity is triggered.</div>
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
Set name of {{ entname }} so other entities can trigger it so trigger_relay fire it's target. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger whenever {{ entname }} is triggered. Trigger use-type is defined in "Trigger State" keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when {{ entname }} is triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Set the use-type with which the trigger_relay will trigger its targets. This is set to 'Off' by default, make sure to change this if you want it to be anything else.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Off</li>
<li><b>1</b> : On</li>
<li><b>2</b> : Toggle</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Reset</b></span> <kbd  class="tooltip" data-tooltip="string">m_flDelayBeforeReset</kbd> :
Time, in seconds, the trigger_relay can fire it's target again after being triggered. Flag "Remove on fire" must be disabled for this to work.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Remove On fire</span> : If set, trigger_relay will remove itself from the game after firing its targets, making it impossible to use it again.</li>
<li class="imagepadding" markdown="1"><b>64 </b> : <span style="color:#9fc5e8;">Keep '!activator'</span> : By default trigger_relay overrides activator with itself. With this flag selected trigger_relay will pass original activator to next entity in chain.</li>
</ul>
</div>
<div class="notices blue" markdown="1">If you change a trigger_relay's target while its delay is counting down, the old target will be fired.</div>
<div class="notices blue" markdown="1">If you killtarget a trigger_relay while its delay is counting down, it will still fire. Trigger_relay passes itself on as the activator when triggered unless 'Keep !activator' flag is selected.</div>
