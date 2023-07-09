---
title: game_slot_counter
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity suppose to count the total number of player slots on the server on map load and triggers its target on the first server frame if the amount of slots equals a value you specify. However I couldn't get it to work. Contact me if you managed to make it working. It won't trigger if the amount of slots is greater or smaller than the specified value. This entity will remove itself from the game right afterwards.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Tested, doesn't work.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Tested, doesn't work.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Tested, doesn't work.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Value</b></span> <kbd  class="tooltip" data-tooltip="integer">frags</kbd> :
Player slots required for this entity to trigger its target.
</div>
<div class="notices blue" markdown="1">Once a map is running, the maximum player count (stored in CVar "maxplayers") cannot be changed.</div>
