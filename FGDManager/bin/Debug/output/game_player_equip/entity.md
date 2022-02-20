---
title: game_player_equip
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The game_player_equip entity is a powerful entity for managing player weapons/items/ammo loadout. You can gradually enable more and more game_player_equip entities to increase the players' arsenal as your map progresses, or allow players to trigger it directly. This entity exhibits strange behaviour when used incorrectly, so set it up carefully: Basically, you disable smart edit mode when viewing its properties in Valve Hammer Editor, then add new keyvalues, whereas the key's name be the name of the weapon-/item-/ammo-entity to supply, and value the quantity in which it shall be provided, per player. When providing an uzi, provide either weapon_uzi or weapon_uziakimbo, never both. For weapon quantity, always set 1. Never supply more than the player can pick up/carry. If at least one game_player_equip entity is enabled, the default weapon and ammo loadout from your map's config file will be ignored entirely. So if your map is using game_player_equip entities, you will probably want to have one game_player_equip entity that is always enabled to provide a default loadout. Whether a game_player_equip entity is enabled or not depends on the state of its master. If no master is set, it's always enabled. When the game_player_equip is triggered normally, it will equip the activating player. Be careful with that, as giving a player things he cannot pick up/carry will spawn and lie around till collected, possibly flooding the server.</div>
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
Set name of {{ entname }} so other entities can trigger it to apply inventory changes. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Set the targetname of a player to be the only one to ever receive equipment from this game_player_equip, if the 'Filter playername'-flag is set. This can be used for creating maps with roleplaying (when paired with the CVar mp_dropweapons set to '0'), or preventing a player from using the same triggerable game_player_equip entity multiple times per life.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when equipment is applied.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Team Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Currently unusable.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Equip mode</b></span> <kbd  class="tooltip" data-tooltip="choices">equipmode</kbd> :
Set equipping mode.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Give items : Provide players with items/weapons/ammo as described above.</li>
<li><b>1</b> : Modify inventory : Allows to change .cfg file inventory and enable "Inventory Mode" to be used.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory mode</b></span> <kbd  class="tooltip" data-tooltip="choices">inventorymode</kbd> :
Allows advanced inventory manipulation, changes player's equip on respawn.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Set items : Overrides inventory with given items.</li>
<li><b>1</b> : Add items : Adds given items to inventory. If any item already exists, the values are sum together.</li>
<li><b>2</b> : Subtract items : Removes given items from inventory. If any item already exists, the values are substracted from them.</li>
<li><b>3</b> : Remove items : Removes given items from inventory (if they exists).</li>
<li><b>4</b> : Restock items : Set items if given value is greater than current value.</li>
<li><b>5</b> : Limit items : Set items if given value is lesser than current value.</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">USE Only</span> : If set, the game_player_equip entity will not equip respawning players, but only react to direct triggering, equipping its activator. This makes its master obsolete.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Filter Playername</span> : If selected, this game_player_equip will only equip players with a targetname 'Player targetname' (see below).</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Re-Equip on Use</span> : If set, the game_player_equip entity will strip all weapons/ammo from the triggering player and then re-equip him. This is useful for preventing the aforementioned overflow.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">Append Map CFG</span> : If selected, also give weapons specified in this map configuration file (mapname.cfg) instead of ignoring it.</li>
</ul>
</div>
