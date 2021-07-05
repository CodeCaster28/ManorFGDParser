---
title: path_condition
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
<span style="color:#9fc5e8;"><b>Delay Interval</b></span> <kbd  class="tooltip" data-tooltip="string">delay_interval</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Conditions (Definition Name)</b></span> <kbd  class="tooltip" data-tooltip="string">conditions_reference</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Min Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">mindistance</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max Distance</b></span> <kbd  class="tooltip" data-tooltip="integer">maxdistance</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger on Stop Condition</b></span> <kbd  class="tooltip" data-tooltip="string">starttrigger</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Priority Level</b></span> <kbd  class="tooltip" data-tooltip="integer">priority</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Waypoint Selection</b></span> <kbd  class="tooltip" data-tooltip="Choices">selecttype</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Start Waypoint : Choice_Description_here</li>
<li><b>1 </b> : Nearest Waypoint to NPC : Choice_Description_here</li>
<li><b>2 </b> : Random Waypoint : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pre-Waypoint Destination</b></span> <kbd  class="tooltip" data-tooltip="Choices">pre_location</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : None (Default) : Choice_Description_here</li>
<li><b>1 </b> : Use This Origin : Choice_Description_here</li>
<li><b>2 </b> : Enemy : Choice_Description_here</li>
<li><b>3 </b> : Dead Enemy : Choice_Description_here</li>
<li><b>4 </b> : Sound : Choice_Description_here</li>
<li><b>5 </b> : Scent : Choice_Description_here</li>
<li><b>6 </b> : Near Hiding Spot : Choice_Description_here</li>
<li><b>7 </b> : Far Hiding Spot : Choice_Description_here</li>
<li><b>8 </b> : Named Entity : Choice_Description_here</li>
<li><b>9 </b> : Entity by Key:Value : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pre-Waypoint Parameters</b></span> <kbd  class="tooltip" data-tooltip="string">pre_location_values</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Start Waypoint</b></span> <kbd  class="tooltip" data-tooltip="string">path_start</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path_Waypoint List</b></span> <kbd  class="tooltip" data-tooltip="string">waypoint_list</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>NPC Keyvalue Filter</b></span> <kbd  class="tooltip" data-tooltip="string">key_filter</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>NPC Trigger Target</b></span> <kbd  class="tooltip" data-tooltip="string">npc_trigger_target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>NPC Trigger Interval</b></span> <kbd  class="tooltip" data-tooltip="integer">npc_trigger_interval</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Angelscript condition name</b></span> <kbd  class="tooltip" data-tooltip="string">m_szASConditionsName</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Start Off : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
