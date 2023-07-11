---
title: trigger_track_goal
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows calling a [func_tracktrain](../func_tracktrain) to a specific [path_track](../path_track). The func_train and path_corner entities are not supported and will cause the game to crash if used in combination with this anyway.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<span style="color:#cae4fc;"><b>OnDestroy Function</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to send a func_tracktrain to specified path. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of a func_tracktrain to send towards a path_track.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Name</b></span> <kbd  class="tooltip" data-tooltip="string">path_name</kbd> :
Name of a path_track entity which the targeted func_tracktrain can reach.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound to play if no path is available</b></span> <kbd  class="tooltip" data-tooltip="sound">m_iszSoundNoPath</kbd> :
If there is no another path_track this train can be direct to, this is the sound to play when it happens.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Stopped Only</span> :  If set, trigger_track_goal will only allow the train to be called when it is currently not moving.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Don't move if no path available</span> : Prevents the train from moving backward if it can't find another path for func_tracktrain.</li>
</ul>
</div>
<div class="notices red" markdown="1">Causing the train to move backwards on its path only works in looped tracks.</div>
