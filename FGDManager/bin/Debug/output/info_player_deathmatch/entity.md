---
title: info_player_deathmatch
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
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
If set, every player spawning here will get this string as his/her targetname.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Targetname required on the player to spawn here, or targetname not allowed to spawn here, if "Invert filter" flag is set.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the multisource entity that (temporary) disables this {{ entname }}. If master specified the {{ entname }} won't spawn anyone here. When multisource entity is triggered/beign triggering by all possible inputs, the {{ entname }} will be enabled and ready to spawn players here. When multisource lost at least one input signal, the entities becomes disabled again.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Repel Speed</b></span> <kbd  class="tooltip" data-tooltip="string">frags</kbd> :
Speed, in units per second, with which the player will rappel down, if that is enabled.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Set the use-type with which the entity specified in "Target" will be fired (after someone spawns here).
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
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
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>2 </b> : Start Off : If set, {{ entname }} will be disabled on map load. Players cannot spawn here until the {{ entname }} is triggered by another entity targetting it.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Repel Spawn : Player will spawn rappeling down using a rope (like rappeling soldiers) until arriving at the ground.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Filter player targetname : If set, only players having their targetname match the "Filter player targetname" can spawn here.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : Invert Filter : If set along with "Filter player targetname", only players having a different targetname than set by "Filter player targetname" can spawn here.</li>
<li class="imagepadding" markdown="1"><b>32 </b> : Trigger on spawn : If set, the {{ entname }} will trigger its target whenever a player respawns at its position.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
