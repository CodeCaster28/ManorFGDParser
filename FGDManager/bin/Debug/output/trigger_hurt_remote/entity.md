---
title: trigger_hurt_remote
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This is a more feature-rich variant of [game_player_hurt](../game_player_hurt).</div>
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
Set name of {{ entname }} so other entities can trigger it to apply damage (or enable constant damage when "Constant" flag is checked). With "Constant" flag enabled the behaviour is based on trigger use-type: 'On'- turn constant damage on, 'Off'- turn constant damage off, 'Toggle'- toggle constant damage. With "Constant" flag disabled only "On" and "Toggle" trigger use-types are accepted to apply damage. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Target entity to deal a damage. Write '!activator' to make it hurt activator of the script.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Class</b></span> <kbd  class="tooltip" data-tooltip="string">targetclass</kbd> :
If specified, all entities with the given class will be affected. Write 'player' in this field to make it hurt players.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage</b></span> <kbd  class="tooltip" data-tooltip="integer">dmg</kbd> :
Damage to deal. If "Constant" flag is selected, this is a damage to deal every "Delay" seconds. Can be negative to provide healing instead of dealing damage.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Armor Damage</b></span> <kbd  class="tooltip" data-tooltip="integer">armordmg</kbd> :
Armor damage to deal, works only if "Do Armor" flag is selected. When target is out of armor, the damage is not dealt. Can be negative to give an armor instead of draining it.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay (Only when Constant)</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay between hurts when "Constant" flag is selected.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage Type</b></span> <kbd  class="tooltip" data-tooltip="choices">damagetype</kbd> :
Used for HUD info icon, determines which damage icon appears when player is taking damage from trigger.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : GENERIC</li>
<li><b>1 </b> : CRUSH</li>
<li><b>2 </b> : BULLET</li>
<li><b>4 </b> : SLASH</li>
<li><b>8 </b> : BURN</li>
<li><b>16 </b> : FREEZE</li>
<li><b>32 </b> : FALL</li>
<li><b>64 </b> : BLAST</li>
<li><b>128 </b> : CLUB</li>
<li><b>256 </b> : SHOCK</li>
<li><b>512 </b> : SONIC</li>
<li><b>1024 </b> : ENERGYBEAM</li>
<li><b>16384 </b> : DROWN</li>
<li><b>32768 </b> : PARALYSE</li>
<li><b>65536 </b> : NERVEGAS</li>
<li><b>131072 </b> : POISON</li>
<li><b>262144 </b> : RADIATION</li>
<li><b>524288 </b> : DROWNRECOVER</li>
<li><b>1048576 </b> : CHEMICAL</li>
<li><b>2097152 </b> : SLOWBURN</li>
<li><b>4194304 </b> : SLOWFREEZE</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Instant Kill</span> : Kill the target instantly. That will heal the target instantly when "Damage" value is negative.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Constant</span> : Make use of "Delay" keyvalue and affect target entities repeatedly.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Start On</span> : Trigger_hurt_remote is enabled at start, this only makes sense when "Constant" flag is selected.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Do Armor</span> : Allows to use "Armor Damage" keyvalue.</li>
</ul>
</div>
<div class="notices red" markdown="1">Constant feature is unstable for server, it's recommended to trigger this entity with looped [multi_manager](../multi_manager) to achieve similar effect.</div>
