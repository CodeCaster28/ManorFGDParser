---
title: path_track
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity used to define a path for [func_tracktrain](../func_tracktrain). To make it works, create a set of a path_tracks entity, and in each path_track's "Next Stop Target" specify a name of next path_track to go to from this path_track. If last path_track targeting first path_track, the path movement is looped.</div>
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
Set name of {{ entname }} so other entities can trigger it to enable or disable it or branch path. Depending on trigger use-type: 'On'- enable this path, 'Off'- disable this path, 'Toggle'- toggle this path. If "Branch Path" is specified: every time this path_track is disabled the one specified in branch path is used. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Next stop target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the next path_track to go after entity reach this path_track. Can be kill-targeted, any object heading this path_track will move toward map center coordinates.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Pass</b></span> <kbd  class="tooltip" data-tooltip="target_destination">message</kbd> :
Entity to trigger when track train reach this path_track. It won't trigger when train just stops at this point. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Branch Path</b></span> <kbd  class="tooltip" data-tooltip="target_destination">altpath</kbd> :
The name of alternative path_track to go. If path_track is triggered, it's change it's next stop target to the name of "Branch Path" path_track. If no "Branch Path" specified, and this path_track is triggered, the train stops at this point instead of going further, and vice-versa- if "Next stop Target" isn't specified, but the "Branch Path" is, the train will treat this point as a dead end, but after triggering this path_track the train will take path_track name specified in a "Branch Path" as a new target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire on dead end</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Entity to trigger when func_tracktrain reaches this path_track as a last path_track in a chain. This may happen in few cases:<ul><li>There is no next stop target specified.</li><li>Next stop target has been disabled and train reaches this point.</li><li>Train is travelling from point "A" (this path_track) to point "B" (next path_track), and path_track "B" has been disabled when train was on it's way to point "B" (between "A" and "B"). The train won't reach point "B", and this path_track (point "A") is considered as a dead end, so the trigger is fired.</li></ul>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Train Speed</b></span> <kbd  class="tooltip" data-tooltip="integer">newspeed</kbd> :
Overrides train speed after reaching this point. Affects both controllable and non-controllable trains.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Maximum Speed</b></span> <kbd  class="tooltip" data-tooltip="integer">maxspeed</kbd> :
Sets train speed once to this value if it's moving faster than that.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Train Speed (Legacy)</b></span> <kbd  class="tooltip" data-tooltip="integer">speed</kbd> :
Overrides train speed after reaching this point. Legacy, works only for non-controllable trains.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Disabled</span> : Start disabled. Trigger path to enable it. Branch Path cannot be used with this flag, even with selected Branch Reverse.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Fire once</span> : Entity fire it's "Fire on Pass" target once.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Branch Reverse</span> : Swap the branch path and next target on start.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">Disable train</span> : When selected, disables func_tracktrain controlling when reaching this point.</li>
</ul>
</div>
<div class="notices blue">If branch path is not defined, and the track was triggered (with Disabled flag not selected) the train won't reach this point- it will stop at the last enabled path_track.</div>
<div class="notices blue">When deactivating path (by killing it, disabling or branch switching with missing Branch Path) the train won't travel to that point, so it will end it's route at previous path_track (which is now considered dead end)</div>
