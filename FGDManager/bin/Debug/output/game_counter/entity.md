---
title: game_counter
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This is a logic entity which will fire its target after being triggered a specified amount of times. Toggle-trigger and on-trigger will cause it to count up by 1. Off-trigger will cause it to count down by 1. An equivalent of this entity can be created through the usage of [trigger_condition](../trigger_condition) and [trigger_changevalue](../trigger_condition).</div>
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
Set name of {{ entname }} so other entities can trigger it to increase or decrease counter. Trigger state signals: 'On' and 'Off' increases counter by one, 'Off' decreases it by one. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entities to trigger when counter hits it's limit value, or goes above this limit when 'Fire if over limit' flag is selected. Sends 'Toggle' signal.
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
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the [multisource](../multisource) entity that (temporary) locks this {{ entname }}. If master specified the {{ entname }} will be disabled and it will not count up/down when triggered. When [multisource](../multisource) entity is triggered/being triggering by all possible inputs, the {{ entname }} will be unlocked. When [multisource](../multisource) lost at least one input signal, the entities becomes locked again.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Initial Value</b></span> <kbd  class="tooltip" data-tooltip="integer">frags</kbd> :
Starting value of entity. It's also current value when accessing it through other entities like [trigger_copyvalue](../trigger_copyvalue).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Limit Value</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Required value to trigger target.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Remove On fire : Remove entity after firing.</li>
<li class="imagepadding" markdown="1"><b>2</b> : Reset On fire : Reset entity Initial value after fired.</li>
<li class="imagepadding" markdown="1"><b>4</b> : Fire if over limit : Fire a target when initial value is higher than limit value.</li>
</ul>
</div>
<div class="notices red">When target is set to ambient_generic, the game_counter need to receive twice more inputs than normal, unless "Fire if over limit" spawnflag is selected.</div>
