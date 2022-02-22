---
title: env_message
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">An entity to display messages from the titles.txt file on the HUD. You probably are better off with the much more customizable [game_text](../game_text) entity.</div>
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
Set name of {{ entname }} so other entities can trigger it to display message.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of entity to trigger (fire). Which function relates to it depends on the respective entity. Most will just trigger their target, while others will perform actions on their target or use it as a reference for other activities. Often, multiple entities by the same name may be targeted. Most entities need no target, but having one is essential for most logic entities and basic trigger-systems.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Message Name</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Name of the message from titles.txt to display.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Effect</b></span> <kbd  class="tooltip" data-tooltip="sound">messagesound</kbd> :
An optional sound effect to play. Path starts in the 'sound'-folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Volume 0-10</b></span> <kbd  class="tooltip" data-tooltip="string">messagevolume</kbd> :
The volume, from 0 to 10, to play the sound at.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Radius</b></span> <kbd  class="tooltip" data-tooltip="Choices">messageattenuation</kbd> :
The radius in which the sound can be heard.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Small Radius</li>
<li><b>1 </b> : Medium Radius</li>
<li><b>2 </b> : Large  Radius</li>
<li><b>3 </b> : Play Everywhere</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Play Once</span> : The message can show up only once.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">All Clients</span> : Everyone will see the message, instead of only the !activator.</li>
</ul>
</div>
