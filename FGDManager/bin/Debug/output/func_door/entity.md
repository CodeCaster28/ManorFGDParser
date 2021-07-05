---
title: func_door
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
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Global name of entity, allows to have one entity in the multiple maps (e.g. elevator in map1 and map2 have the same "Global Entity Name" which tells the engine to treat those entities as a one single entity, so all elevator settings, positions, actions e.t.c. are copied to another map in a moment of map transitions.
</div>
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
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Same as target, except that this supposedly causes the specified entity/entities to be removed from the game. Not all entities which have a target to trigger will also handle killtarget. You may want to use a [trigger_relay](../trigger_relay) to make sure it is working.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name In Filter</b></span> <kbd  class="tooltip" data-tooltip="string">tinfilter</kbd> :
Semicolon-seperated list of targetnames to either be forbidden or required (specified in "Name In Filter Type") on the caller-entity. Can also specify only one.
</div>
<div class="entityentry" markdown="1">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Class In Filter</b></span> <kbd  class="tooltip" data-tooltip="string">cinfilter</kbd> :
Semicolon-seperated list of classnames to either be forbidden or required (specified in "Class In Filter Type") on the caller-entity. Can also specify only one.
</div>
<div class="entityentry" markdown="1">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name Out Filter</b></span> <kbd  class="tooltip" data-tooltip="string">toutfilter</kbd> :
Semicolon-seperated list of targetnames to either be forbidden or required (specified in "Name Out Filter Type") on targeted entities. Can also specify only one.
</div>
<div class="entityentry" markdown="1">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Class Out Filter</b></span> <kbd  class="tooltip" data-tooltip="string">coutfilter</kbd> :
Semicolon-seperated list of classnames to either be forbidden or required (specified in "Class Out Filter Type") on targeted entities. Can also specify only one.
</div>
<div class="entityentry" markdown="1">
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
If set to 'Yes' item's trigger targets from 'Target: On use (by trigger)' will not be fired when item is used by this entity.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
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
If set to 'Yes' item's trigger targets from "Target: On drop" will not be fired when item is dropped by this entity with "Drop items(s)" events above.
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
<span style="color:#9fc5e8;"><b>On pass: Return item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_return_item_name</kbd> :
Items to return to their starting positions when test result is positive. Refers to "Item name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Return item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_return_item_group</kbd> :
Items, that belong to specified group, to return to their starting positions when test result is positive. All items from this group will be returned. Refers to "Item group name" value of item_inventory. Multiple group names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on return triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_return_triggers</kbd> :
If set to 'Yes' item's trigger targets from "Target: On return" will not be fired when item is returned by this entity with "Return items(s)" events above.
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
<span style="color:#9fc5e8;"><b>On pass: Destroy item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_destroy_item_name</kbd> :
Items to remove when test result is positive. Refers to "Item name" value of item_inventory. Multiple item names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Destroy item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">pass_destroy_item_group</kbd> :
Items, that belong to specified group, to remove when test result is positive. All items from this group will be removed. Refers to "Item group name" value of item_inventory. Multiple group names are separated by spaces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>On pass: Ignore item's on destroy triggers?</b></span> <kbd  class="tooltip" data-tooltip="choices">pass_ignore_destroy_triggers</kbd> :
If set to 'Yes' item's trigger targets from "Target: On Destroy" will not be fired when item is destroyed by this entity with "Destroy items(s)" events above.
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
<span style="color:#9fc5e8;"><b>Target: Inventory rules failed</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_fail</kbd> :
Entity to trigger whenever test result is negative.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classification</b></span> <kbd  class="tooltip" data-tooltip="choices">classify</kbd> :
Set the class of the spawned {{ entname }}. Think of how even though zombies and human grunts, by default, both are the players' enemies, yet have a dislike for and attack each other as well. This relation is created through the respective classes of the two entity types. For a complete table of how different classes react to each other, see [monster class relation table](https://wiki.svencoop.com/Class_Relationship_Table).
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : None</li>
<li><b>0 </b> : Object Default : Keep default classification.</li>
<li><b>1 </b> : Machine</li>
<li><b>2 </b> : Player</li>
<li><b>3 </b> : Human Passive</li>
<li><b>4 </b> : Human Military</li>
<li><b>5 </b> : Alien Military</li>
<li><b>6 </b> : Alien Passive</li>
<li><b>7 </b> : Alien Monster</li>
<li><b>8 </b> : Alien Prey</li>
<li><b>9 </b> : Alien Predator</li>
<li><b>10 </b> : Insect</li>
<li><b>11 </b> : Player Ally</li>
<li><b>12 </b> : Player Hornet/Snark</li>
<li><b>13 </b> : Alien Hornet/Snark</li>
<li><b>14 </b> : X-Race</li>
<li><b>15 </b> : X-Race: Shocktrooper/Voltigore</li>
<li><b>16 </b> : Team 1 : Use it to classify to custom team.</li>
<li><b>17 </b> : Team 2 : Use it to classify to custom team.</li>
<li><b>18 </b> : Team 3 : Use it to classify to custom team.</li>
<li><b>19 </b> : Team 4 : Use it to classify to custom team.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Set custom render FX effect. Only works when "Render Mode" is set to different 'Normal'
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Default rendering.</li>
<li><b>1</b> : Slow Pulse : Transparency slow fading in and out in a loop.</li>
<li><b>2</b> : Fast Pulse : Transparency fast fading in and out in a loop.</li>
<li><b>3</b> : Slow Wide Pulse : Transparency slow fading in and out widely in a loop.</li>
<li><b>4</b> : Fast Wide Pulse : Transparency fast fading in and out widely in a loop.</li>
<li><b>9</b> : Slow Strobe : Regular slow appearing/dissapearing.</li>
<li><b>10</b> : Fast Strobe : Regular fast appearing/dissapearing.</li>
<li><b>11</b> : Faster Strobe : Regular very fast appearing/dissapearing.</li>
<li><b>12</b> : Slow Flicker : Random slow appearing/dissapearing.</li>
<li><b>13</b> : Fast Flicker : Random fast appearing/dissapearing.</li>
<li><b>5</b> : Slow Fade Away : Not working. Fading out slowly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>6</b> : Fast Fade Away : Not working. Fading out quickly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>7</b> : Slow Become Solid : Not working. Fading in slowly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>8</b> : Fast Become Solid : Not working. Fading in quickly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>14</b> : Constant Glow : Sprites with 'Glow' render mode only. Disables sprite resizing.</li>
<li><b>15</b> : Distort : Random distortion, looped.</li>
<li><b>16</b> : Hologram (Distort + fade) : 'Random distortion' + 'Pulse' applied, looped.</li>
<li><b>17</b> : Dead Player (DONT USE!)</li>
<li><b>18</b> : Explode (Garg Like)</li>
<li><b>19</b> : Glow Shell : Applies nice animated glowing shell on model. Color can be applied. "FX Amount" manipulates glow shell size.</li>
<li><b>20</b> : ClampMinScale (Sprites)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Render mode determines how this entity is rendered.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Normal rendering. Entity will receive light, except if it is a sprite. "FX Amount" is obsolete when this is used.</li>
<li><b>1</b> : Color : Brush entities only: Instead of rendering the texture, the whole entity will appear in one color, set by "FX Color". "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque.</li>
<li><b>2</b> : Texture : Texture-only rendering. Entity will not receive light. Instead, only the texture will be rendered as is. "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque. This is used for transparent things such as windows. Tip: If you have a window separating a dark and a bright room using only one entity, you can apply a brighter glass texture to the side of the window seen from within the dark room than to the side seen from the bright room. That way, the window's brightness will look realistic from both sides, instead of from just one. Generally, darker rooms require the render amount to be lower, making the glass more transparent, or it would look illogically bright.</li>
<li><b>3</b> : Glow : Sprites only. The sprite will appear in the same size regardless of your distance to it. In addition to that, the further away you are from it, the less visible it will be. (It's only barely visible at about 500 units far away) Good for light coronas. This renders the sprite in additive mode.</li>
<li><b>4</b> : Solid : Brush entities only. All textures of the brush entity starting with '{' will have the last color of their palette (usually blue, black or purple) be rendered fully transparent. This is used for textures with see-through parts, such as grates and railings. Requires "FX Amount" to be set to a value greater than 0, commonly 255.</li>
<li><b>5</b> : Additive : Works just as the "Render Mode" 'Texture', except that the entity's appearance will be added to the background instead of forming a mean. This means, black pixels of textures will be fully transparent, while full-bright pixels are added with a factor of "FX Amount" divided by 255. This is often used for sprites indicating a glowing light, as well as for overlay func_illusionaries to give a computer texture the appearance of having many small, glowing lights, screens and whatever other elements. Render-amount of 255 makes it bright. 0 makes it invisible.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Render amount to use when other than "Render Mode" 'Normal' is used.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Used with "Render Mode" 'Color' and 'Glow' to set color. Also sets color of 'Glow Shell' "Render Mode".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Template Model Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_usemodel</kbd> :
For Brush entities: sets brush model template of this entity. Set it to the name of other brush entity (now called a template) and it's brush model will be used instead. Templates might save server resources by "copying" single brush entity (template identified by name) and using it in multiple places (can be used for entities like tables, columns, barrels, cars e.t.c.). Also one template occupies only one entity slot when compiling a map, no matter how many entities refers to it.
For model-based point entities: copy display model of specified entity, to use it's model instead. Using "Custom model" is more appropriate in most cases, however, when it's not possible, use "ZHLT Copy Lighting From Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Copy Lighting From Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_copylight</kbd> :
For Brush entities: copies light info from specified entity. This can be useful when we want this entity to be light up in a similar way the other entity of the map is, e.g. we have few func_pushables on map, and they are lit differently, tough they can be moved (and lightning is not updated on dynamic entities), it may looks shabby. With this keyvalue we can prevent this making all func_pushables received light in a same way. Another example: we have few windows in corridor (e.g. func_breakables), all of them receive a light in acceptable way, but the last window receive part of the light from another room and breaking whole atmosphere. We can set this window "Copy Lightning From Target" to any other window to fix this. Note that this can be also used for completely different entities, so we copy lightning from func_door to func_breakable as well.
For model-based point entities: if model lightning does not satisfy you (e.g. it's too dark) you can specify a name of entity here to copy it's lightning values- it can be other model-based entity or simply [info_target][../info_target).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Disable Clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Enable or disable collision of entity.
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
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
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
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
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
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
<span style="color:#9fc5e8;"><b>ZHLT Light Flags</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_lightflags</kbd> :
Brush entities only. Changes light casting or receiving setting.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Let the entity decide about lightning setting.</li>
<li><b>1 </b> : Embedded Fix : Disables bleed fix on given entity. Sometimes when entity gets trough the wall, it may get wrong lighting in one of the site. Use this flag when this problem appear.</li>
<li><b>2 </b> : Opaque (blocks light) : May be useful for func_door or func_illusionary to generate shadows. Can also generate shadows on transparent '{' textures with 'Solid' Render Mode (amount: 255). Note that shadow sharpness depends on '-blur' compile value. The blur value of map above is 0.5 (it's 1.5 by default).</li>
<li><b>3 </b> : Opaque + Embedded fix : both 'Opaque' and 'Embedded Fix' settings.</li>
<li><b>6 </b> : Opaque + Concave Fix : Instead of using 'Embedded Fix' you can use 'Concave Fix'. It's generally used for curved entities, use it when you spot a black seems on curved (arched) entities.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Origin Target</b></span> <kbd  class="tooltip" data-tooltip="string">light_origin</kbd> :
Set it to the name of [info_target](../info_target), this entity will receive lights from specified info_taget position instead of it's own position. As a lot of entites can moves and lightning is not updated dynamically you can choose how your entity will be lit in game (e.g. elevators, pushables e.t.c.). Now you don't need to put the whole entity in the well-lit room at map start to make them look desirable.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Locked Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">locked_sound</kbd> :
Sound to play when a player tries to use the {{ entname }} but it's locked because it has a targetname or uses a multisource entity.
<div class="accordion">
<input type="checkbox" id="accordion-16" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-16">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None</li>
<li><b>2</b> : Access Denied<div class="imagepadding" markdown="1">![Access Denied](../audio/access-denied.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : Small zap<div class="imagepadding" markdown="1">![Small zap](../audio/small-zap.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>10</b> : Buzz<div class="imagepadding" markdown="1">![Buzz](../audio/buzz.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>11</b> : Buzz Off<div class="imagepadding" markdown="1">![Buzz Off](../audio/buzz-off.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>12</b> : Latch Locked<div class="imagepadding" markdown="1">![Latch Locked](../audio/latch-locked.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Unlocked Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">unlocked_sound</kbd> :
Sound to play if {{ entname }} is pressed/touched while not locked.
<div class="accordion">
<input type="checkbox" id="accordion-17" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-17">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None</li>
<li><b>1</b> : Big zap & Warmup<div class="imagepadding" markdown="1">![Big zap & Warmup](../audio/big-zap-warmup.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>3</b> : Access Granted<div class="imagepadding" markdown="1">![Access Granted](../audio/access-granted.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>4</b> : Quick Combolock<div class="imagepadding" markdown="1">![Quick Combolock](../audio/quick-combolock.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>5</b> : Power Deadbolt 1<div class="imagepadding" markdown="1">![Power Deadbolt 1](../audio/power-deadbolt-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>6</b> : Power Deadbolt 2<div class="imagepadding" markdown="1">![Power Deadbolt 2](../audio/power-deadbolt-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>7</b> : Plunger<div class="imagepadding" markdown="1">![Plunger](../audio/plunger.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : Small zap<div class="imagepadding" markdown="1">![Small zap](../audio/small-zap.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>9</b> : Keycard Sound<div class="imagepadding" markdown="1">![Keycard Sound](../audio/keycard-sound.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>10</b> : Buzz<div class="imagepadding" markdown="1">![Buzz](../audio/buzz.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>13</b> : Latch Unlocked<div class="imagepadding" markdown="1">![Latch Unlocked](../audio/latch-unlocked.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>14</b> : Lightswitch<div class="imagepadding" markdown="1">![Lightswitch](../audio/lightswitch.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Locked Sentence</b></span> <kbd  class="tooltip" data-tooltip="choices">locked_sentence</kbd> :
Sentence to play when a player tries to use {{ entname }} but it's locked because it has a targetname or uses a multisource entity. Sentences are picked from sound/default_sentences.txt file.
<div class="accordion">
<input type="checkbox" id="accordion-18" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-18">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None</li>
<li><b>1</b> : Gen. Access Denied : Play one out of 18(!) announcements subsequently. Check NA0-NA18 sentences from "default_sentences.txt" for detailed list.</li>
<li><b>2</b> : Security Lockout : Play one of the following announcements subsequently: "security lock is engaged", "secure area, no entry", "security lockout, no entry", "secure door, no entry", "security system in force", "security system armed, no entry", "door is secured" and "illegal access, move away".</li>
<li><b>3</b> : Blast Door : Play one of the following announcements subsequently: "emergency blast door activated", "emergency blast shield activated" and "the blast containment shield is down".</li>
<li><b>4</b> : Fire Door : Play "fire containment door is down" announcement.</li>
<li><b>5</b> : Chemical Door : Play "chemical leak containment door activated" announcement.</li>
<li><b>6</b> : Radiation Door : Play "radiation containment door activated" announcement.</li>
<li><b>7</b> : Gen. Containment : Play "emergency containment door engaged" announcement.</li>
<li><b>8</b> : Maintenance Door : Play one of the following announcements subsequently: "no access, maintenance area" and "no personnel permitted in maintenance area".</li>
<li><b>9</b> : Broken Shut Door : Play one of the following announcements subsequently: "sorry, this door is inoperative", "sorry, door out of service" and "door damage detected, please call service personnel".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Unlocked Sentence</b></span> <kbd  class="tooltip" data-tooltip="choices">unlocked_sentence</kbd> :
Sentence to play when the door is opened. Plays only few times.
<div class="accordion">
<input type="checkbox" id="accordion-19" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-19">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None</li>
<li><b>1</b> : Gen. Access Granted : Play one of the following announcements subsequently: "access granted", "access permitted", "entry granted", "entry permitted", "access authorized", "entry is permitted", "access authorized", "access to facility, granted" and "access granted".</li>
<li><b>2</b> : Security Disengaged : Play one of the following announcements subsequently: "security lock disengaged", "security clear, proceed", "security lockout, released", "secure override accepted", "security access acknowledged", "security system disengaged" and "door security disengaged".</li>
<li><b>3</b> : Blast Door : Play one of the following announcements subsequently: "emergency blast door, open", "emergency blast shield, deactivated" and "blast containment shield is, open".</li>
<li><b>4</b> : Fire Door : Play "fire containment door, open" announcement.</li>
<li><b>5</b> : Chemical Door : Play "chemical leak containment door, open" announcement.</li>
<li><b>6</b> : Radiation Door : Play "radiation containment door, open" announcement.</li>
<li><b>7</b> : Gen. Containment : Play "emergency containment door disengaged" announcement.</li>
<li><b>8</b> : Maintenance area : Play one of the following announcements subsequently: "maintenance area access granted" and "maintenance area door open".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Locked Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">locked_sound_override</kbd> :
Sound file to use when attempting to open locked {{ entname }}. Useful when you don't want to use sound from default sound list. This overrides default "Locked Sound" sound.  Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Unlocked Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">unlocked_sound_override</kbd> :
Sound file to use when {{ entname }} opens. Useful when you don't want to use sound from default sound list. This overrides default "Unlocked Sound" sound. Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Locked Sentence Override</b></span> <kbd  class="tooltip" data-tooltip="string">locked_sentence_override</kbd> :
Sentence from "default_sentences.txt" or custom sentences file (which can be added in map properties) to use when attempting to open locked {{ entname }}. Useful when you want to override locked sentence with your own sentence.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Unlocked Sentence Override</b></span> <kbd  class="tooltip" data-tooltip="string">unlocked_sentence_override</kbd> :
Sentence from "default_sentences.txt" or custom sentences file (which can be added in map properties) to use when {{ entname }} opens. Useful when you want to override locked sentence with your own sentence.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Open Start</b></span> <kbd  class="tooltip" data-tooltip="string">fireonopening</kbd> :
Entity to trigger when {{ entname }} starts opening.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Open Start Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">fireonopening_triggerstate</kbd> :
Set the use-type with which the entity specified above will be fired.
<div class="accordion">
<input type="checkbox" id="accordion-20" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-20">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Close Start</b></span> <kbd  class="tooltip" data-tooltip="string">fireonclosing</kbd> :
Entity to trigger when door starts closing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Close Start Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">fireonclosing_triggerstate</kbd> :
Set the use-type with which the entity specified above will be fired.
<div class="accordion">
<input type="checkbox" id="accordion-21" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-21">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Open End</b></span> <kbd  class="tooltip" data-tooltip="string">fireonopened</kbd> :
Entity to trigger when door ends opening.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Open End Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">fireonopened_triggerstate</kbd> :
Set the use-type with which the entity specified above will be fired.
<div class="accordion">
<input type="checkbox" id="accordion-22" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-22">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Close End</b></span> <kbd  class="tooltip" data-tooltip="string">fireonclosed</kbd> :
Entity to trigger when door end closing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Close End Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">fireonclosed_triggerstate</kbd> :
Set the use-type with which the entity specified above will be fired.
<div class="accordion">
<input type="checkbox" id="accordion-23" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-23">
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed</b></span> <kbd  class="tooltip" data-tooltip="integer">speed</kbd> :
Movement speed in units per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the multisource entity that (temporary) locks this {{ entname }}. If master specified the {{ entname }} will be disabled and will play locked sounds and sentences. When multisource entity is triggered/beign triggering by all possible inputs, the {{ entname }} will be unlocked. When multisource lost at least one input signal, the entities becomes locked again.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">movesnd</kbd> :
Sound that is played while the {{ entname }} is moving.
<div class="accordion">
<input type="checkbox" id="accordion-24" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-24">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No Sound</li>
<li><b>1</b> : Servo (Sliding)<div class="imagepadding" markdown="1">![Servo (Sliding)](../audio/servo-sliding.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>2</b> : Pneumatic (Sliding)<div class="imagepadding" markdown="1">![Pneumatic (Sliding)](../audio/pneumatic-sliding.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>3</b> : Pneumatic (Rolling)<div class="imagepadding" markdown="1">![Pneumatic (Rolling)](../audio/pneumatic-rolling.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>4</b> : Vacuum<div class="imagepadding" markdown="1">![Vacuum](../audio/vacuum.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>5</b> : Power Hydraulic<div class="imagepadding" markdown="1">![Power Hydraulic](../audio/power-hydraulic.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>6</b> : Large Rollers<div class="imagepadding" markdown="1">![Large Rollers](../audio/large-rollers.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>7</b> : Track Door<div class="imagepadding" markdown="1">![Track Door](../audio/track-door.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : Snappy Metal Door<div class="imagepadding" markdown="1">![Snappy Metal Door](../audio/snappy-metal-door.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>9</b> : Squeaky 1<div class="imagepadding" markdown="1">![Squeaky 1](../audio/squeaky-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>10</b> : Squeaky 2<div class="imagepadding" markdown="1">![Squeaky 2](../audio/squeaky-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound Loops?</b></span> <kbd  class="tooltip" data-tooltip="choices">movesnd_loop</kbd> :
Sets if "Move Sound" should be looped during movement until it stops.
<div class="accordion">
<input type="checkbox" id="accordion-25" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-25">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No</li>
<li><b>1</b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">stopsnd</kbd> :
Sound which is played once as the {{ entname }} stops moving.
<div class="accordion">
<input type="checkbox" id="accordion-26" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-26">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No Sound</li>
<li><b>1</b> : Clang with brake<div class="imagepadding" markdown="1">![Clang with brake](../audio/servo-sliding-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>2</b> : Clang reverb<div class="imagepadding" markdown="1">![Clang reverb](../audio/pneumatic-sliding-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>3</b> : Ratchet Stop<div class="imagepadding" markdown="1">![Ratchet Stop](../audio/pneumatic-rolling-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>4</b> : Chunk<div class="imagepadding" markdown="1">![Chunk](../audio/vacuum-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>5</b> : Light airbrake<div class="imagepadding" markdown="1">![Light airbrake](../audio/power-hydraulic-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>6</b> : Metal Slide Stop<div class="imagepadding" markdown="1">![Metal Slide Stop](../audio/large-rollers-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>7</b> : Metal Lock Stop<div class="imagepadding" markdown="1">![Metal Lock Stop](../audio/track-door-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : Snappy Metal Stop<div class="imagepadding" markdown="1">![Snappy Metal Stop](../audio/snappy-metal-door-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">noise1</kbd> :
Sound file to use when the {{ entname }} is moving. Useful when you don't want to use sound from default sound list. This overrides default "Move Sound" sound. Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">noise2</kbd> :
Sound file to use when the {{ entname }} is stop moving. Useful when you don't want to use sound from default sound list. This overrides default "Stop Sound" sound. Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>delay before close, -1 stay open </b></span> <kbd  class="tooltip" data-tooltip="integer">wait</kbd> :
Delay till the {{ entname }} will automatically close after having opened. Setting this to -1 makes it never close again. When the "Toggle" flag is selected, this is obsolete.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Lip</b></span> <kbd  class="tooltip" data-tooltip="integer">lip</kbd> :
Length in units to subtract from the precomputed movement-distance of the {{ entname }}. Negative values increase the movement-distance.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage inflicted when blocked</b></span> <kbd  class="tooltip" data-tooltip="integer">dmg</kbd> :
Damage to apply to entity that attempts to blocks the {{ entname }}.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Message if triggered</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Not functional.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Strength</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Set how many hit points this entity has if "Breakable" is set to 'Yes'
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum light level</b></span> <kbd  class="tooltip" data-tooltip="string">_minlight</kbd> :
Sets the minimum light level. Useful for when textures should always appear brighter. Default is 0, max 1.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Allows you to setup a sound replacement file for the {{ entname }} sounds. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a custom_precache point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Who can open this</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iOpenFlags</kbd> :
Specify who can open this {{ entname }} by touching/using it (if it has no targetname, or targetname is set to be ignored with "Ignore Targetname")). If set to something other than default, this will cause the old spawnflags which are usually used to keep track of this to be ignored and causes the {{ entname }} to only orient using this setting instead.
<div class="accordion">
<input type="checkbox" id="accordion-27" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-27">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Default (0)</li>
<li><b>1</b> : Pushables (1) : func_pushable and player can open this {{ entname }}</li>
<li><b>2</b> : No clients (2) : Player, func_pushable and everything else can't open this (probably enemies still can).</li>
<li><b>3</b> : 1 + 2 : Player can't open this but func_pushable can.</li>
<li><b>4</b> : Everything else (4) : Everything else (e.g. enemy) and player can open this.</li>
<li><b>5</b> : 1 + 4 : Basically everything can open this {{ entname }}.</li>
<li><b>6</b> : 2 + 4 : func_pushable and player can't open this but everything else can.</li>
<li><b>7</b> : 1 + 2 + 4 : Player can't open but func_pushable and everything else can.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ignore Targetname</b></span> <kbd  class="tooltip" data-tooltip="choices">m_fIgnoreTargetname</kbd> :
Set whether the {{ entname }} should ignore its targetname or not. This is useful when you need to reference the {{ entname }} in another entity but still want it to open on touch.
<div class="accordion">
<input type="checkbox" id="accordion-28" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-28">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No : If "Name" is set then this {{ entname }} can be opened by triggering it.</li>
<li><b>1</b> : Yes : {{ entname }} can be still opened by touching it and "Name" will be used for something else than opening/closing it.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Obey Trigger Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iObeyTriggerMode</kbd> :
Controls how to interpret use-types 'Off' and 'On' incoming from entity that triggers the {{ entname }}.
<div class="accordion">
<input type="checkbox" id="accordion-29" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-29">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : 'Off' and 'On' works as 'Toggle' so it will open the {{ entname }} when it's closed and close it when it's open.</li>
<li><b>1 </b> : Yes : 'Off' only closes and 'On' only opens the {{ entname }}.</li>
<li><b>2 </b> : Yes, even when currently moving : Same as above but it will also work even when {{ ent_name }} is currently opening/closing.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Breakable</b></span> <kbd  class="tooltip" data-tooltip="choices">breakable</kbd> :
If set to 'Yes', the {{ entname }} gets functionality of [func_breakable](../func_breakable) entity. All breakable keyvalues are functional when this key is set to 'Yes'.
<div class="accordion">
<input type="checkbox" id="accordion-30" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-30">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No</li>
<li><b>1</b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire on break</b></span> <kbd  class="tooltip" data-tooltip="target_destination">fireonbreak</kbd> :
If "Breakable" is set to 'Yes' then this is target entity to fire when {{ entname }} breaks.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Material type</b></span> <kbd  class="tooltip" data-tooltip="choices">material</kbd> :
If "Breakable" is set to 'Yes' then this is material which matches what your {{ entname }} is supposed to be the most. The material type affects the {{ entname }}'s sounds emitted when it takes damage, as well as which gibs are created when it is destroyed. If the material is set to 'Unbreakable glass', the {{ entname }} is, regardless of how funny that is, in fact, unbreakable..
<div class="accordion">
<input type="checkbox" id="accordion-31" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-31">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Glass</li>
<li><b>1</b> : Wood</li>
<li><b>2</b> : Metal</li>
<li><b>3</b> : Flesh</li>
<li><b>4</b> : Cinder Block</li>
<li><b>5</b> : Ceiling Tile</li>
<li><b>6</b> : Computer</li>
<li><b>7</b> : Unbreakable Glass</li>
<li><b>8</b> : Rocks</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Instant Break</b></span> <kbd  class="tooltip" data-tooltip="choices">instantbreak</kbd> :
If "Breakable" is set to 'Yes' then this let you enable instant break of {{ entname }} if hit with a "Instant break weapon" specified below. Note that this still can be damaged by other sources normally.
<div class="accordion">
<input type="checkbox" id="accordion-32" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-32">
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
<span style="color:#9fc5e8;"><b>Instant Break Weapon</b></span> <kbd  class="tooltip" data-tooltip="choices">weapon</kbd> :
If "Breakable" is set to 'Yes' this allows you to specify an instant-break weapon when "Instant break" is set to 'Yes'.
<div class="accordion">
<input type="checkbox" id="accordion-33" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-33">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>1</b> : Crowbar</li>
<li><b>19</b> : Crowbar (Electric Only)</li>
<li><b>20</b> : Pipe Wrench</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gibs' direction and velocity</b></span> <kbd  class="tooltip" data-tooltip="choices">explosion</kbd> :
If "Breakable" is set to 'Yes' you can choose whether the gibs fly relative to where the attack came from, damage received and material (e.g. concrete gibs fly with less velocity) or randomly. This has no effect on the {{ entname }} destroyed via a trigger. Note: Blowing up stuff is much more fun when shit goes flying instead of just falling to the ground as if nothing happened.
<div class="accordion">
<input type="checkbox" id="accordion-34" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-34">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Random direction; no velocity</li>
<li><b>1</b> : Relative to attack/dmg./mat.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gib Model</b></span> <kbd  class="tooltip" data-tooltip="studio">gibmodel</kbd> :
If "Breakable" is set to 'Yes' you can choose custom model of broken entity parts. Models with multiple 'Submodels' uses all of sub-models for gibs. If "Material Type" is set to 'Glass' then spawned gibs are transparent.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Explode Magnitude (0=none)</b></span> <kbd  class="tooltip" data-tooltip="integer">explodemagnitude</kbd> :
Requires "Breakable" set to 'Yes'. If greater than zero, the {{ entname }} will cause an explosion at its position when it breaks. The greater the magnitude, the more damage the explosion will cause. Note that explosion damage values above 200 are know to cause explosion damage to even go through walls.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD Info name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
Requires "Breakable" set to 'Yes'. If "Show HUD Info" is set to 'Yes', this is a name to display on-screen when player is looking at this {{ entname }}.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Only Trigger</b></span> <kbd  class="tooltip" data-tooltip="choices">onlytrigger</kbd> :
Requires "Breakable" set to 'Yes'. Make the {{ entname}} breakable only via triggering it.
<div class="accordion">
<input type="checkbox" id="accordion-35" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-35">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Can still be broken by normal damage.</li>
<li><b>1 </b> : Yes : Can only break by triggering it.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Break On Trigger</b></span> <kbd  class="tooltip" data-tooltip="choices">breakontrigger</kbd> :
Requires "Breakable" set to 'Yes'. You can allow the {{ entname }} to breakable via trigger. It is not a duplicate of keyvalue above.
<div class="accordion">
<input type="checkbox" id="accordion-36" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-36">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Can't be triggered to break.</li>
<li><b>1 </b> : Yes : Can be triggered to break.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Repairable</b></span> <kbd  class="tooltip" data-tooltip="choices">repairable</kbd> :
With "Breakable" set to 'Yes' this allows to specify if the {{ entname }} can be repaired by using weapon_pipewrench on it.
<div class="accordion">
<input type="checkbox" id="accordion-37" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-37">
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
<span style="color:#9fc5e8;"><b>Show HUD Info</b></span> <kbd  class="tooltip" data-tooltip="choices">showhudinfo</kbd> :
With "Breakable" set to 'Yes' you can also enable HUD info when looking at this {{ entname }} (name, health e.t.c.).
<div class="accordion">
<input type="checkbox" id="accordion-38" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-38">
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
<span style="color:#9fc5e8;"><b>Immune To Clients</b></span> <kbd  class="tooltip" data-tooltip="choices">immunetoclients</kbd> :
Requires "Breakable" set to 'Yes'. While breakable {{ entname }} can be damaged by anyone or everything, you can disable if player should belong to this privileged group.
<div class="accordion">
<input type="checkbox" id="accordion-39" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-39">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Players can break this {{entname}}.</li>
<li><b>1 </b> : Yes : Players can't break this {{entname}}.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Explosives Only</b></span> <kbd  class="tooltip" data-tooltip="choices">explosivesonly</kbd> :
Requires "Breakable" set to 'Yes'. With this setting you can set the {{ entname }} react only to explosion damage.
<div class="accordion">
<input type="checkbox" id="accordion-40" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-40">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Everything can damage this {{ entname }}.</li>
<li><b>1 </b> : Yes : Only explosions can damage this {{ entname }}.</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Starts Open : If set, the {{ entname }} will treat its predetermined open- and close-position as swapped, meaning it will start in its open position, but treat it as its closed position. This is useful when you want your {{ entname }} to start open and still receive proper lighting, or the node-graph to generate properly before closing the {{ entname }} manually (if "Toggle" flag is selected).</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Don't link : If set, this {{ entname }} won't synchronize its movement with identically named {{ entname }}. This is useful when triggering many {{ entname }} with different speeds or different movement-lengths by the same name. If not set, the {{ entname }} entities with the same name will adjust their individual speeds to open/close simultaneously, orienting at how the first related {{ entname }} the game engine finds would behave timing-wise.</li>
<li class="imagepadding" markdown="1"><b>8</b> : Passable : If set, the {{ entname }} is entirely non-solid. It also cannot be triggered on-touch anymore then. Much more optimal way to do this is to set "ZHLT Disable Clipping" to 'Always non-solid' unless you don't want to have bullets blocked by {{ entname }}.</li>
<li class="imagepadding" markdown="1"><b>32</b> : Toggle : If set, this {{ entname }} ignores its "delay before close" keyvalue; nonetheless, it must not be 0 then for some reason.</li>
<li class="imagepadding" markdown="1"><b>256</b> : USE Only : If set, this {{ entname }} can be triggered by using it but not by touching it anymore. This does not outrule activation by triggering, though.</li>
<li class="imagepadding" markdown="1"><b>512</b> : Monsters Can't : If set, monsters cannot cause this {{ entname }} to move. They can, otherwise, even if it is a use-only- or trigger-only-door, so don't forget to set this when you need it!</li>
<li class="imagepadding" markdown="1"><b>1024</b> : No Link-Checking : If set, the {{ entname }} won't check for another {{ entname }} to link with, causing this one to not be considered for link-orientation by the game engine; it can still be caused to be linked by other {{ entname }}.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
