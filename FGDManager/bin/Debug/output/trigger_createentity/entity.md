---
title: trigger_createentity
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity allows you to create any entity at runtime as you trigger it. Set the desired classname and new targetname, if wanted, then disable Valve Hammer Editor's smart edit-mode to set keyvalues to initialize the to-be-spawned entity with. For key, write a minus ('-') followed by the key you want to set, and as value, set the value you want that key to be set to. Alternatively, you can copy a keyvalue from another entity. To do this, prepend a plus ('+') instead of a minus and write the name of the entity to copy from as the value instead of the value itself. You cannot copy from entity-specific keyvalues, as these cannot be read from the outside. Examples: Key "-health" with value "50.0" to set the health-keyvalue to a value of 50.0. Key "-message" with value "Hello world!" to set the message-keyvalue to "Hello world!". Key "+model" with value "crate_6" to copy the model-keyvalue of the entity by the targetname "crate_6" to the model-keyvalue of the spawned entity.</div>
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
Set name of {{ entname }} so other entities can trigger it to spawn entity. Every trigger use-type works uniformly. Can be kill-targeted but already spawned entities stays.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger whenever a entity is spawned. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
This is handled by spawned entities for some reason. Specify entity to remove when any entity spawned with this {{ entname }} is triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Child Classname</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszCrtEntChildClass</kbd> :
Name of an entity-class to determine what type of entity to spawn. This is required.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Child Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszCrtEntChildName</kbd> :
New targetname to set on the spawned entity. This is optional. You can also copy the targetname of another entity using the method explained above and leave this empty instead.
</div>
</div>
<div class="notices blue" markdown="1">Spawnflags actually are a keyvalue called spawnflags, so you will have to use that instead of setting spawnflags on the trigger_createentity itself. Value of 1 means 1st checkbox is checked; value of 2 means 2nd checkbox is checked; value of 4 means 3rd checkbox is checked; value of 8 means 4th checkbox is checked. As you can see, the value doubles with every further checkbox. To combine spawnflags, add up the values. For example, a value of 5 would mean that the 1st and 3rd checkbox are checked, because it combines only of 1 (1st checkbox) plus 4 (3rd checkbox).</div>
<div class="notices blue" markdown="1">If you try to create a brush-entity, make sure you have another brush-entity to copy its model from. Also make sure that that entity has an origin-brush tied to it then, or your new entity will be spawned with an offset from the center of the coordinate system to the entity which's model you copy.</div>
<div class="notices blue" markdown="1">If you try to copy the model-keyvalue from another entity, but the other entity is not found, the trigger_createentity will refuse to spawn the entity, because spawning a brush-entity with an empty model is prone to crashing the game.</div>
<div class="notices blue" markdown="1">Note that the call to finally spawn the created entity is done after all keyvalues have been set, as normally is the case in the game engine. Should the keyvalues you have set require for unprecached model-files to be precached, the game will shut down. This can, for example, happen when you spawn a func_breakable with a material which requires metal-gibs to be precached, but have not otherwise been detected to be required in the map. In that case you'd have to precache them with a custom_precache entity, or make sure you'd have at least one func_breakable which had material-type "metal".</div>
