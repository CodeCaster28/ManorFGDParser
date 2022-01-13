---
title: gibshooter
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Similar to [env_shooter](../env_shooter), except that this can only fire human gibs.</div>
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
Set name of {{ entname }} so other entities can trigger it to start shooting gibs. Can't be triggered when gibs shooting is in progress. Can be kill-targeted but gibs stay.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Number of Gibs</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iGibs</kbd> :
Set the amount of gibs to be shot when triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay between shots</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Set a delay between the individual gibs to be fired, in seconds.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gib Velocity</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flVelocity</kbd> :
Firing-velocity of the gibs shot, in units per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Course Variance</b></span> <kbd  class="tooltip" data-tooltip="string">m_flVariance</kbd> :
This is multiplied with 3 random numbers from -1 to 1 to form a vector to be added to the normalized direction-vector of the gib-direction, per gib. A great value like 100 would make the gib-direction almost entirely random. You can think of this as a value between 0 and 1 resulting in a course-cone from 0 to 180 degrees size, though that's not exactly what it is, just an approximation.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gib Life</b></span> <kbd  class="tooltip" data-tooltip="string">m_flGibLife</kbd> :
Time, in seconds, the gib will be visible till fading out of world and getting removed. This is actually randomly altered for every individual by minus to plus 5 per-cent.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Repeatable : If set, the {{ entname }} can be used more than once.</li>
</ul>
</div>
<div class="notices blue">If your delay between shots is 0, the game may increase it notably; 0.01 works, though.</div>
<div class="notices blue">The gibs also bounce off players.</div>
<div class="notices blue">Gibs do not get stuck in each other.</div>
