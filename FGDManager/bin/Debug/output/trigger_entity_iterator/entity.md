---
title: trigger_entity_iterator
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity allows you to simulate one or multiple entities triggering a specific other entity. For example, you can have all entities of classname "player" trigger a [trigger_condition](../trigger_condition), or all entities with targetname "zombie" trigger a [trigger_copyvalue](../trigger_copyvalue). The triggered entity will receive every iterated entity as activator.</div>
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
Set name of {{ entname }} so other entities can trigger it to start iterating. Depending on trigger use-type: 'On'- start iterating or reset it if already running, 'Toggle'- start iterating or stop it if already running, 'Off'- stop iterating. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Entities by Name</b></span> <kbd  class="tooltip" data-tooltip="target_destination">name_filter</kbd> :
Any entity/entities by the given name will be iterated, given they also are of the specific class set in "Filter Entities by Classname" (if set).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Entities by Classname</b></span> <kbd  class="tooltip" data-tooltip="string">classname_filter</kbd> :
Any entity/entities by the given classname will be iterated, given they also match the name set in "Filter Entities by Name" (if set).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Entities by Status</b></span> <kbd  class="tooltip" data-tooltip="choices">status_filter</kbd> :
Depending on what other option than "No Filter (default)" you set, additionally to the filtering by name and classname through the two above keyvalues, either only dead or only alive entities will be iterated over. (An entity is considered alive while the PEV "deadflag" is 0)
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Filter (default)</li>
<li><b>1 </b> : Only Living Entities</li>
<li><b>2 </b> : Only Dead Entities</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay between Entities (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">delay_between_triggers</kbd> :
Specify a delay, in seconds, between the individual iterations. E.g. when iterating over several zombies, this would be the delay between iterating every single zombie. A value of 0 disables this (default), causing all iteration-entities to be iterated in one go. A very low value like 0.00001 would mean to iterate over one entity every server frame.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity's Trigger Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the entity to be triggered by the individual iteration/activator-entities. It "carries" the iteration.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity's Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Set the use-type with which the iterated/activating entities will fire the iteration carrier-entity set by "Trigger Target".
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off</li>
<li><b>1 </b> : On</li>
<li><b>2 </b> : Toggle</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Run Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">run_mode</kbd> :
Set the mode of which targets are triggered.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Run Once : Default, single-fire behaviour.</li>
<li><b>1 </b> : Run Once; Multi-threaded : Every time you trigger this, a temporary copy will be created and perform one full run, then remove itself from the game. You can have multiple copies run simultaneously. This only makes sense with a non-zero "Delay between Entities (secs)".</li>
<li><b>2 </b> : Toggle On/Off : This entity becomes toggleable and will have a delay between complete iteration-passes of all iteration-entities, set by "Delay before Restarting (secs)".</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger at end of each Run</b></span> <kbd  class="tooltip" data-tooltip="target_destination">trigger_after_run</kbd> :
Entity to trigger after a full run has been completed/performed. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum Runs (0 for unlimited)</b></span> <kbd  class="tooltip" data-tooltip="integer">maximum_runs</kbd> :
Specify how many complete iteration-passes may be performed before this entity is removed from the game. Set this to 0 to disable this feature.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay before Restarting (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">delay_between_runs</kbd> :
Specify a delay, in seconds, between complete iteration-passes. E.g. when iterating several zombies, this would be the delay between iterating all of those zombies and then iterating all of those zombies again. This is only relevant in constant mode and the individual interval will still be considered when this is used. A value of 0 will always cause a delay of a single server frame. The individual interval will not add onto this.
</div>
<div class="notices blue" markdown="1">If "Run Mode" is set to 'Run Once' and if trigger_entity_iterator is triggered while currently running (delay between triggers greater than zero), it will stop and restart the iteration process immediately when triggered with use-type "On", but simply stop when triggered with any other use-type.</div>
