---
title: trigger_effect
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
<span style="color:#9fc5e8;"><b>Glow shell mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_glow_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Glow shell color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">effect_glow</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Block weapons</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_block_weapons_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invulnerable</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invulnerable_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invisible_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Non-solid</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_nonsolid_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time before drown mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_respiration_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time before drown (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_respiration</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Friction modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_friction_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Friction modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_friction</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gravity modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_gravity_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gravity modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_gravity</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_speed_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_speed</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_damage_mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change : Choice_Description_here</li>
<li><b>1 </b> : Add : Choice_Description_here</li>
<li><b>2 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_damage</kbd> :
Keyvalue_Description_here
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
