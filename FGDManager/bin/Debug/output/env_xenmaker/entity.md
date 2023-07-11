---
title: env_xenmaker
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The env_xenmaker allows to spawn monsters with teleportation and beam effects. It can be set to act as a spawn-effect-data-template for [squadmakers](../squadmaker), in case you want to pair this spawn-effect with the customizability-features of the [squadmaker](../squadmaker) entity.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<span style="color:#cae4fc;"><b>OnDestroy Function</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to spawn monster (if place available). Every trigger use-type works uniformly. Can be kill-targeted. Monster in queue (those who couldn't spawn because there was no room for them) won't spawn.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to trigger (fire). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<span style="color:#cae4fc;"><b>Pitch Yaw Roll</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Type</b></span> <kbd  class="tooltip" data-tooltip="string">monstertype</kbd> :
Entity classname of the monster type to spawn here. This must be set even if 'No Spawn' flag is set otherwise it will crash the game with "Spawned a NULL entity!" error message.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Radius (max)</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flBeamRadius</kbd> :
Maximum beam strike radius.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Alpha</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iBeamAlpha</kbd> :
Alpha of the beam. 255 for full opaque beam.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Count</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iBeamCount</kbd> :
Number of single beam instances.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Color</b></span> <kbd  class="tooltip" data-tooltip="color255">m_vBeamColor</kbd> :
Set the beam's color. Note that, because of bolts being rendered additively, darker colors mean greater transparency.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Light Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flLightRadius</kbd> :
Radius of the light that appears while spawning monster.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Light Color</b></span> <kbd  class="tooltip" data-tooltip="color255">m_vLightColor</kbd> :
Color of the light that appears while spawning monster.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite1 Framerate</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flStartSpriteFramerate</kbd> :
Frame display rate of the first animated sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite1 Scale</b></span> <kbd  class="tooltip" data-tooltip="string">m_flStartSpriteScale</kbd> :
Scale of the first sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite1 Alpha</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iStartSpriteAlpha</kbd> :
Alpha of the first sprite, 255 for full opaque sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite1 Color</b></span> <kbd  class="tooltip" data-tooltip="color255">m_vStartSpriteColor</kbd> :
First prite Color override.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite2 Framerate</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flEndSpriteFramerate</kbd> :
Frame display rate of the second animated sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite2 Scale</b></span> <kbd  class="tooltip" data-tooltip="string">m_flEndSpriteScale</kbd> :
Scale of the second sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite2 Alpha</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iEndSpriteAlpha</kbd> :
Alpha of the second sprite, 255 for full opaque sprite.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite2 Color</b></span> <kbd  class="tooltip" data-tooltip="color255">m_vEndSpriteColor</kbd> :
Second sprite Color override.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Try Once</span> : If set, the env_xenmaker will attempt to spawn only once when triggered, instead of waiting till the spawn-zone is unobscured.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">No Spawn</span> : If set, nothing will spawn at this env_xenmaker. Use this when you only want the visual and audible effect. You still must specify monster to spawn in 'Monster Type' keyvalue, otherwise it will crash the game.</li>
</ul>
</div>
<div class="notices red" markdown="1">If no monstertype type is set, the game will crash with a ''Spawned a NULL entity!'' error, even if the ''No Spawn'' flag was set.</div>
<div class="notices red" markdown="1">Using multiple env_xenmaker at one time sums up emitted sounds, what makes them very loud. It's not really a bug but it's very unpleasant effect.</div>
<div class="notices red" markdown="1">When using an env_xenmaker as an effect-template for squadmakers, you may have to ensure its position in the entity list to be after its according squadmaker(s) in order to avoid a crash on map-load. To achieve that, follow these steps: Select all env_xenmakers in your map and group them. Perform a copy-paste-special or clone-drag (hold shift), leaving the copy in the exact same position as its original. Hide the copy. Delete the original group. Unhide the copy and ungroup it. Save your map.</div>
<div class="notices red" markdown="1">Sprites doesn't work.</div>
