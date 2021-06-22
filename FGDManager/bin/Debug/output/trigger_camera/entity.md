---
title: trigger_camera
---

Entity_Description_here
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hold time</b></span> <kbd  class="tooltip" data-tooltip="integer">wait</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Corner</b></span> <kbd  class="tooltip" data-tooltip="string">moveto</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Initial Speed</b></span> <kbd  class="tooltip" data-tooltip="string">speed</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Acceleration units/sec^2</b></span> <kbd  class="tooltip" data-tooltip="string">acceleration</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Deceleration units/sec^2</b></span> <kbd  class="tooltip" data-tooltip="string">deceleration</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Camera Rotation Speed</b></span> <kbd  class="tooltip" data-tooltip="string">turnspeed</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_0_0</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_0_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_1_0</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_1_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_2_0</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_2_0</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_0_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_0_1</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Left Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_0_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_1_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_1_1</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Right Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_1_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_action_2_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Action : Choice_Description_here</li>
<li><b>1 </b></span> : Trigger Off : Choice_Description_here</li>
<li><b>2 </b></span> : Trigger On : Choice_Description_here</li>
<li><b>3 </b></span> : Trigger Toggle : Choice_Description_here</li>
<li><b>4 </b></span> : Remove : Choice_Description_here</li>
<li><b>5 </b></span> : Hurt : Choice_Description_here</li>
<li><b>6 </b></span> : Heal : Choice_Description_here</li>
<li><b>7 </b></span> : Spawn : Choice_Description_here</li>
<li><b>8 </b></span> : Teleport : Choice_Description_here</li>
<li><b>9 </b></span> : Teleport Away : Choice_Description_here</li>
<li><b>10 </b></span> : Create Explosion : Choice_Description_here</li>
<li><b>11 </b></span> : Drag : Choice_Description_here</li>
<li><b>255 </b></span> : Exit Camera (Non-forced only) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Param</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_param_2_1</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Third Double Click Block Drag Repeating Action</b></span> <kbd  class="tooltip" data-tooltip="choices">mouse_block_drag_2_1</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Mouse Digital Action Reset Time</b></span> <kbd  class="tooltip" data-tooltip="string">mouse_digital_action_reset</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>AS Mouse Event Callback Name</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszASMouseEventCallbackName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>AS Key Input Callback Name</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszASKeyInputCallbackName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Set Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszOverridePlayerTargetname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when player starts using</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTargetWhenPlayerStartsUsing</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when player stops using</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTargetWhenPlayerStopsUsing</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target when turned off</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszTurnedOffTarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Players</b></span> <kbd  class="tooltip" data-tooltip="integer">max_player_count</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: Player tried to use, but Max Players reached</b></span> <kbd  class="tooltip" data-tooltip="string">max_player_target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Health and Battery</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_health</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Show Health and Battery : Choice_Description_here</li>
<li><b>1 </b></span> : Hide Health and Battery : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Flashlight</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_flashlight</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Show Flashlight : Choice_Description_here</li>
<li><b>1 </b></span> : Hide Flashlight : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD: Weapons</b></span> <kbd  class="tooltip" data-tooltip="choices">hud_weapons</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Show Weapons : Choice_Description_here</li>
<li><b>1 </b></span> : Hide Weapons : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Cursor (Sprite)</b></span> <kbd  class="tooltip" data-tooltip="sprite">cursor_sprite</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>1</b></span> : Start At Player : Choice_Description_here</li>
<li><b>2</b></span> : Follow Player : Choice_Description_here</li>
<li><b>4</b></span> : Freeze Player : Choice_Description_here</li>
<li><b>8</b></span> : All Players : Choice_Description_here</li>
<li><b>16</b></span> : Force View : Choice_Description_here</li>
<li><b>32</b></span> : No Instant Turn : Choice_Description_here</li>
<li><b>64</b></span> : Instant Move : Choice_Description_here</li>
<li><b>128</b></span> : Mouse Cursor : Choice_Description_here</li>
<li><b>256</b></span> : Player Invulnerable : Choice_Description_here</li>
<li><b>512</b></span> : Ignore Hold Time : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
