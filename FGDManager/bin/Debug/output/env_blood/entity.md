---
title: env_blood
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which, when triggered, creates a blood splash at its origin, which can cause blood decals on nearby walls, ceiling and floor.</div>
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
Set name of {{ entname }} so other entities can trigger it to emit blood (if place avaiable). Any trigger signal type accepted. Can be killtargeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Blood Color</b></span> <kbd  class="tooltip" data-tooltip="choices">color</kbd> :
Choose from one of two exciting colors.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Red (Human)</li>
<li><b>1 </b> : Yellow (Alien)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of blood (damage to simulate)</b></span> <kbd  class="tooltip" data-tooltip="string">amount</kbd> :
Greater amount causes the decal to be more likely to appear, more blood to appear and the blood to fly faster. Above 255, blood won't fly faster anymore. Basically, greater values simulate greater damage.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Random Direction : If set, instead of the direction set by the env_blood's angles, a random direction will be used into which the blood splash will splatter.</li>
<li class="imagepadding" markdown="1"><b>2</b> : Blood Stream : Instead of a mere blood splash, a blood stream from multiple particles will fly through the air. Basically, this means more blood.</li>
<li class="imagepadding" markdown="1"><b>4</b> : On Player : If set, the blood splash will be created somewhere at the activating player's head.</li>
<li class="imagepadding" markdown="1"><b>8</b> : Spray decals : If set, blood will appear on a nearby wall, ceiling or floor.</li>
</ul>
</div>
<div class="notices blue">If 'Move to position' is set to 'Instantaneous' and you have an action animation set, the monster may freeze up and no longer react.</div>
