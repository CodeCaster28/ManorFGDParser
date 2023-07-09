---
title: trigger_changelevel
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity which causes a level-change when entered, without showing up a scoreboard. Scores are no transferred. Can be set to only react to triggering. You can add master keyvalue manually to this entity.</div>
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
Set name of {{ entname }} so other entities can trigger it to change level. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: Need item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_required</kbd> :
Item(s) (names separated by spaces) required to use this entity. Refers to "Item name" value of item_inventory.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: Need item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">item_group_required</kbd> :
Groups (separated by spaces), in which carried items belong to, required to use this entity. Refers to "Item group name" value of item_inventory.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: Item count in group need have (0 = all)</b></span> <kbd  class="tooltip" data-tooltip="integer">item_group_required_num</kbd> :
Minimal number of items, that belong to specified group, required to use this entity. Use with "Inventory: Need item(s) from group(s)" keyvalue. Value of '0' means that all items from current group are required.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: CAN'T have item</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_canthave</kbd> :
Items in player inventory that will fail the test, and disallow usage of this entity. Refers to "Item name" value of item_inventory.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: CAN'T have item from group</b></span> <kbd  class="tooltip" data-tooltip="string">item_group_canthave</kbd> :
Items in player inventory, which belong to specified group, that will fail the test, and disallow usage of this entity. Refers to "Item group name" value of item_inventory.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inventory: Item count in group CAN'T have (0 = all)</b></span> <kbd  class="tooltip" data-tooltip="integer">item_group_canthave_num</kbd> :
Minimal number of items in player inventory, which belong to specified group, that will fail the test, and disallow usage of this entity. Refers to "Item group name" value of item_inventory. Value of '0' means no single item from current group should be equipped to pass the test.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on use triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_use_triggers</kbd> :
If set to 'Yes' item's trigger targets from 'Target: On use (by trigger)' will not be triggered when item is used by this entity.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Drop item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_drop_item_name</kbd> :
Items to force-drop when the test result is positive, and entity is used successfully. Refers to "Item name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Drop item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_drop_item_group</kbd> :
Items to force-drop, that belong to specified group, when the test result is positive and entity is used successfully. All items from this group will be dropped. Refers to "Item group name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on drop triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_drop_triggers</kbd> :
If set to 'Yes' item's trigger targets from "Target: On drop" will not be triggered when item is dropped by this entity with "Drop items(s)" events above.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Return item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_return_item_name</kbd> :
Items to return to their starting positions when test result is positive. Refers to "Item name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Return item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_return_item_group</kbd> :
Items, that belong to specified group, to return to their starting positions when test result is positive. All items from this group will be returned. Refers to "Item group name" value of item_inventory. Multiple group names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on return triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_return_triggers</kbd> :
If set to 'Yes' item's trigger targets from "Target: On return" will not be triggered when item is returned by this entity with "Return items(s)" events above.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Destroy item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_destroy_item_name</kbd> :
Items to remove when test result is positive. Refers to "Item name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Destroy item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_destroy_item_group</kbd> :
Items, that belong to specified group, to remove when test result is positive. All items from this group will be removed. Refers to "Item group name" value of item_inventory. Multiple group names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on destroy triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_destroy_triggers</kbd> :
If set to 'Yes' item's trigger targets from "Target: On Destroy" will not be triggered when item is destroyed by this entity with "Destroy items(s)" events above.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: Inventory rules failed</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_fail</kbd> :
Entity to trigger whenever test result is negative.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Template Model Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_usemodel</kbd> :
For Brush entities: sets brush model template of this entity. Set it to the name of other brush entity (now called a template) and it's brush model will be used instead. Templates might save server resources by "copying" single brush entity (template identified by name) and using it in multiple places (can be used for entities like tables, columns, barrels, cars e.t.c.). Also one template occupies only one entity slot when compiling a map, no matter how many entities refers to it. For model-based point entities: copy display model of specified entity, to use it's model instead. Using "Custom model" is more appropriate in most cases, however, when it's not possible, use "ZHLT Copy Lighting From Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Copy Lighting From Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_copylight</kbd> :
For Brush entities: copies light info from specified entity. This can be useful when we want this entity to be light up in a similar way the other entity of the map is, e.g. we have few func_pushables on map, and they are lit differently, tough they can be moved (and lightning is not updated on dynamic entities), it may looks shabby. With this keyvalue we can prevent this making all func_pushables received light in a same way. Another example: we have few windows in corridor (e.g. func_breakables), all of them receive a light in acceptable way, but the last window receive part of the light from another room and breaking whole atmosphere. We can set this window "Copy Lightning From Target" to any other window to fix this. Note that this can be also used for completely different entities, so we copy lightning from func_door to func_breakable as well.
For model-based point entities: if model lightning does not satisfy you (e.g. it's too dark) you can specify a name of entity here to copy it's lightning values- it can be other model-based entity or simply [info_target](../info_target).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Disable Clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Enable or disable collision of entity.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Keep default collision.</li>
<li><b>1 </b> : Always non-solid : This makes entity non-solid- all collision info from this entity will be ignored. Use it in case when entity have no build-in collision disabling ability (e.g. by selecting "Passable" flag in func_door) and you much desire to disable collision for this entity.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_invisible</kbd> :
Brush entities only. Determines if entity should be visible.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Visible (default)</li>
<li><b>1 </b> : Invisible</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Custom Shadow (when opaque)</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_customshadow</kbd> :
Opaque brush entities only. If "ZHLT Ligth Flags" of this entity uses any of the option with 'Opaque' word, this will allow to customize shadow dropped by this entity. Value format: [0 - 1.0] [0 - 1.0] [0 - 1.0], use three values for color or only one for transparency.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map (when translucent)</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_embedlightmap</kbd> :
Transparent brush entities only. Set it to 'Yes' and this transparent entity will take a light from environment making it looks much more natural. Use it when entities (e.g. glass represented by func_wall) omits lightning from surrounding. Note that this is expensive so shouldn't be used too often, but resolution of those lightmaps can be controlled by keyvalue explained below.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default)</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map Resolution</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_embedlightmapresolution</kbd> :
Value of power of two that controls the resolution of embedded lightmaps of transparent textures (see keyvalue above). Higher value for better optimization. Default and recommended value is 4.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New map name</b></span> <kbd  class="tooltip" data-tooltip="string">map</kbd> :
Name of the map to switch to.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Landmark name</b></span> <kbd  class="tooltip" data-tooltip="string">landmark</kbd> :
Landmark used to work as an orientation point between two maps in a center of both trigger_changelevels of maps. It doesn't work in Sven Co-op, cause players starts at spawn points normally when new map loads.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Players take inventory to new map</b></span> <kbd  class="tooltip" data-tooltip="choices">keep_inventory</kbd> :
If set to "Yes", player's ammo, armor and weapons are carried to target map.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Change Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">changetarget</kbd> :
Unknown purpose. Maybe it triggers a target in goal map.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay before change target</b></span> <kbd  class="tooltip" data-tooltip="string">changedelay</kbd> :
Delays "Change Target" action, whatever that action does.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Percentage of players needed</b></span> <kbd  class="tooltip" data-tooltip="string">percent_of_players</kbd> :
Percentage of total amount of players needed to reach this point in order for level change.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">No Intermission</span> : Unknown purpose.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">USE Only</span> : Cause trigger_changelevel to work like point entity, which means it need to be triggered to perform map change.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">No CVAR override</span> : Do not override CVARs of destination map.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Trigger_changelevel supports to have a master (even if it is not listed in object properties). You can set it by adding "targetname" key with SmartEdit mode disabled.</div>
