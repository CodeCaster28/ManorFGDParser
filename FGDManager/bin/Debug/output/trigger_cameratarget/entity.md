---
title: trigger_cameratarget
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A brush-based entity you can click on using the mouse cursor function of the [trigger_camera](../trigger_camera).</div>
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
Set name of {{ entname }} so other entities can trigger it to enable or disable camera target. Depending on trigger use-type: 'On'- enable camera target, 'Toggle'- toggle camera target, 'Off'- disable camera target. Can be kill-targeted.
</div>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
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
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
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
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
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
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
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
<span style="color:#9fc5e8;"><b>Left Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_0</kbd> :
Perform selected action when this entity is clicked with left mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_0_0</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_0_0</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Left Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_0_0</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_0</kbd> :
Perform selected action when this entity is clicked with right mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_1_0</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_1_0</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Right Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_1_0</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_0</kbd> :
Perform selected action when this entity is clicked with middle mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_2_0</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_2_0</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
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
<span style="color:#9fc5e8;"><b>Third Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_2_0</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_1</kbd> :
Perform selected action when this entity is double-clicked with left mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_0_1</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_0_1</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
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
<span style="color:#9fc5e8;"><b>Left Double Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_0_1</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_1</kbd> :
Perform selected action when this entity is double-clicked with right mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_1_1</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_1_1</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
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
<span style="color:#9fc5e8;"><b>Right Double Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_1_1</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_1</kbd> :
Perform selected action when this entity is double-clicked with middle mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Triggers target specified in "Click Target" with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Triggers target specified in "Click Target" with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Triggers target specified in "Click Target" with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove target specified in "Click Target".</li>
<li><b>5 </b> : Hurt : Deal a damage to target specified in "Click Target" by amount specified in "Click Param".</li>
<li><b>6 </b> : Heal : Heal a target specified in "Click Target" by amount specified in "Click Param".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_2_1</kbd> :
Some actions from keyvalue above can have parameter specified.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_2_1</kbd> :
Block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
<div class="accordion">
<input type="checkbox" id="accordion-16" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-16">
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
<span style="color:#9fc5e8;"><b>Third Double Click Target</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_target_2_1</kbd> :
Entity to trigger with specified action and parameter.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Mouse Digital Action Reset Time</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_digital_action_reset</kbd> :
Change the wait/reset time between each digital mouse action, though there is still a minimum of 0.01 (10ms). Digital mouse action including clicking, double-clicking and wheel up/down. This doesn't apply to analogue actions, being moving or dragging.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Invisible</span> : All brushes of this entity are invisible- can still be clicked, have collision, it's not visible, bullets can be shot through it (just like in the 'CLIP' brushes), but any other projectiles can't (like grenades, spore grenades, hornets e.t.c.).</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Start Off</span> : Disable entity at map start so {{ entname }}} need to be triggered in order to be usable.</li>
</ul>
</div>
<div class="notices blue" markdown="1">It's only trigger entity that can be visible in-game.</div>
<div class="notices red" markdown="1">All double click actions doesn't work properly.</div>
