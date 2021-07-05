---
title: func_portal
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity_Description_here</div>
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
Set name of {{ entname }} so other entities can trigger it.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to fire (trigger). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Zoom</b></span> <kbd  class="tooltip" data-tooltip="integer">zoom</kbd> :
Scales image the {{ entname }} is displaying.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max FPS</b></span> <kbd  class="tooltip" data-tooltip="integer">fps</kbd> :
Target frames per second rendered by this {{ entname }}. Decreasing improves performance.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Min Render Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">mindist</kbd> :
Minimum render distance in which {{ entname }} is rendering. Leave empty or set to 0 for no minimum distance threshold.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Render Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">maxdist</kbd> :
Maximum render distance in which {{ entname }} is rendering. Leave empty or set to 0 for infinite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">textureMode</kbd> :
Set which textures on this brush are replaced by display.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0  </b> : { Textures : Apply display on every surface.</li>
<li><b>1  </b> : All Textures : All transparent textures, those which names starts with '{' character.</li>
<li><b>2  </b> : Named Texture : Textures with name specified in "Texture Name" keyvalue below.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Name</b></span> <kbd  class="tooltip" data-tooltip="string">textureName</kbd> :
Name of the texture to apply display on. Works only when "Texture Mode" is set to 'Named Texture'.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Solid : Enables collision.</li>
<li class="imagepadding" markdown="1"><b>2</b> : Start Disabled : If selected, {{ entname }} need to be enabled.</li>
<li class="imagepadding" markdown="1"><b>4</b> : Teleport : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8</b> : No GL ClipPlanes : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>16</b> : Render only every 2nd frame : Update display only every two frames instead of every frame, this improves performance.</li>
<li class="imagepadding" markdown="1"><b>32</b> : Shoot through : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
