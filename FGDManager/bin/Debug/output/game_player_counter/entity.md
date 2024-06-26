---
title: game_player_counter
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity keeps track of the total number of players currently on or connecting to the server. It will trigger its "Min Target" when "Min Value" is reach and its "Max Target" when "Max Value" is reached. You don't need to use minimum and maximum value and target. In fact they are completely unrelated and are named like that only to imply the intended use of toggling something in the map based on a player count threshold. You can use "dmg" key to get current number of players e.g. by using [trigger_copyvalue](../trigger_copyvalue) or [trigger_condition](../trigger_condition).</div>
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Min Value</b></span> <kbd  class="tooltip" data-tooltip="integer">frags</kbd> :
Player-count required to trigger "Min Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Value</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Player-count required to trigger "Max Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Min Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger when "Min Value" is reached. Trigger use-type is 'On'
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Target to trigger when "Max Value" is reached. Trigger use-type is 'On'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="String">message</kbd> :
If set, only players by that targetname will cause the game_player_counter to count up/down. It's not possible to set a targetname on a player before he connects, so don't ask me how to make use of this.
</div>
</div>
<div class="notices blue" markdown="1">Unlike other entities, game_player_counter sends 'On' output instead of 'Toggle'.</div>
<div class="notices blue" markdown="1">You can access current player value of this entity by refering to "dmg" keyvalue.</div>
<div class="notices red" markdown="1">This entity is partially broken, it doesn’t work correctly after a level change for instance, and you cannot access the current number of connected players with it. You can instead replace this entity’s behaviour with a trigger_entity_iterator and a game_counter.</div>
