---
title: trigger_multiple
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A simple brush-based trigger which triggers its target when a players enters it and whenever something enters it or is still inside of it when its delay before reset runs out. In simple words, this entity works as the [trigger_once](../trigger_once) does, except this can be triggered multiple times.</div>
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger when {{ entname }} is touched (or when stop touched if "Fire On Exit" flag is selected).
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when {{ entname }} is touched (or when stop touched if "Fire On Exit" flag is selected).
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }}. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name In Filter</b></span> <kbd  class="tooltip" data-tooltip="string">tinfilter</kbd> :
Semicolon-separated list of targetnames to either be forbidden or required (specified in "Name In Filter Type") on the caller-entity. Can also specify only one.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name In Filter Type</b></span> <kbd  class="tooltip" data-tooltip="choices">tinfiltertype</kbd> :
Set whether to forbid or require certain targetname(s) (specified in "Name In Filter") on the entity which tries to trigger me in order to accept triggering.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Exclude</li>
<li><b>1</b> : Include</li>
</ul>
</div>
</div>
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Class In Filter</b></span> <kbd  class="tooltip" data-tooltip="string">cinfilter</kbd> :
Semicolon-separated list of classnames to either be forbidden or required (specified in "Class In Filter Type") on the caller-entity. Can also specify only one.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Class In Filter Type</b></span> <kbd  class="tooltip" data-tooltip="choices">cinfiltertype</kbd> :
Set whether to forbid or require certain classname(s) (specified in "Class In Filter") on the entity which tries to trigger me in order to accept triggering.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Exclude</li>
<li><b>1</b> : Include</li>
</ul>
</div>
</div>
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name Out Filter</b></span> <kbd  class="tooltip" data-tooltip="string">toutfilter</kbd> :
Semicolon-separated list of targetnames to either be forbidden or required (specified in "Name Out Filter Type") on targeted entities. Can also specify only one.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name Out Filter Type</b></span> <kbd  class="tooltip" data-tooltip="choices">toutfiltertype</kbd> :
Set whether to forbid or require certain targetname(s) (specified in "Name Out Filter") on the target entities.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Exclude</li>
<li><b>1</b> : Include</li>
</ul>
</div>
</div>
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Class Out Filter</b></span> <kbd  class="tooltip" data-tooltip="string">coutfilter</kbd> :
Semicolon-seperated list of classnames to either be forbidden or required (specified in "Class Out Filter Type") on targeted entities. Can also specify only one.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Class Out Filter Type</b></span> <kbd  class="tooltip" data-tooltip="choices">coutfiltertype</kbd> :
Set whether to forbid or require certain classname(s) (specified in "Class Out Filter") on the target entities.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Exclude</li>
<li><b>1</b> : Include</li>
</ul>
</div>
</div>
</div>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<span style="color:#cae4fc;"><b>Inventory Rules</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
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
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
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
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
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
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
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
</div>
</div>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<span style="color:#cae4fc;"><b>ZHLT Keyvalues</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
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
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
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
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
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
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
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
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Path</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Non functional.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the [multisource](../multisource) entity that (temporary) disables this {{ entname }}. If master is specified the {{ entname }} will be disabled and will not work. When [multisource](../multisource) entity is triggered/being triggering by all possible inputs, the {{ entname }} will work again. When [multisource](../multisource) lost at least one input signal, the entities becomes disabled again.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound style</b></span> <kbd  class="tooltip" data-tooltip="choices">sounds</kbd> :
Non functional.
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Sound</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Message (set sound too!)</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Non functional.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Allow tiny monsters (insects/hornets)</b></span> <kbd  class="tooltip" data-tooltip="Choices">tiny_monsters</kbd> :
If set to 'Yes', monsters like cockroaches can trigger this entity as well as other monsters.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
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
<span style="color:#9fc5e8;"><b>Delay before reset</b></span> <kbd  class="tooltip" data-tooltip="integer">wait</kbd> :
Time, in seconds, the trigger_multiple can fire it's target again after touched.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Monsters</span> :  If set, monsters can trigger this but only works when monster is moving within trigger.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">No Clients</span> : If set, players won't be able to trigger this.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Pushables</span> : If set, [func_pushable](../func_pushable) entities can trigger this.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">Everything else</span> :  If set, everything other than monsters, clients and pushables can trigger this. Does not exclude the above.</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">Fire On Enter</span> : If set, trigger_multiple will fire on initial entry and not continuously while touching the entity, requiring re-entry to trigger again.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">Fire On Exit</span> :  If set, {{ entname }} will trigger as soon as something that entered it left it, instead of the instant something enters it.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices red" markdown="1">Monsters are only able to trigger brush trigger entities while moving inside of them.</div>
