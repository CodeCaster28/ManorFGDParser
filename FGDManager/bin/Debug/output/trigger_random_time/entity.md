---
title: trigger_random_time
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Obsolete, use [trigger_random](../trigger_random) with "Timed" flag. Trigger which will wait a random amount of time, then fire one of it's targets randomly, and then repeat that process while activated.</div>
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
Set name of {{ entname }} so other entities can trigger it to pick random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Count</b></span> <kbd  class="tooltip" data-tooltip="integer">target_count</kbd> :
Amount of random targets you have specified below. E.g. if you used "Target 1'" "Target 2" and "Target 3" then set it to 3.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 1</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target1</kbd> :
Target no. 1 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 2</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target2</kbd> :
Target no. 2 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 3</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target3</kbd> :
Target no. 3 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 4</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target4</kbd> :
Target no. 4 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 5</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target5</kbd> :
Target no. 5 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 6</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target6</kbd> :
Target no. 6 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 7</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target7</kbd> :
Target no. 7 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 8</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target8</kbd> :
Target no. 8 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 9</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target9</kbd> :
Target no. 9 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 10</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target10</kbd> :
Target no. 10 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 11</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target11</kbd> :
Target no. 11 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 12</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target12</kbd> :
Target no. 12 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 13</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target13</kbd> :
Target no. 13 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 14</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target14</kbd> :
Target no. 14 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 15</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target15</kbd> :
Target no. 15 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 16</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target16</kbd> :
Target no. 16 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum Delay (0 = off)</b></span> <kbd  class="tooltip" data-tooltip="string">min_delay</kbd> :
Requires "Timed" flag. Minimum delay, in seconds, till a random target will be fired. Set it to 0 to disable minimum value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum Delay (0 = off)</b></span> <kbd  class="tooltip" data-tooltip="string">max_delay</kbd> :
Requires "Timed" flag. Maximum delay, in seconds, till a random target will be fired. Set it to 0 to disable maximum value.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start On (Timed only)</span> : Makes trigger_random (with "Timed" flag) enabled at map start, so it will start it's timer and trigger random target on game start. If "Trigger Once" flag isn't selected, it will continue until deactivated by trigger.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Trigger Once (Timed only)</span> : When using random delays ("Timed" flag), this tells to trigger a random target once, instead of continuously triggering random targets until deactivation (in that case, disable timer by triggering this entity again).</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Reusable (Unique only)</span> : If set, the trigger_random with "Unique" flag can be used again after having fired its targets, handling all of them as if not triggered before again.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Timed</span> : Enables "Minimum delay" and "Maximum delay" keyvalues so you can specify to wait a random amount of time before triggering random targets. When "Trigger Once" and "Start On" flags are NOT selected, triggering this trigger_random starts the timer, and it will fire it's targets with random delays repeatedly until triggered again, what pauses it.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : <span style="color:#9fc5e8;">Unique</span> : Trigger will pick target (each time it's triggered), that haven't been triggered yet, randomly. So if four targets are specified, the combination in which they can be picked may be: 3th, 1th, 2th, 4th. It never repeats the same target unless "Reusable" flag is selected- the list will be "shuffled", and targets can be picked all over again.</li>
</ul>
</div>
