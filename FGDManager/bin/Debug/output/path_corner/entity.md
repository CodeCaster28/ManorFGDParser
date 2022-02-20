---
title: path_corner
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity used to define a path for [func_train](../func_train). Can be also used to make Monsters go into specified direction (type path_corner name into "Target" of monster entity). To make it works, create a set of a path_corners entity, and in each path_corner's "Next Stop Target" specify a name of next path_corner to go to from this path_corner. If last path_corner targeting first path_corner, the path movement is looped. Note that monsters movement breaks upon combat initiation. Angles values does not affect train, however it's working with monsters like Osprey.</div>
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
Set name of {{ entname }} so other entities (monsters, trains, path_corners) can link to this. Can be kill-targeted, any object heading this path_corner will stop.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Next stop target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the next path_corner to go after entity reach this path_corner. Can be kill-targeted, any object heading this path_corner will stop.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire On Arrive</b></span> <kbd  class="tooltip" data-tooltip="target_destination">message</kbd> :
Entity to trigger when train or NPC reach this path_corner. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait here (secs)</b></span> <kbd  class="tooltip" data-tooltip="integer">wait</kbd> :
Delay before travel continuation to next path_corner. The entity will stop here and wait specified amount of time (in seconds), after that it will proceed  to next path_corner (described in "Next stop target") if there is any.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Train Speed</b></span> <kbd  class="tooltip" data-tooltip="integer">speed</kbd> :
Overrides train speed after reaching this point.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Train rot. Speed</b></span> <kbd  class="tooltip" data-tooltip="integer">yaw_speed</kbd> :
Overrides train rotation speed after reaching this point (degrees per seconds).
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Wait for retrigger</span> : The entity stops at this point and won't move until triggered (to continue normal travelling).</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">Teleport to this</span> : Entity is teleported to this path_corner instead of moving to it. Useful when creating infinite trains that travels the whole path and gets back into first point to repeat.Note that setting this to first path_corner (when no loop provided) is useless because train is already teleported to first path_corner at map start.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Fire once</span> : Entity will trigger it's "Fire on Arrive" target once.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">Random targets</span> : It requires multiple "Next stop target" path_corners with the same name. Picks random path_corner from within same named path_corners and go into it as a next destination target.</li>
</ul>
</div>
