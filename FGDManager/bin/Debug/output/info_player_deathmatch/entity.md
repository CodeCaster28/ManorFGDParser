---
title: info_player_deathmatch
---
<div>{% set entname = page.title|raw %}</div>
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Player Targetname</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Repel Speed</b></span> <kbd  class="tooltip" data-tooltip="string">frags</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Off : Choice_Description_here</li>
<li><b>1</b> : On : Choice_Description_here</li>
<li><b>2</b> : Toggle : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>2 </b> : Start Off : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Repel Spawn : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Filter player targetname : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>16 </b> : Invert Filter : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32 </b> : Trigger on spawn : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
