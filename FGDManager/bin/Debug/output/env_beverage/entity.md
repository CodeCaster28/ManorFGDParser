---
title: env_beverage
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Spawns you a delicious Coca-Cola when triggered. No, I am not shitting you there.</div>
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
Set name of {{ entname }} so other entities can trigger it to spawn beverage (if no other is spawned at the moment). Any trigger signal type accepted. Can be kill-targeted, already spawned models are not removed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Capacity</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Set how many beverages can be spawned here. You cannot set this to be infinite, though you can set this to a large value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beverage Type</b></span> <kbd  class="tooltip" data-tooltip="choices">skin</kbd> :
Choose from one of six delicious flavours, or get a random one! This sets which submodel to use and may only affect the appearance of the beverage.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Coca-Cola</li>
<li><b>1 </b> : Sprite</li>
<li><b>2 </b> : Diet Coke</li>
<li><b>3 </b> : Orange</li>
<li><b>4 </b> : Surge</li>
<li><b>5 </b> : Moxie</li>
<li><b>6 </b> : Random</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="string">model</kbd> :
Allows you to provide your own beverage model, though, technically you may provide anything here. You can access the various submodels through beverage type.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Health for Pickup</b></span> <kbd  class="tooltip" data-tooltip="integer">weapons</kbd> :
Set how many health points will be recovered when using the beverage.
</div>
<div class="notices blue">This entity was used to create the usable vending machines in the Half-Life single player.</div>
<div class="notices blue">Triggering this while a beverage is still in the env_beverage's location causes nothing to happen. Spawn must be clear of beverages.</div>
