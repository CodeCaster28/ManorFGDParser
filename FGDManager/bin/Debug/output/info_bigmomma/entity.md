---
title: info_bigmomma
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Navigation points specially designed for [monster_bigmomma](../monster_bigmomma). It will travel through navigation points playing animations and regaining health if specified. Monster_bigmomma won't continue travel to new point until it lose regained health. In original Half Life campaign monster_bigmomma travel further after running out of health, then regenerating at another info_bigmomma, repeating the process after reaching final navigation point where Gonarch breaks the web and player can process. Gonarch can't die while in info_bigmomma path.</div>
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
Set name of {{ entname }} so other nodes can link to this. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Next node</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
The name of next node to go after loosing all additional health from "health on approach".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Radius</b></span> <kbd  class="tooltip" data-tooltip="string">radius</kbd> :
Radius of where Gonarch can seek this node to go to it. Higher value increased chances of Gonarch to find this node. Player must goad the Gonarch to info_bigmomma if radius isn't high enough.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Wait after approach</b></span> <kbd  class="tooltip" data-tooltip="string">reachdelay</kbd> :
Number of seconds Gonarch will wait at this point before proceeding further.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>KillTarget</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity or entities to destroy when this node is reached.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fire on approach</b></span> <kbd  class="tooltip" data-tooltip="target_destination">reachtarget</kbd> :
Entity to trigger when Gonarch reach this point. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence on approach</b></span> <kbd  class="tooltip" data-tooltip="string">reachsequence</kbd> :
Name of monster_bigmomma sequence to play when it reaching this point.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Health on approach</b></span> <kbd  class="tooltip" data-tooltip="string">health</kbd> :
Health to set for Gonarch when it reaching this point. Gonarch won't advance until loosing specified health. Set it to 0 to make Gonarch proceed to next node. Leave it empty for default.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sequence before approach</b></span> <kbd  class="tooltip" data-tooltip="string">presequence</kbd> :
Name of monster_bigmomma sequence to play before it reaching this point.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Run To Node</span> : Run to this node instead of walking.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Wait Indefinitely</span> : Disable monster AI at this point. Useful when waiting for player to change level.</li>
</ul>
</div>
