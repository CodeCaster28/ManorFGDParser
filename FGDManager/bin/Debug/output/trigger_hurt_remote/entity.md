---
title: trigger_hurt_remote
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
<span style="color:#9fc5e8;"><b>Target Class</b></span> <kbd  class="tooltip" data-tooltip="string">targetclass</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage</b></span> <kbd  class="tooltip" data-tooltip="integer">dmg</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Armor Damage</b></span> <kbd  class="tooltip" data-tooltip="integer">armordmg</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay (Only when Constant)</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage Type</b></span> <kbd  class="tooltip" data-tooltip="choices">damagetype</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : GENERIC : Choice_Description_here</li>
<li><b>1 </b> : CRUSH : Choice_Description_here</li>
<li><b>2 </b> : BULLET : Choice_Description_here</li>
<li><b>4 </b> : SLASH : Choice_Description_here</li>
<li><b>8 </b> : BURN : Choice_Description_here</li>
<li><b>16 </b> : FREEZE : Choice_Description_here</li>
<li><b>32 </b> : FALL : Choice_Description_here</li>
<li><b>64 </b> : BLAST : Choice_Description_here</li>
<li><b>128 </b> : CLUB : Choice_Description_here</li>
<li><b>256 </b> : SHOCK : Choice_Description_here</li>
<li><b>512 </b> : SONIC : Choice_Description_here</li>
<li><b>1024 </b> : ENERGYBEAM : Choice_Description_here</li>
<li><b>16384 </b> : DROWN : Choice_Description_here</li>
<li><b>32768 </b> : PARALYSE : Choice_Description_here</li>
<li><b>65536 </b> : NERVEGAS : Choice_Description_here</li>
<li><b>131072 </b> : POISON : Choice_Description_here</li>
<li><b>262144 </b> : RADIATION : Choice_Description_here</li>
<li><b>524288 </b> : DROWNRECOVER : Choice_Description_here</li>
<li><b>1048576 </b> : CHEMICAL : Choice_Description_here</li>
<li><b>2097152 </b> : SLOWBURN : Choice_Description_here</li>
<li><b>4194304 </b> : SLOWFREEZE : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Instant Kill</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Constant</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Start On</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Do Armor</span> : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
