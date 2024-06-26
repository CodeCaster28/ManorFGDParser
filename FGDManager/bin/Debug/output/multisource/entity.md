---
title: multisource
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The multisource entity is an only master-entity which starts disabled/locked and sets its state to be enabled/unlocked when all entities having the multisource entity as their target (or killtarget) gets triggered. It is hence also referred to as an 'AND-Gate'. The multisource can be used in multiple ways:<ul><li>As a master entity: "locking" entities, triggers, buttons and doors. You can lock or temporary disable some entities by specifying 'multisource' name as a "master" entity of trigger/button/door e.t.c. When 'multisource' is triggered by all possible triggers (when all entities having this multisource as a target has triggered it) the trigger/button/door is unlocked (released). Func_button has special ability to revert it's trigger signal when button resets (it's not pressed anymore, see "Delay Before Reset" keyvalue in func_button), that means the trigger/button/door gets locked again and awaits multisource be enabled again. You can create two buttons that unlocks the door but only for limited amount of time, or func_trigger that activates button only when someone step into it e.t.c. Entities that support master keyvalue:<ul><li>info_player_deathmatch, info_player_dm2 -> disable (re)spawning here until unlocked.</li><li>func_door, func_door_rotating, func_water, momentary_door -> disable opening until unlocked.</li><li>trigger_once, trigger_multiple, trigger_monsterjump, trigger_teleport, trigger_hurt, trigger_changelevel -> disable triggering until unlocked.</li><li>game_counter, game_counter_set, game_end, game_player_hurt, game_score, game_player_team, game_team_master, game_team_set, game_text, game_zone_player -> disable until unlocked.</li><li>button_target, func_button, func_rot_button, momentary_rot_button -> disable button pressing until unlocked.</li></ul></li><li>As a multiple-triggering entity: multisource will trigger it's target whenever it's triggered by all possible triggers (when all entities having this multisource as a target has triggered it). Func_button has special ability to revert it's trigger when button resets (it's not pressed anymore, see "Delay Before Reset" keyvalue in func_button), that means the multisource can be triggered again by pressing that button(s) and this very multisource can trigger it's target again, even when passing signal through mutli_manager! With this feature you can create well-known "twin buttons" that must be pressed by two players simultaneously in order to open the door.</li><li>As a single-triggering entity: but what if we need single-triggering entity instead of multiple triggering, even if multisource can be enabled/disabled repeatedly because of buttons? The solution for this is triggering trigger_relay entity before triggering goal entity, e.g. when mutlisource is targeting door to be opened or multi_manager or anything else, we should add trigger_relay between multisource and goal door/multi_manager/any other entity, like: 'multisource' --> 'trigger_relay' --> 'some entity' instead of directly 'multisource' --> 'some entity' triggering. The state of trigger_relay should be set to "On" to enable triggered entity (or entities) forever, or to "Off" to turn those entities off. You can create two buttons that need to be pressed simultaneously by two players in order to open the door. When the door opens, button can be still pressed but the door won't be triggered again.</li></ul></div>
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
Set name of {{ entname }} so other entities can refer to it as their master or trigger it as one of required inputs to enable it. Every trigger use-type works uniformly. Should not be kill-targeted because it breaks it's functionality. When using a multisource as a master to lock another entity, this multisource's targetname value must be put in the master value for entity-to-be-locked in order for the multisource to lock it, ensuring that some other entity is set to target this multisource.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger in every instant after multisource has changed its state to be enabled. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global State Master</b></span> <kbd  class="tooltip" data-tooltip="string">globalstate</kbd> :
If set, the multisource entity will read its initial state from the global state variable specified here on map load. See [env_global](../env_global) for more information about this. You should not have any entities targeting this multisource entity when using this.
</div>
</div>
<div class="notices blue" markdown="1">If a valid entity does not target a multisource that is being used as a master, or the targetting entity no longer exists, the multisource will not lock entities until something is able to target it.</div>
<div class="notices blue" markdown="1">If you change the target of an entity targeting a multisource entity, the multisource entity will automatically no longer expect input from it.</div>
<div class="notices blue" markdown="1">Note that entity takes only "targets" and "killtargets" keys into account, so other triggering inputs like "TriggerTarget" won't work. In that case use [trigger_relay](../trigger_relay) like a bridge between entity with atypical-triggering output and multisource.</div>
<div class="notices red" markdown="1">Kill Target is count as a normal targetting in multisource, do not "kill target" this entity or it won't work expecting a kill input.</div>
