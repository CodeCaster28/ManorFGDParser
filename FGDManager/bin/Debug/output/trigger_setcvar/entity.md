---
title: trigger_setcvar
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
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
This always means an identifier for the entity in question so other entities can trigger or refer to it. Many entities need no name, or behave differently depending on whether they have one or not.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CVAR (only these are allowed)</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iszCVarToChange</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"mp_allowmonsterinfo"</b> : mp_allowmonsterinfo : Choice_Description_here</li>
<li><b>"mp_banana"</b> : mp_banana : Choice_Description_here</li>
<li><b>"mp_barnacle_paralyze"</b> : mp_barnacle_paralyze : Choice_Description_here</li>
<li><b>"mp_disablegaussjump"</b> : mp_disablegaussjump : Choice_Description_here</li>
<li><b>"mp_disable_autoclimb"</b> : mp_disable_autoclimb : Choice_Description_here</li>
<li><b>"mp_disable_pcbalancing"</b> : mp_disable_pcbalancing : Choice_Description_here</li>
<li><b>"mp_disable_player_rappel"</b> : mp_disable_player_rappel : Choice_Description_here</li>
<li><b>"mp_dropweapons"</b> : mp_dropweapons : Choice_Description_here</li>
<li><b>"mp_falldamage"</b> : mp_falldamage : Choice_Description_here</li>
<li><b>"mp_flashlight"</b> : mp_flashlight : Choice_Description_here</li>
<li><b>"mp_forcerespawn"</b> : mp_forcerespawn : Choice_Description_here</li>
<li><b>"mp_fraglimit"</b> : mp_fraglimit : Choice_Description_here</li>
<li><b>"mp_grapple_mode"</b> : mp_grapple_mode : Choice_Description_here</li>
<li><b>"mp_monsterpoints"</b> : mp_monsterpoints : Choice_Description_here</li>
<li><b>"mp_noblastgibs"</b> : mp_noblastgibs : Choice_Description_here</li>
<li><b>"mp_nomedkit"</b> : mp_nomedkit : Choice_Description_here</li>
<li><b>"mp_no_akimbo_uzis"</b> : mp_no_akimbo_uzis : Choice_Description_here</li>
<li><b>"mp_npckill"</b> : mp_npckill : Choice_Description_here</li>
<li><b>"mp_pcbalancing_factorlist"</b> : mp_pcbalancing_factorlist : Choice_Description_here</li>
<li><b>"mp_respawndelay"</b> : mp_respawndelay : Choice_Description_here</li>
<li><b>"mp_timelimit"</b> : mp_timelimit : Choice_Description_here</li>
<li><b>"mp_weaponstay"</b> : mp_weaponstay : Choice_Description_here</li>
<li><b>"mp_weapon_respawndelay"</b> : mp_weapon_respawndelay : Choice_Description_here</li>
<li><b>"mp_ammo_respawndelay"</b> : mp_ammo_respawndelay : Choice_Description_here</li>
<li><b>"mp_item_respawndelay"</b> : mp_item_respawndelay : Choice_Description_here</li>
<li><b>"npc_dropweapons"</b> : npc_dropweapons : Choice_Description_here</li>
<li><b>"skill"</b> : skill : Choice_Description_here</li>
<li><b>"sk_"</b> : sk_* (see skill.cfg) : Choice_Description_here</li>
<li><b>"sv_ai_enemy_detection_mode"</b> : sv_ai_enemy_detection_mode : Choice_Description_here</li>
<li><b>"sv_accelerate"</b> : sv_accelerate : Choice_Description_here</li>
<li><b>"sv_airaccelerate"</b> : sv_airaccelerate : Choice_Description_here</li>
<li><b>"sv_friction"</b> : sv_friction : Choice_Description_here</li>
<li><b>"sv_gravity"</b> : sv_gravity : Choice_Description_here</li>
<li><b>"sv_maxspeed"</b> : sv_maxspeed : Choice_Description_here</li>
<li><b>"sv_wateraccelerate"</b> : sv_wateraccelerate : Choice_Description_here</li>
<li><b>"sv_waterfriction"</b> : sv_waterfriction : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New Value</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after set</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Which CVARs to set</b></span> <kbd  class="tooltip" data-tooltip="choices">SetType</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : All : Choice_Description_here</li>
<li><b>1 </b> : Engine : Choice_Description_here</li>
<li><b>2 </b> : Angelscript : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
