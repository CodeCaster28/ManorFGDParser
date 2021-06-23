---
title: item_inventory
---

<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column">Entity_Description_here</div>
</div>
</div>
###Keyvalues
<hr>
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
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Slow Pulse : Choice_Description_here</li>
<li><b>2</b></span> : Fast Pulse : Choice_Description_here</li>
<li><b>3</b></span> : Slow Wide Pulse : Choice_Description_here</li>
<li><b>4</b></span> : Fast Wide Pulse : Choice_Description_here</li>
<li><b>9</b></span> : Slow Strobe : Choice_Description_here</li>
<li><b>10</b></span> : Fast Strobe : Choice_Description_here</li>
<li><b>11</b></span> : Faster Strobe : Choice_Description_here</li>
<li><b>12</b></span> : Slow Flicker : Choice_Description_here</li>
<li><b>13</b></span> : Fast Flicker : Choice_Description_here</li>
<li><b>5</b></span> : Slow Fade Away : Choice_Description_here</li>
<li><b>6</b></span> : Fast Fade Away : Choice_Description_here</li>
<li><b>7</b></span> : Slow Become Solid : Choice_Description_here</li>
<li><b>8</b></span> : Fast Become Solid : Choice_Description_here</li>
<li><b>14</b></span> : Constant Glow : Choice_Description_here</li>
<li><b>15</b></span> : Distort : Choice_Description_here</li>
<li><b>16</b></span> : Hologram (Distort + fade) : Choice_Description_here</li>
<li><b>19</b></span> : Glow Shell : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Color : Choice_Description_here</li>
<li><b>2</b></span> : Texture : Choice_Description_here</li>
<li><b>3</b></span> : Glow : Choice_Description_here</li>
<li><b>4</b></span> : Solid : Choice_Description_here</li>
<li><b>5</b></span> : Additive : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gravity Setting</b></span> <kbd  class="tooltip" data-tooltip="choices">movetype</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1</b></span> : Unmoveable : Choice_Description_here</li>
<li><b>0</b></span> : Fall to the ground (default) : Choice_Description_here</li>
<li><b>5</b></span> : Hover in the air : Choice_Description_here</li>
<li><b>8</b></span> : Hover in the air, ignore brush collision : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Solid Setting</b></span> <kbd  class="tooltip" data-tooltip="choices">solid</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1</b></span> : Hollow : Choice_Description_here</li>
<li><b>0</b></span> : Touch on edge, non-blocking (default) : Choice_Description_here</li>
<li><b>2</b></span> : Touch on edge, blocking (requires hull sizes!) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="studio">model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Skin</b></span> <kbd  class="tooltip" data-tooltip="integer">skin</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="integer">body</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence Name</b></span> <kbd  class="tooltip" data-tooltip="string">sequencename</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence Number (overrides name)</b></span> <kbd  class="tooltip" data-tooltip="integer">sequence</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Scale Model</b></span> <kbd  class="tooltip" data-tooltip="string">scale</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Min Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">minhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Max Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">maxhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Keyvalue_Description_here
</div>
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
<span style="color:#9fc5e8;"><b>Item name</b></span> <kbd  class="tooltip" data-tooltip="string">item_name</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Item group name</b></span> <kbd  class="tooltip" data-tooltip="string">item_group</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Display name (HUD)</b></span> <kbd  class="tooltip" data-tooltip="string">display_name</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Description (HUD)</b></span> <kbd  class="tooltip" data-tooltip="string">description</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Item icon (HUD)</b></span> <kbd  class="tooltip" data-tooltip="string">item_icon</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Self-activation limit (0 = infinite)</b></span> <kbd  class="tooltip" data-tooltip="integer">activate_limit</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collection limit (0 = infinite)</b></span> <kbd  class="tooltip" data-tooltip="integer">collect_limit</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Item weight (0-100)</b></span> <kbd  class="tooltip" data-tooltip="string">weight</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Entity target names</b></span> <kbd  class="tooltip" data-tooltip="string">filter_targetnames</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Entity class names</b></span> <kbd  class="tooltip" data-tooltip="string">filter_classnames</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Teams</b></span> <kbd  class="tooltip" data-tooltip="string">filter_teams</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: NPC classifications</b></span> <kbd  class="tooltip" data-tooltip="choices">filter_npc_classifications</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No filter : Choice_Description_here</li>
<li><b>-1 </b></span> : None : Choice_Description_here</li>
<li><b>1 </b></span> : Machine : Choice_Description_here</li>
<li><b>2 </b></span> : Player : Choice_Description_here</li>
<li><b>3 </b></span> : Human Passive : Choice_Description_here</li>
<li><b>4 </b></span> : Human Military : Choice_Description_here</li>
<li><b>5 </b></span> : Alien Military : Choice_Description_here</li>
<li><b>6 </b></span> : Alien Passive : Choice_Description_here</li>
<li><b>7 </b></span> : Alien Monster : Choice_Description_here</li>
<li><b>8 </b></span> : Alien Prey : Choice_Description_here</li>
<li><b>9 </b></span> : Alien Predator : Choice_Description_here</li>
<li><b>10 </b></span> : Insect : Choice_Description_here</li>
<li><b>11 </b></span> : Player Ally : Choice_Description_here</li>
<li><b>12 </b></span> : Player Hornet/Snark : Choice_Description_here</li>
<li><b>13 </b></span> : Alien Hornet/Snark : Choice_Description_here</li>
<li><b>14 </b></span> : X-Race : Choice_Description_here</li>
<li><b>15 </b></span> : X-Race: Shocktrooper/Voltigore : Choice_Description_here</li>
<li><b>16 </b></span> : Team 1 : Choice_Description_here</li>
<li><b>17 </b></span> : Team 2 : Choice_Description_here</li>
<li><b>18 </b></span> : Team 3 : Choice_Description_here</li>
<li><b>19 </b></span> : Team 4 : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Need item(s)</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_required</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Need item(s) from group(s)</b></span> <kbd  class="tooltip" data-tooltip="string">item_group_required</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Item count in group need have (0 = all)</b></span> <kbd  class="tooltip" data-tooltip="integer">item_group_required_num</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Item(s) moved</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_moved</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: CAN'T have item</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_canthave</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: CAN'T have item from group</b></span> <kbd  class="tooltip" data-tooltip="string">item_group_canthave</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Item count in group CAN'T have (0 = all)</b></span> <kbd  class="tooltip" data-tooltip="integer">item_group_canthave_num</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Collect: Item(s) NOT moved</b></span> <kbd  class="tooltip" data-tooltip="string">item_name_not_moved</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Carried: Hide item (3rd person)</b></span> <kbd  class="tooltip" data-tooltip="choices">carried_hidden</kbd> :
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
<span style="color:#9fc5e8;"><b>Carried: Skin</b></span> <kbd  class="tooltip" data-tooltip="integer">carried_skin</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Carried: Body</b></span> <kbd  class="tooltip" data-tooltip="integer">carried_body</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Carried: Sequence Name</b></span> <kbd  class="tooltip" data-tooltip="string">carried_sequencename</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Carried: Sequence Number (overrides name)</b></span> <kbd  class="tooltip" data-tooltip="integer">carried_sequence</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Return: Wait (-1 = never)</b></span> <kbd  class="tooltip" data-tooltip="string">return_timelimit</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Return: Delay respawn (materialisation)</b></span> <kbd  class="tooltip" data-tooltip="choices">return_delay_respawn</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
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
<span style="color:#9fc5e8;"><b>Holder: Hold time limit (0 = never)</b></span> <kbd  class="tooltip" data-tooltip="string">holder_timelimit</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Holder: Delay between self-activations (0 = none)</b></span> <kbd  class="tooltip" data-tooltip="string">holder_time_activate_wait</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Holder: Wearing out trigger time (0 = none)</b></span> <kbd  class="tooltip" data-tooltip="string">holder_time_wearout</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Holder: Allowed to self-activate</b></span> <kbd  class="tooltip" data-tooltip="choices">holder_can_activate</kbd> :
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
<span style="color:#9fc5e8;"><b>Holder: Hold time limit doesn't start until item activated</b></span> <kbd  class="tooltip" data-tooltip="choices">holder_timelimit_wait_until_activated</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
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
<span style="color:#9fc5e8;"><b>Holder: Allowed to drop</b></span> <kbd  class="tooltip" data-tooltip="choices">holder_can_drop</kbd> :
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
<span style="color:#9fc5e8;"><b>Holder: Keep item on death</b></span> <kbd  class="tooltip" data-tooltip="choices">holder_keep_on_death</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
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
<span style="color:#9fc5e8;"><b>Holder: Keep item on respawn</b></span> <kbd  class="tooltip" data-tooltip="choices">holder_keep_on_respawn</kbd> :
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
<span style="color:#9fc5e8;"><b>Target: On collect (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_collect</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On collect (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_collect_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On collect (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_collect_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't collect (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_collect</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't collect (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_collect_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't collect (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_collect_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On drop (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_drop</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On drop (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_drop_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On drop (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_drop_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't drop (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_drop</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't drop (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_drop_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't drop (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_drop_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On self-activate (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_activate</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On self-activate (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_activate_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On self-activate (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_activate_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't self-activate (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_activate</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't self-activate (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_activate_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On can't self-activate (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_cant_activate_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On use by trigger (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_use</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On use by trigger (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_use_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On use by trigger (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_use_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On wearing out (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_wearing_out</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On wearing out (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_wearing_out_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On wearing out (others)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_wearing_out_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On return (self)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_return</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On return (team)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_return_team</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On return (other)</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_return_other</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On materialise after return</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_materialise</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target: On destroy</b></span> <kbd  class="tooltip" data-tooltip="string">target_on_destroy</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Wait until item is self-activated?</b></span> <kbd  class="tooltip" data-tooltip="choices">effects_wait_until_activated</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
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
<span style="color:#9fc5e8;"><b>Effects: Permanent? (Until respawn)</b></span> <kbd  class="tooltip" data-tooltip="choices">effects_permanent</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
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
<span style="color:#9fc5e8;"><b>Effects: Glow shell color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">effect_glow</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Block weapons</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_block_weapons</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
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
<span style="color:#9fc5e8;"><b>Effects: Invulnerable</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invulnerable</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-16" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-16">
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
<span style="color:#9fc5e8;"><b>Effects: Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invisible</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-17" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-17">
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
<span style="color:#9fc5e8;"><b>Effects: Non-solid</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_nonsolid</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-18" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-18">
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
<span style="color:#9fc5e8;"><b>Effects: Time before drown (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_respiration</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Friction modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_friction</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Gravity modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_gravity</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Speed modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_speed</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Effects: Damage modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_damage</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>128 </b></span> : TOUCH Only : Choice_Description_here</li>
<li><b>256 </b></span> : USE Only : Choice_Description_here</li>
<li><b>512 </b></span> : Can Use w/o LoS : Choice_Description_here</li>
<li><b>1024</b></span> : Disable Respawn : Choice_Description_here</li>
<li><b>2048 </b></span> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
