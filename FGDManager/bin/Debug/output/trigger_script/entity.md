---
title: trigger_script
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This powerful entity allows you to put scripts made with AngelScript language on your map. You can find more info about trigger_script and scripting [here](https://github.com/baso88/SC_AngelScript/wiki/trigger_script).</div>
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
Set name of {{ entname }} so other entities can trigger it to run script.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to trigger (fire). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Same as target, except that this supposedly causes the specified entity/entities to be removed from the game. Not all entities which have a target to trigger will also handle killtarget. You may want to use a [trigger_relay](../trigger_relay) to make sure it is working.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Script to load</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszScriptFile</kbd> :
The name of the script to load in "scripts\maps" directory, e.g. "mymap/my_script1". This can be left empty if the function already exists from scripts specified via map_script in cfg.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Function to execute on trigger</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszScriptFunctionName</kbd> :
Function (declared in the opened script file) to call when trigger_script is triggered. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time between thinks</b></span> <kbd  class="tooltip" data-tooltip="string">m_flThinkDelta</kbd> :
If "Mode" is set to 'Think', this is a time delay between script calls.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iMode</kbd> :
Script call mode.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>1 </b> : Trigger : Allows to execute script once.</li>
<li><b>2 </b> : Think : Executes script every X seconds (specified in "Time between thinks").</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start on</span> : Script is activated on start.</li>
</ul>
</div>
