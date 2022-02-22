---
title: scripted_sequence
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A point entity, which allows you to order a monster to walk or run to a specific location and, if wanted, play an animation. Furthermore, you may set up an idle animation which will play for the targeted monster till the scripted_sequence entity is triggered or have a specific monster or monster class use the scripted_sequence when entering its radius.</div>
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
Set name of {{ entname }} so other entities can trigger it to play sequence. This will also toggle idle animation if specified. Every trigger use-type works uniformly. Can be kill-targeted which also stops action and idle animations.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger when sequence ends. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when sequence ends.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Monster</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszEntity</kbd> :
Name of the monster which shall do the sequence. When referencing multiple monsters, only one will react. If you want to make use of the search radius, you can also set a monster classname here.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action Animation</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszPlay</kbd> :
Name of the animation to play when the monster arrives at the scripted_sequence's location. Animation names and animations vary between monsters. A model viewer like Jed's Half-Life Model Viewer allows you to look at the animations of a Half-Life model file. The action animation is optional.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Idle Animation</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszIdle</kbd> :
If set, this animation will play for the target monster till the scripted_sequence is triggered. The animation should be an idle animation and the scripted_sequence requires a targetname for this to work.
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
<span style="color:#9fc5e8;"><b>Move to Position</b></span> <kbd  class="tooltip" data-tooltip="choices">m_fMoveTo</kbd> :
Here, you can set in which manner the monster will move to the scripted_sequence, or to not have it move there at all. 'Turn to face', as all other options besides 'No', means that the monster will end the sequence with looking in the same direction as the scripted_sequence, followed by the action animation (You may change the scripted_sequence's yaw).
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Default and only bug-free setting. Idle animation is looped until triggered to play action animation.</li>
<li><b>1 </b> : Walk : Monster walks to this entity position, idle animation won't play, action animation plays automatically.</li>
<li><b>2 </b> : Run : Monster runs to this entity position, idle animation won't play, action animation plays automatically.</li>
<li><b>4 </b> : Instantaneous : Teleports to this entity then playing idle animation until triggered.</li>
<li><b>5 </b> : No - Turn to Face : Idle animation playing infinitely, blocks action animation so entity cannot be triggered.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">moveto_radius</kbd> :
When the monster hits the supplied radius around the script, it'll stop moving and start its sequence. Useful when the area around the scripted_sequence is hard to navigate or you want your monster to stop in a distance from the scripted_sequence no matter from which direction the monster comes.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Repeatable</span> : The scripted_sequence won't be removed after finishing, allowing to use it again.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Leave Corpse</span> : If the action animation is a death animation, causing the monster to die, the corpse will not fade out.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">No Interruptions</span> : The sequence will not end unless the monster finishes it. The monster can take damage, but won't die.</li>
<li class="imagepadding" markdown="1"><b>64</b> : <span style="color:#9fc5e8;">Override AI</span> : Forces the monster to start the sequence regardless of its state. With this set, the sequence will start even when the monster is under attack by something.</li>
<li class="imagepadding" markdown="1"><b>128</b> : <span style="color:#9fc5e8;">No Script Movement</span> : Certain target animations cause the monster to change its position. (E.g., an animation of the monster jumping ahead a few meters) This flag prevents the animation from causing the monster to get moved.</li>
<li class="imagepadding" markdown="1"><b>256</b> : <span style="color:#9fc5e8;">No Reset Entity</span> : y default, the monster is 'reset' after the sequence ends. This means, that its recent activity will be stopped and no animation interpolation will be done. The monster will appear to suddenly start its next action/animation of its own common AI behaviour, depending on the circumstances. Activity means the very action the monster is doing in a moment. These can be different attacks, movements into different directions, the monster flinching from the impact of an attack, dying or doing anything it can do. (E.g.: Barney has two activity states for drawing/holstering his gun.) Checking this flag disables this behaviour, causing a smoother transition from the end of the sequence to the monster picking up its AI again, in the sense of visual appearance and monster action. This comes at the risk of unwanted effects. You may experiment with this.</li>
</ul>
</div>
<div class="notices red">If 'Move to position' is set to 'Instantaneous' and you have an action animation set, the monster may freeze up and no longer react.</div>
<div class="notices red">If 'Move to position' is set to 'No- Turn To Face' the idle animation won't stop playing when this entity is triggered.</div>
<div class="notices red">If 'Move to position' is set to 'Run' or 'Walk' the idle animation won't play, and the whole animation is not played smoothly.</div>
<div class="notices red">Kill-targeting this entity crashes the game when action animation ends or idle animation is being played.</div>
