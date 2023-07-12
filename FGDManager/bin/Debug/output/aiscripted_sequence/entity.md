---
title: aiscripted_sequence
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Same as [scripted_sequence](../scripted_sequence), except that this always overrides the AI and never allows any interruptions.</div>
</div>
</div>
<div>
<table class="titletable">
<tbody>
<tr>
<td markdown="1">###Keyvalues</td>
<td class="titletablecheck" id="checkboxandlabel"><input type="checkbox" id="displaycommon"><label for="displaycommon"> Display Common Keyvalues</label></input></td>
</tr>
</tbody>
</table>
<hr>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to play animation. Every trigger use-type works uniformly. Kill-targeting this entity will remove it from map but won't stop animation.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger when animation ends. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Non-functional in {{ entname }}.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Monster</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszEntity</kbd> :
Name of the monster which shall do the sequence. When referencing multiple monsters, only one will react. If you want to make use of the search radius, you can also set a monster classname here.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action Animation</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszPlay</kbd> :
Name of the animation to play when the monster arrives at the {{ entname }}'s location. Animation names and animations vary between monsters. A model viewer like Jed's Half-Life Model Viewer allows you to look at the animations of a Half-Life model file. The action animation is optional.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Search Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flRadius</kbd> :
Radius, in units, in which to search for a valid target monster. This will only work if you specified a monster classname for 'Target monster'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Repeat Rate ms</b></span> <kbd  class="tooltip" data-tooltip="integer">m_flRepeat</kbd> :
Delay, in milliseconds, between checks for whether a valid target monster is within search radius or not. Set this to a large value if not used, as the game even does the check when the 'Search radius' is zero. Setting zero here means that it will check every server frame.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Position</b></span> <kbd  class="tooltip" data-tooltip="Choices">m_fMoveTo</kbd> :
Here, you can set in which manner the monster will move to the {{ entname }}, or to not have it move there at all.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Don't move.</li>
<li><b>1 </b> : Walk : Walk to position. Requires move animation in monster model.</li>
<li><b>2 </b> : Run : Run to position. Requires run animation in monster model.</li>
<li><b>4 </b> : Instantaneous : The monster will be teleported to the {{ entname }}'s position instantly.</li>
<li><b>5 </b> : No - Turn to Face : Monster will end the sequence with looking in the same direction as the {{ entname }}</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">moveto_radius</kbd> :
When the monster hits the supplied radius around the script, it'll stop moving and start its sequence. Useful when the area around the {{ entname }} is hard to navigate or you want your monster to stop in a distance from the {{ entname }} no matter from which direction the monster comes.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>AI Schedule when done</b></span> <kbd  class="tooltip" data-tooltip="Choices">m_iFinishSchedule</kbd> :
Allows you to have the monster's AI schedule change when the sequence is done.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default AI : Nothing changes.</li>
<li><b>1 </b> : Ambush : Monster will be in an attentive state and encounter enemies more actively.</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Repeatable</span> : The {{ entname }} won't be removed after finishing, allowing to use it again.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Leave Corpse</span> : If the action animation is a death animation, causing the monster to die, the corpse will not fade out.</li>
</ul>
</div>
<div class="notices red" markdown="1">If 'Move to position' is set to 'Instantaneous' and you have an action animation set, the monster may freeze up and no longer react.</div>
