---
title: game_player_team
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Originally created by Valve, doesn't work in Sven Co-op, where there is only one team. You can still make teams by using [trigger_changevalue](../trigger_changevalue) and change !activator's "classify" key.</div>
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
<span style="color:#9fc5e8;"><b>game_team_master to use</b></span> <kbd  class="tooltip" data-tooltip="string">target</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :

</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Remove On fire</span></li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Kill Player</span></li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Gib Player</span></li>
</ul>
</div>
