---
title: scripted_sequence
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
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Monster</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszEntity</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action Animation</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszPlay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Idle Animation</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszIdle</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Search Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flRadius</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Repeat Rate ms</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flRepeat</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Position</b></span> <kbd  class="tooltip" data-tooltip="choices">m_fMoveTo</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Walk : Choice_Description_here</li>
<li><b>2 </b> : Run : Choice_Description_here</li>
<li><b>4 </b> : Instantaneous : Choice_Description_here</li>
<li><b>5 </b> : No - Turn to Face : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">moveto_radius</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>4 </b> : Repeatable : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Leave Corpse : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32</b> : No Interruptions : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64</b> : Override AI : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>128</b> : No Script Movement : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>256</b> : No Reset Entity : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
