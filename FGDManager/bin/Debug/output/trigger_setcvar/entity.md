---
title: trigger_setcvar
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which allows you to set several control variables ("CVars") such as sv_gravity. To do so, give it a name, set which CVar to change as well as the new desired value and trigger it.</div>
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
Set name of {{ entname }} so other entities can trigger it to set cvar. Only 'On' and 'Toggle' trigger use-types are accepted. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CVAR (only these are allowed)</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iszCVarToChange</kbd> :
Set the name of the CVar to change.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"mp_allowmonsterinfo"</b>  : Allow players to see information about monsters they see. Disabling this will cause confusion over who is allied and who are enemies.</li>
<li><b>"mp_banana"</b>  : Allow players to throw banana bombs.</li>
<li><b>"mp_barnacle_paralyze"</b>  : Deny players to use weapons whilst caught by a Barnacle.</li>
<li><b>"mp_disablegaussjump"</b>  : Disable vertical knock back caused by the gauss cannon's charge up shot. This can sometimes be used to exploit maps or get places players aren't meant to go. This is a direct copy of mp_allowgaussjump, which for some reason got inverted in Sven Co-op 3.0.</li>
<li><b>"mp_disable_autoclimb"</b>  : Deny players to use the auto-climb feature.</li>
<li><b>"mp_disable_pcbalancing"</b>  : Disable player weapon damage balancing according to the mp_pcbalancing_factorlist setting.</li>
<li><b>"mp_disable_player_rappel"</b>  : Deny players to use the Barnacle grapple on each other.</li>
<li><b>"mp_dropweapons"</b>  : Allow players to drop weapons and ammo. Miniguns and shock rifles can always be dropped.</li>
<li><b>"mp_falldamage"</b>  : Specify how players receive damage from falling. 1: None, players never receive damage from falling. 0: Simple, a maximum of 10 points of damage is dealt. 1: Realistic, the speed and distance of the fall defines how much damage is dealt.</li>
<li><b>"mp_flashlight"</b>  : Allow players to use their flash light. Requires a HEV suit (provided by default).</li>
<li><b>"mp_forcerespawn"</b>  : Force players to respawn after they die. Disabling this allows players to respawn when they are ready to (recommended).</li>
<li><b>"mp_fraglimit"</b>  : Map changes after someone obtains this many points. Not recommended in most cases.</li>
<li><b>"mp_grapple_mode"</b>  : Players are pulled to monsters bigger than headcrabs when grappled rather than the monster being pulled to a player.</li>
<li><b>"mp_monsterpoints"</b>  : Let players get points for killing monsters, this can be toggled on or off, set it to 0 if you don't want players to get frags for killing monsters.</li>
<li><b>"mp_noblastgibs"</b>  : Deny monsters to be gibed (ripped apart) when killed with explosives.</li>
<li><b>"mp_nomedkit"</b>  : All players by default start the map with a Med Kit that lets them heal other players and NPC's, using this command stops the players starting with the Med Kit. You can let the players pick up the Med Kit in the map by placing a weapon_medkit somewhere in the map.</li>
<li><b>"mp_no_akimbo_uzis"</b>  : Deny players to have akimbo uzis. This may help balance power on some maps or large player capacities.</li>
<li><b>"mp_npckill"</b>  : Set the behaviour of killing allied NPCs. This replaces the old killnpc setting. 0: Disallows allied NPCs to be killed. 1: Allows allied NPCs to be killed. 2: Allows allied NPCs to be killed by anything other than players, allied NPCs, and human passive class.</li>
<li><b>"mp_pcbalancing_factorlist"</b>  : Balance player weapon damage based on the amount of players present based on a sequence of multipliers. The default value (1.0;1.8;1.4;1.2;1.1;1.0) means damage multipliers of 1x for 1 player, 1.8x for 2 players, 1.4x for 3 players, 1.2x for 4 players, 1.5x for 5 players, and 1x for 6 or more players.</li>
<li><b>"mp_respawndelay"</b>  : The time (seconds) a player must wait before respawning. This is 5 seconds by default to help encourage use of the reviving feature.</li>
<li><b>"mp_timelimit"</b>  : Map changes after this amount of time (minutes) if the map hasn't been completed already. Time limit is infinite if set to 0, but the server's mp_timelimit_empty will end your map early if there are no players present.</li>
<li><b>"mp_weaponstay"</b>  : Weapons can be picked up multiple times, with the exception of miniguns. Disabling this will result in a couple of players taking all the weapons leaving others with nothing.</li>
<li><b>"mp_weapon_respawndelay"</b>  : Set a custom respawning delay for weapons. -2: Use game default delay. -1: Never respawn. 0: Instantly respawn. >0: Respawn after this many seconds. Individual entities within the map can override this global setting.</li>
<li><b>"mp_ammo_respawndelay"</b>  : Set a custom respawning delay for ammo. -2: Use game default delay. -1: Never respawn. 0: Instantly respawn. >0: Respawn after this many seconds. Individual entities within the map can override this global setting.</li>
<li><b>"mp_item_respawndelay"</b>  : Set a custom respawning delay for items. -2: Use game default delay. -1: Never respawn. 0: Instantly respawn. >0: Respawn after this many seconds. Individual entities within the map can override this global setting.</li>
<li><b>"npc_dropweapons"</b>  : NPC's will drop their weapon upon death.</li>
<li><b>"skill"</b>  : The default skill level your server will use. Maps can override this in their configuration. 0: Always let the map choose. 1: Easy, enemies are easy to kill, players are hard to kill. 2: Hard, enemies are hard to kill, players are easy to kill. 3: Realistic, enemies are easy to kill, players are very easy to kill - enables realistic weapon damage. If you want to change a skill variable, make sure to append either 1, 2 or 3 to determine the according skill level. You can also omit the digit or put a hash ('#') instead, in order to have all 3 skill-variants of the skill-CVar changed and the according damage-, health- or miscellaneous value be updated to the game engine. If you change the "skill"-CVar itself, all skill-CVars will be reread, which is a relatively expensive operation, so better don't spam it.</li>
<li><b>"sk_"</b> : sk_* (see skill.cfg) : All skill variables can be put here e.g. 'sk_headcrab_health'. For complete list of available 'sk_' variables see svencoop/skill.cfg file.</li>
<li><b>"sv_ai_enemy_detection_mode"</b>  : Allow NPC's to scan for enemies and fight even while no players are near enough.</li>
<li><b>"sv_accelerate"</b>  : The speed players accelerate while on ground.</li>
<li><b>"sv_airaccelerate"</b>  : The speed players accelerate while in the air.</li>
<li><b>"sv_friction"</b>  : The amount of friction created by the ground.</li>
<li><b>"sv_gravity"</b>  : The amount of gravity (maximum units/second).</li>
<li><b>"sv_maxspeed"</b>  : The speed players can run on ground -- excluding aid from various triggers and effects (explosions etc) that can allow players to move faster.</li>
<li><b>"sv_wateraccelerate"</b>  : The speed players accelerate while underwater.</li>
<li><b>"sv_waterfriction"</b>  : Whether friction also applies to water.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Value</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Specify the new CVar value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after set</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Entity to trigger whenever a CVar is set. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Which CVARs to set</b></span> <kbd  class="tooltip" data-tooltip="choices">SetType</kbd> :
Allows to filter CVAR Types.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : All</li>
<li><b>1 </b> : Engine</li>
<li><b>2 </b> : Angelscript</li>
</ul>
</div>
</div>
</div>
<div class="notices blue" markdown="1">Players and the server console will receive a console message reading which CVar has changed and to what value. If you set a skill-CVar, only the server console will get information about the change printed.</div>
