---
title: path_waypoint
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Path_waypoint is a waypointing entity, mostly works correctly but suffers from few minor bugs. Need to be tested, keep in mind that some keyvalues might not work properly. The most important feature of this entity is that monster following it would always finish his route, even when blocked, attacked, disturbed, after overriding his AI or revived. Use entity by specifying name of first path_waypoint in the monster/squadmaker/monstermaker "Path Name" keyvalue.</div>
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
<span style="color:#9fc5e8;"><b>Next Path_waypoint</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the next path_waypoint to go after entity reach this path_waypoint.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Alternate Next Path_waypoint</b></span> <kbd  class="tooltip" data-tooltip="target_destination">alternate_target</kbd> :
Alternate Waypoint to use.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move to Position</b></span> <kbd  class="tooltip" data-tooltip="Choices">movementtype</kbd> :
How monster will move to this waypoint.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Walk</li>
<li><b>1 </b> : Run</li>
<li><b>2 </b> : Teleport</li>
<li><b>3 </b> : Turn to Face</li>
<li><b>4 </b> : Don't Move</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move within Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">radius</kbd> :
When in radius, monster has finished moving to the waypoint. Only works for Walk / Run.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Face Waypoint Direction</b></span> <kbd  class="tooltip" data-tooltip="choices">useangles</kbd> :
If set to yes, monster's YAW will change gradually to match the path_waypoint's YAW
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default)</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger on Arrival</b></span> <kbd  class="tooltip" data-tooltip="target_destination">trigger_on_arrival</kbd> :
Entity to trigger whenever monster arrives here.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Arrival Animation</b></span> <kbd  class="tooltip" data-tooltip="string">arrival_animation</kbd> :
Animation to play on arrival.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after Arrival Animation</b></span> <kbd  class="tooltip" data-tooltip="target_destination">trigger_after_arrival</kbd> :
Entity to trigger upon completing the arrival animation. If no arrival animation, trigger after Trigger on Arrival is triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait Activity</b></span> <kbd  class="tooltip" data-tooltip="Choices">wait_activity</kbd> :
Controls monster behaviour when waiting at this path_waypoint.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Play Wait Animation (default) : Play wait animation specified in "Wait Animation".</li>
<li><b>1 </b> : Look around : Stay in place, look around.</li>
<li><b>2 </b> : Investigate Area : Wal around close area.</li>
<li><b>3 </b> : Use AI : Let the monster AI take over while waiting.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait Animation</b></span> <kbd  class="tooltip" data-tooltip="string">wait_animation</kbd> :
Animation to play when waiting at this waypoint. (Looped) If animation is blank, the monster will stand in place. If wait time is zero, this is not used.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait Time</b></span> <kbd  class="tooltip" data-tooltip="integer">wait_time</kbd> :
After the position is reached, the monster must wait this long before moving to the next waypoint, and before any targets are triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait Master</b></span> <kbd  class="tooltip" data-tooltip="string">wait_master</kbd> :
Name of the [Multisource](../multisource) entity. Monsters will wait here until multisource is activated.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait Here Until Full</b></span> <kbd  class="tooltip" data-tooltip="choices">waituntilfull</kbd> :
Force monsters to wait until this waypoint is full before proceeding to the next waypoint. If Maximum Occupants is 0, a level error message will occur.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default)</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Departure Animation</b></span> <kbd  class="tooltip" data-tooltip="string">departure_animation</kbd> :
Animation to play before leaving waypoint. "Target On Departure" is triggered after animation completes if animation is present.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger on Departure</b></span> <kbd  class="tooltip" data-tooltip="target_destination">trigger_on_departure</kbd> :
Target to trigger when monster finishes the Departure Animation. If no Departure Animation, trigger immediately after waiting.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Occupant Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">occupant_radius_check</kbd> :
If an monster is within the radius of this path_waypoint, it takes up an occupant slot.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum # Occupants</b></span> <kbd  class="tooltip" data-tooltip="integer">occupant_limit</kbd> :
This point only accepts this number of monsters at a time.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Overflow Waypoint</b></span> <kbd  class="tooltip" data-tooltip="string">overflow_waypoint</kbd> :
If this waypoint is full, monsters will go to the specified waypoint instead. If the provided overflow point is removed or not available, monster will remain at the previous waypoint or position until room is available.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Force Waypoint Completion</b></span> <kbd  class="tooltip" data-tooltip="Choices">force_complete</kbd> :
Forces monster to finish this particular path_waypoint even if a higher priority path is found, provided that the stop conditions are not met. This disables path_condition / path_condition_controller evaluation during the extent of the trip and departure.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default)</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger on Stop Condition</b></span> <kbd  class="tooltip" data-tooltip="string">stop_trigger</kbd> :
If this path_waypoint releases monster because of a stop condition, (e.g. a new enemy appears) something can be triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay before Return</b></span> <kbd  class="tooltip" data-tooltip="integer">restart_delay</kbd> :
If monster has stopped moving because of a stop condition (E.g. hearing a gunshot), the NPC will wait this long before continuing back to this path_waypoint.
</div>
<div class="notices red" markdown="1">When 'Wait Animation' is not specified, and wait activity is set to 'Play Wait Animation', monster will be playing it's last movement animation during wait time.</div>
<div class="notices red" markdown="1">Monsters can be easily interrupted by blocking their way, interacting with them e.t.c. they will finish their route after dealing with interruptions, but there is also possibility that they will start whole path from beginning instead of continuing from last node.</div>
<div class="notices red" markdown="1">When next waypoint is overflowed by 'Maximum # Occupant' monster that are waiting for free slot have problems with their animations.</div>
<div class="notices red" markdown="1">Multiple monsters proceeding nodes with 'Maximum # Occupant' and animation set (e.g. 'Departure Animation') may cause issues with monster walking animation.</div>
