---
title: env_global
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The env_global entity provides the decisive functionality for allowing entity-interaction between maps. More accurately, it allows you to create/set a global variable by a name of your choice. Global variables are set to a use-type of 'On' or 'Off', which can then be used by some entities as their state. E.g. the multisource entity can be set to read its state from a global variable at map load, unless you are having triggers targeting it. This could, for example, be used to make a key for some door collected in one map allow a specific door to be opened in another map.</div>
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
Set name of {{ entname }} so other entities can trigger it to set global state. Any trigger signal type accepted. Can be killtargeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global State to Set</b></span> <kbd  class="tooltip" data-tooltip="string">globalstate</kbd> :
Name of the global state to set. If it does not exist, it will be created.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">triggermode</kbd> :
How to set the global state. Shall it be set to 'On', 'Off', or shall its current state be toggled? If you specify 'Dead', that will delete the global state if it exists.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off</li>
<li><b>1 </b> : On</li>
<li><b>2 </b> : Dead</li>
<li><b>3 </b> : Toggle</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Initial State</b></span> <kbd  class="tooltip" data-tooltip="choices">initialstate</kbd> :
If the 'Set initial state'-flag is set, the given global state will be set to the state specified here. 'Dead' removes the global state in case it exists and should act before any entities can read its global state and won't read anything at all, resulting in default behaviour. For some reason, 'Toggle' is not an option here, possibly because of the undefined case of a non-existing/'uninitialized' global state being told to toggle.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Off</li>
<li><b>1 </b> : On</li>
<li><b>2 </b> : Dead</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Set Initial State : If set, the given global state will be set to the given initial state on map load.</li>
</ul>
</div>
