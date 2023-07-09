---
title: trigger_camera
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">When triggered, temporarily swaps the player's view with that of the camera, and has the camera follow a path, if set up that way. This is usually used for cut-scenes. Set the camera target to make trigger_camera look at this target, e.g. set it to [func_train](../func_train) and camera will look at this func_train (this train need origin brush), you can also use [info_target](../info_target) for this. By default, camera moves among path made by path_corners, smooths it's movement in the whole path, and facing target (when no target specified, the camera takes it's angles). Trigger_camera can also detects mouse clicking on different entities and surfaces to perform actions of your choice. Triggering another camera when previous is still playing overrides first camera.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Used mostly for targeting camera view by specifying entity to look at ([func_train](../func_train) or [info_target](../info_target)). In unusual cases this can be used to trigger an entity. It is advised to use "Target when player stops using" and "Target when player starts using" for this.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when camera hold time expires.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it display camera view. Depending on trigger use-type: 'On'- enable camera view, 'Off'- disable camera view, 'Toggle'- toggle camera view. Can be kill-targeted but player would get stuck in camera view if removed while using this!
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hold time</b></span> <kbd  class="tooltip" data-tooltip="integer">wait</kbd> :
How many seconds camera controls player view. Player recovers his view and all camera effects are exterminated after that.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Corner</b></span> <kbd  class="tooltip" data-tooltip="string">moveto</kbd> :
Name of [path_corner](../path_corner) this camera spawns at. Path_corners are entities that connected with each other creates path. For static camera leave this empty. Supports [path_track](../path_track) as well (but does no big difference).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Initial Speed</b></span> <kbd  class="tooltip" data-tooltip="string">speed</kbd> :
Starting speed of camera when camera is moving.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Acceleration units/sec^2</b></span> <kbd  class="tooltip" data-tooltip="string">acceleration</kbd> :
Amount of units the camera accelerates each second (if it's moving). Doesn't work when "Instant Move" is selected.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Deceleration units/sec^2</b></span> <kbd  class="tooltip" data-tooltip="string">deceleration</kbd> :
Amount of units the camera accelerates each second (if it's moving). It is not required, the camera actually smooth it's movement very well. Doesn't work when "Instant Move" is selected.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Camera Rotation Speed</b></span> <kbd  class="tooltip" data-tooltip="string">turnspeed</kbd> :
Camera rotation speed. Camera does not rotate itself as that, it also won't rotate within path_corners/path_tracks (only micro rotations when camera moves smoothly ("Instant Move" not selected) and tries to keep target on the center of the screen). The camera only rotates from starting angle to face it's target when "Instant Turn is selected". The starting angle is a default angle of the camera, if "start at player" is set, the starting angle is a player angle.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_0</kbd> :
Action to perform when player clicked with left mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Right Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_0</kbd> :
Action to perform when player clicked with right mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Third Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_0</kbd> :
Action to perform when player clicked with middle mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Left Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_1</kbd> :
Action to perform when player double-clicked with left mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Right Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_1</kbd> :
Action to perform when player double-clicked with right mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Third Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_1</kbd> :
Action to perform when player double-clicked with middle mouse button.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Action : No action (disable this feature).</li>
<li><b>1 </b> : Trigger Off : Trigger clicked entity with 'Off' use-type.</li>
<li><b>2 </b> : Trigger On : Trigger clicked entity with 'On' use-type.</li>
<li><b>3 </b> : Trigger Toggle : Trigger clicked entity with 'Toggle' use-type.</li>
<li><b>4 </b> : Remove : Remove (kill-target) clicked entity.</li>
<li><b>5 </b> : Hurt : Deal a damage to clicked entity, use "Click Param" to specify damage amount.</li>
<li><b>6 </b> : Heal : Heal clicked entity, use "Click Param" to specify heal amount.</li>
<li><b>7 </b> : Spawn : Spawns an entity in clicked location, use "Click Param" to specify entity classname.</li>
<li><b>8 </b> : Teleport : Teleports specified entity to clicked location, use "Click Param" to specify entity targetname.</li>
<li><b>9 </b> : Teleport Away : Teleports clicked entity to specified location, use "Click Param" to specify location: targetname, destination(not tested) or coordinates(not tested).</li>
<li><b>10 </b> : Create Explosion : Creates an explosion effect on clicked surface/entity, no damage.</li>
<li><b>11 </b> : Drag : Drags entities around.</li>
<li><b>255 </b> : Exit Camera (Non-forced only) : Close camera view, leave the camera and return to game (only if "Force View" flag is not selected).</li>
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
When "Mouse Cursor" is enabled, block a repeating action from firing when a mouse button is held down then moved about whilst held, e.g. constantly triggering a door open/close just by holding a mouse button and jittering movement a bit.
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
<span style="color:#9fc5e8;"><b>Mouse Digital Action Reset Time</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_digital_action_reset</kbd> :
When "Mouse Cursor" is enabled, change the wait/reset time between each digital mouse action, though there is still a minimum of 0.01 (10ms). Digital mouse action including clicking, double-clicking and wheel up/down. This doesn't apply to analogue actions, being moving or dragging.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>AS Mouse Event Callback Name</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszASMouseEventCallbackName</kbd> :
Name of AngelScript method to call on camera mouse events.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>AS Key Input Callback Name</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszASKeyInputCallbackName</kbd> :
Name of AngelScript method to call on camera input events.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Set Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszOverridePlayerTargetname</kbd> :
Set player's targetname to new value when they use the camera, and revert those changes after finishing using it.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when player starts using</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTargetWhenPlayerStartsUsing</kbd> :
Target to trigger when player starts using this camera.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when player stops using</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTargetWhenPlayerStopsUsing</kbd> :
Target to trigger when player stops using this camera.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when turned off</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTurnedOffTarget</kbd> :
Target to trigger when camera is turned off (e.g. when camera hold time expires).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Players</b></span> <kbd  class="tooltip" data-tooltip="integer">max_player_count</kbd> :
Maximum number of players that can be using this camera at once, only applicable when "All players" flag is disabled.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: Player tried to use, but Max Players reached</b></span> <kbd  class="tooltip" data-tooltip="string">max_player_target</kbd> :
Entity to trigger when player attempts to use the camera but "Max players" limit has been reached.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Health and Battery</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_health</kbd> :
Specify if health and battery counters hud elements should be hidden during camera view.
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Show Health and Battery</li>
<li><b>1 </b> : Hide Health and Battery</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Flashlight</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_flashlight</kbd> :
Specify if flashlight indicator hud element should be hidden during camera view.
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Show Flashlight</li>
<li><b>1 </b> : Hide Flashlight</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Weapons</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_weapons</kbd> :
Specify if weapon belt and ammo bar hud elements should be hidden during camera view.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Show Weapons</li>
<li><b>1 </b> : Hide Weapons</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Cursor (Sprite)</b></span> <kbd  class="tooltip" data-tooltip="sprite">cursor_sprite</kbd> :
Name of custom sprite that will be used as the mouse cursor during camera view.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Start At Player</span> : Camera starts at player position, after that it will gradually switch to path_corner route. If no path_corner specified, the camera will move at the direction the player was looking at and won't stop until hold time reach it's limit.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Follow Player</span> : Uses player (!activator) as a target to looking at.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Freeze Player</span> : Players can't move until end of camera movement.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">All Players</span> : All players will be affected by trigger_camera (not only the !activator).</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">Force View</span> : Force camera view whenever player is dead or not.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">No Instant Turn</span> : If selected, the camera won't smooths its rotation FROM starting angles TO face target, instead it will turn instantaneously. If "Start at Player" is selected, the player's facing direction is the camera starting angle. If flag is not selected, the camera start facing it's target, and the rotation speed is non-functional. If no "Target" specified, the flag is obsolete.</li>
<li class="imagepadding" markdown="1"><b>64</b> : <span style="color:#9fc5e8;">Instant Move</span> : If selected, the camera is moving from path to path without any movement smoothing.</li>
<li class="imagepadding" markdown="1"><b>128</b> : <span style="color:#9fc5e8;">Mouse Cursor</span> : Enable mouse cursor. Now all [trigger_cameratarget](../trigger_cameratarget) entities are allowed to be clicked (until hold time ends).</li>
<li class="imagepadding" markdown="1"><b>256</b> : <span style="color:#9fc5e8;">Player Invulnerable</span> : Players cannot be hurt when view is swapped. Use it as often as possible to avoid monster attacking you while cutscene is in progress.</li>
<li class="imagepadding" markdown="1"><b>512</b> : <span style="color:#9fc5e8;">Ignore Hold Time</span> : Camera ignores hold time and will be turned off when re-triggered.</li>
</ul>
</div>
<div class="notices blue" markdown="1">The best way to make camera rotate is to "Target" the entity. The camera will face entity specified in "Target" field, it could be [info_target](../info_target), monster or even another train. If you make a train that moves in a same path as trigger_camera, but it's a little further in a path, the camera will face always the direction that it moves.</div>
<div class="notices blue" markdown="1">When targeting func_train or other brush-based entity, the ORIGIN brush tied to those entities is required.</div>
