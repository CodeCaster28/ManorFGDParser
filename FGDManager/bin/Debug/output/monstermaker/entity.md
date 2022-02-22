---
title: monstermaker
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Used to spawn monsters (works with other stuff too e.g. items!). Very limited. Use [squadmaker](../squadmaker) instead for better results and more control. You must specify monster type, otherwise it will crash the game with "Spawned a NULL entity!" error message.</div>
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
Set name of {{ entname }} so other entities can trigger it to spawn monsters. With 'Cyclic' flag disabled the behaviour is based on trigger use-type: 'On'- turn spawner on, 'Off'- turn spawner off, 'Toggle'- toggle spawner. With 'Cyclic' flag enabled every trigger use-type works uniformly to spawn a single monster. Can be kill-targeted but monsters already spawned are not removed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target On Release</b></span> <kbd  class="tooltip" data-tooltip="string">target</kbd> :
Entity to trigger whenever a monster is spawned. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Type</b></span> <kbd  class="tooltip" data-tooltip="string">monstertype</kbd> :
Set the classname of the monster, weapon, item, ammunition or whatever else may be spawned by {{ entname }} without working incorrectly here. You must specify monster type, otherwise it will crash the game with "Spawned a NULL entity!" error message.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Childrens' Name</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
If set, everything that is spawned by this {{ entname }} will receive this as it's targetname.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster count </b></span> <kbd  class="tooltip" data-tooltip="integer">monstercount</kbd> :
Total amount of monsters which can be spawned by this {{ entname }}. If this value runs, the {{ entname }} won't spawn anything anymore. Setting this to '-1' means an endless supply.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Make Player Allys</b></span> <kbd  class="tooltip" data-tooltip="choices">respawn_as_playerally</kbd> :
Set whether the spawned monster is an ally or a foe of the players.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default (0)</li>
<li><b>1 </b> : Opposite (1)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Frequency</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay, in seconds, between spawns.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max live children</b></span> <kbd  class="tooltip" data-tooltip="integer">m_imaxlivechildren</kbd> :
Maximum amount of spawns by this {{ entname }} which may exist at a time. Note that for monsters, they will be counted as a live child till their corpse has faded out.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Health</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
If set, this will overwrite the monster's default health value managed by the skill configuration.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Name</b></span> <kbd  class="tooltip" data-tooltip="string">path_name</kbd> :
Name of first [path_waypoint](../path_waypoint) to go to.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start ON</span> : The {{ entname }} will start on and start spawning as soon as the map loads.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Cyclic</span> : Changes the {{ entname }} toggle-behaviour to a single-fire-behaviour. With this flag set, the entity will spawn one time every time it is fired.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">MonsterClip</span> : Monsters spawned by a {{ entname }} with this flag set will be blocked by the [func_monsterclip](../func_monsterclip) brush entity.</li>
<li class="imagepadding" markdown="1"><b>1024 </b> : <span style="color:#9fc5e8;">No Respawn (Collectible)</span> : If the spawned entity is a weapon, an item or ammunition, it won't respawn after being collected when this flag is set.</li>
</ul>
</div>
<div class="notices red">You must specify monster type, otherwise it will crash the game with "Spawned a NULL entity!" error message.</div>
