---
title: trigger_entity_iterator
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
<span style="color:#9fc5e8;"><b>Filter Entities by Name</b></span> <kbd  class="tooltip" data-tooltip="target_destination">name_filter</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Entities by Classname</b></span> <kbd  class="tooltip" data-tooltip="string">classname_filter</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter Entities by Status</b></span> <kbd  class="tooltip" data-tooltip="choices">status_filter</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No Filter (default) : Choice_Description_here</li>
<li><b>1 </b> : Only Living Entities : Choice_Description_here</li>
<li><b>2 </b> : Only Dead Entities : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay between Entities (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">delay_between_triggers</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity's Trigger Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity's Trigger State</b></span> <kbd  class="tooltip" data-tooltip="choices">triggerstate</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off : Choice_Description_here</li>
<li><b>1 </b> : On : Choice_Description_here</li>
<li><b>2 </b> : Toggle : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Run Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">run_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Run Once : Choice_Description_here</li>
<li><b>1 </b> : Run Once; Multi-threaded : Choice_Description_here</li>
<li><b>2 </b> : Toggle On/Off : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger at end of each Run</b></span> <kbd  class="tooltip" data-tooltip="target_destination">trigger_after_run</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum Runs (0 for unlimited)</b></span> <kbd  class="tooltip" data-tooltip="integer">maximum_runs</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay before Restarting (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">delay_between_runs</kbd> :
Keyvalue_Description_here
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
