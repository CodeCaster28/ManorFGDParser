---
title: trigger_effect
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Apply chosen effects or modifiers to target players or monsters. This includes visual effects like glow shell but also modifiers to speed, friction, gravity and more. Multiple effects can be applied at once. Each effect can be either added or subtracted. Effect can be added and subtracted multiple times, even if an effect name suggests it can be either disabled or enabled, e.g. applying invisibility to player with 'Add' value three times (by triggering trigger_effect three times) makes player invisible at first 'Add' but the second and third trigger still counts. In that case another trigger_effect must apply invisibility with 'Subtract' value to make player visible again.</div>
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
Set name of {{ entname }} so other entities can trigger it apply effect(s). Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Target to apply effects on. Supports use of !activator and !caller.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Glow shell mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_glow_mode</kbd> :
Specify if glow shell effect should be added or subtracted from player. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Glow shell color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">effect_glow</kbd> :
Color to add or subtract if 'Glow Shell Mode' is other than 'No Change'. This allow to mix color when multiple trigger_effects are used e.g. first one can have 'Glow Shell Mode' set to 'Add' with value of 0 255 140, and the second can have 'Glow Shell Mode' set to 'Subtract' with value of 0 155 10. Player would end up with glow shell color of 0 100 130. Note that this value can drop below 0 0 0 and go above 255 255 255 and trigger_effect can add or subtract specified value infinitely every time it's triggered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Block weapons</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_block_weapons_mode</kbd> :
Add 1 or subtract 1 from effect that prevent usage of weapons. Note that this value can drop below 0 go above 1 because trigger_effect can add or subtract value infinitely every time it's triggered, yet it's always blocks target weapon the same way if total value is more than 0. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invulnerable</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invulnerable_mode</kbd> :
Add 1 or subtract 1 from effect that makes target invulnerable. Note that this value can drop below 0 go above 1 because trigger_effect can add or subtract value infinitely every time it's triggered, yet it's always makes target invulnerable the same way if total value is more than 0. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_invisible_mode</kbd> :
Add 1 or subtract 1 from effect that makes target invisible. Note that this value can drop below 0 go above 1 because trigger_effect can add or subtract value infinitely every time it's triggered, yet it's always makes target invisible the same way if total value is more than 0. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Non-solid</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_nonsolid_mode</kbd> :
Add 1 or subtract 1 from effect that makes target non solid to certain objects. Note that this value can drop below 0 go above 1 because trigger_effect can add or subtract value infinitely every time it's triggered, yet it's always makes target non-solid the same way if total value is more than 0. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time before drown mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_respiration_mode</kbd> :
Specify if time before drown modifier effect should be added or subtracted from target. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time before drown (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_respiration</kbd> :
Seconds of time before drown to add or subtract if 'Time Before Drown Mode' is other than 'No Change'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Friction modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_friction_mode</kbd> :
Specify if friction modifier effect should be added or subtracted from target. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Friction modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_friction</kbd> :
Friction percentage to add or subtract if 'Friction Modifier Mode' is other than 'No Change'. Value specified is a percentage of target's total friction, so subtracting 50 and adding 50 will end up with normal friction.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gravity modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_gravity_mode</kbd> :
Specify if gravity modifier effect should be added or subtracted from target. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gravity modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_gravity</kbd> :
Gravity percentage to add or subtract if 'Gravity Modifier Mode' is other than 'No Change'. Value specified is a percentage of target's total gravity, so subtracting 50 and adding 50 will end up with normal gravity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_speed_mode</kbd> :
Specify if speed modifier effect should be added or subtracted from target. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_speed</kbd> :
Speed percentage to add or subtract if 'Speed Modifier Mode' is other than 'No Change'. Value specified is a percentage of target's total speed, so subtracting 50 and adding 50 will end up with normal speed. This value can go above 100 and below 0 but final target's speed will be kept between 0 and 100 value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage modifier mode</b></span> <kbd  class="tooltip" data-tooltip="choices">effect_damage_mode</kbd> :
Specify if damage modifier effect should be added or subtracted from target. Leave 'No change' to disable effect change.
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No change</li>
<li><b>1 </b> : Add</li>
<li><b>2 </b> : Subtract</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage modifier (%)</b></span> <kbd  class="tooltip" data-tooltip="string">effect_damage</kbd> :
Damage percentage to add or subtract if 'Damage Modifier Mode' is other than 'No Change'. Value specified is a percentage of target's total damage, so subtracting 50 and adding 50 will end up with normal damage. This can go above 100 and below 0 so damage will heal instead.
</div>
</div>
