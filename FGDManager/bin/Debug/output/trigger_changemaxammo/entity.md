---
title: trigger_changemaxammo
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity, when triggered, changes maximum ammo amount of selected ammo type, also allows to replenish ammo to maximum.</div>
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
Set name of {{ entname }} so other entities can trigger it to change max ammo. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after fire</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger whenever {{ entname }} is triggered. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ammo name</b></span> <kbd  class="tooltip" data-tooltip="choices">message</kbd> :
Choose ammo type to change ammo limit from drop-down menu.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"9mm" </b> : 9mm Rounds</li>
<li><b>"bolts" </b> : Crossbow Bolts</li>
<li><b>"357" </b> : .357 Rounds</li>
<li><b>"uranium" </b> : Uranium Ammo</li>
<li><b>"Hand Grenade" </b> : Hand Grenades</li>
<li><b>"Hornets" </b> : Hornets</li>
<li><b>"556" </b> : 5.56 Rounds</li>
<li><b>"ARgrenades" </b> : AR Grenades</li>
<li><b>"health" </b> : Health (Medkit Ammo)</li>
<li><b>"rockets" </b> : Rockets</li>
<li><b>"Satchel Charge" </b> : Satchel Charges</li>
<li><b>"shock charges" </b> : Shock Rifle Ammo</li>
<li><b>"buckshot" </b> : Shotgun Ammo</li>
<li><b>"m40a1" </b> : Sniper Rifle Ammo</li>
<li><b>"sporeclip" </b> : Spore Launcher Ammo</li>
<li><b>"Snarks" </b> : Snarks</li>
<li><b>"Trip Mine" </b> : Trip Mines</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Value to use</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iMaxAmmo</kbd> :
Value to use along with "Change max ammo mode".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Change Max Ammo Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">m_Mode</kbd> :
Set up the way the new ammo limit is modified.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Set : "Value to use" is now maximum ammo amount.</li>
<li><b>1 </b> : Reset : "Value to use" is added to the current maximum ammo amount.</li>
<li><b>2 </b> : Add : "Value to use" is subtracted from the current maximum ammo amount.</li>
<li><b>3 </b> : Subtract : Maximum ammo amount is reverted to it's default value.</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">All players</span> : Apply new ammo limit rules to all players (normally, the amount affects only '!activator').</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Remove excess ammo</span> : Remove ammo limit completely.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Set ammo to new max</span> : Replenishes player(s) ammo to maximum.</li>
</ul>
</div>
