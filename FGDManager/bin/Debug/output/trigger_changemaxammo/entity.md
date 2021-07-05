---
title: trigger_changemaxammo
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
<span style="color:#9fc5e8;"><b>Trigger after fire</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ammo name</b></span> <kbd  class="tooltip" data-tooltip="choices">message</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"9mm" </b> : 9mm Rounds : Choice_Description_here</li>
<li><b>"bolts" </b> : Crossbow Bolts : Choice_Description_here</li>
<li><b>"357" </b> : .357 Rounds : Choice_Description_here</li>
<li><b>"uranium" </b> : Uranium Ammo : Choice_Description_here</li>
<li><b>"Hand Grenade" </b> : Hand Grenades : Choice_Description_here</li>
<li><b>"Hornets" </b> : Hornets : Choice_Description_here</li>
<li><b>"556" </b> : 5.56 Rounds : Choice_Description_here</li>
<li><b>"ARgrenades" </b> : AR Grenades : Choice_Description_here</li>
<li><b>"health" </b> : Health (Medkit Ammo) : Choice_Description_here</li>
<li><b>"rockets" </b> : Rockets : Choice_Description_here</li>
<li><b>"Satchel Charge" </b> : Satchel Charges : Choice_Description_here</li>
<li><b>"shock charges" </b> : Shock Rifle Ammo : Choice_Description_here</li>
<li><b>"buckshot" </b> : Shotgun Ammo : Choice_Description_here</li>
<li><b>"m40a1" </b> : Sniper Rifle Ammo : Choice_Description_here</li>
<li><b>"sporeclip" </b> : Spore Launcher Ammo : Choice_Description_here</li>
<li><b>"Snarks" </b> : Snarks : Choice_Description_here</li>
<li><b>"Trip Mine" </b> : Trip Mines : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Value to use</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iMaxAmmo</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Change Max Ammo Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">m_Mode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Set : Choice_Description_here</li>
<li><b>1 </b> : Reset : Choice_Description_here</li>
<li><b>2 </b> : Add : Choice_Description_here</li>
<li><b>3 </b> : Subtract : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : All players : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Remove excess ammo : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Set ammo to new max : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
