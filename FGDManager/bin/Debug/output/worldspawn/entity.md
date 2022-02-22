---
title: worldspawn
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Worldspawn is non-interactive entity, everything that builds a map except placed or spawned entities- brushes, sky, tool textures e.t.c. Map itself is an unique entity, which options you can access by going into 'Map'-->'Map properties'. Environmental death are caused by World e.g. when player dies because of fall damage, the entity which killed player is "worldspawn". Whenever mapper is placing new brush into the map, it's becomes the part of the "worldspawn". You can change important settings of your map like sky texture to use, render distance, replacement files and even player models restrictions.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Map description / title</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Title of the map. The usage is unknown- it won't show any kind of text.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Environment map (cl_skyname)</b></span> <kbd  class="tooltip" data-tooltip="string">skyname</kbd> :
Name of sky to use, e.g. 'cliff'. You can check all skies names by going into 'gfx'-->'env' folder, or just choose you sky by going here: Sky List. Note that every sky is split into 6 different files, two last characters represent the direction. Remember to NOT include those characters (as well as '_' symbol in some of skies), if you do, the default sky will be used ('desert'). To determine where the sky will be seen, use 'sky' texture on surfaces where you want your sky.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CD track to play</b></span> <kbd  class="tooltip" data-tooltip="integer">sounds</kbd> :
Doesn't work- it's an old method to play music from CD.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default light level</b></span> <kbd  class="tooltip" data-tooltip="integer">light</kbd> :
Seems to not working.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default wave height</b></span> <kbd  class="tooltip" data-tooltip="string">WaveHeight</kbd> :
Wave height of [func_water](../func_water) entities. It is not overriding func_water "Wave Height" setting.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max viewable distance</b></span> <kbd  class="tooltip" data-tooltip="string">MaxRange</kbd> :
Render distance, higher values for farther distance but slower render. Decrease this value greatly improves performance but causes player to see end of the render plane what looks terrible.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Chapter title message</b></span> <kbd  class="tooltip" data-tooltip="string">chaptertitle</kbd> :
Simple method to show a text message on screen- it's a chapter-type string that appears on map start.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Level fade in</b></span> <kbd  class="tooltip" data-tooltip="choices">startdark</kbd> :
If set to 'Yes', the fade in effect (from completely dark to fully transparent) will be applied as soon as map starts.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Display game title</b></span> <kbd  class="tooltip" data-tooltip="choices">gametitle</kbd> :
If set to 'Yes', the Half Life logo title (as seen in the beginning of Half-Life campaign) will be displayed.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New level unit</b></span> <kbd  class="tooltip" data-tooltip="choices">newunit</kbd> :
Removes data and global triggers from previous levels. Not applicable for Sven Co-op.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No, keep current</li>
<li><b>1 </b> : Yes, clear previous levels</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Map team List</b></span> <kbd  class="tooltip" data-tooltip="string">mapteams</kbd> :
Not supported.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default team</b></span> <kbd  class="tooltip" data-tooltip="choices">defaultteam</kbd> :
Not supported.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Fewest Players</li>
<li><b>1 </b> : First Team</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Roaming monsters (node graph)</b></span> <kbd  class="tooltip" data-tooltip="choices">freeroam</kbd> :
If set to 'Yes', monsters will use nodes (info_node entities) to roam (walk from one point to another freely) at map start. Note that each monster can override this behaviour by "Monster Roaming (nodes)" keyvalue.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Sentences File</b></span> <kbd  class="tooltip" data-tooltip="string">sentence_file</kbd> :
You can specify your own "senteces.txt" file in a replacement of default sentences.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Materials File</b></span> <kbd  class="tooltip" data-tooltip="string">materials_file</kbd> :
You can specify your own "materials.txt" file in a replacement of default material sounds. Example path string: "sound/mapname/filename.txt".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">globalsoundlist</kbd> :
Path to a sound replacement file to use.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Model Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">globalmodellist</kbd> :
Path to a model replacement file to use.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Force Player Models a;b;c etc</b></span> <kbd  class="tooltip" data-tooltip="string">forcepmodels</kbd> :
List of models that can be used for this map, separated by comma "," symbol. Model names are the same as subfolders in "models/player" folder. Note that models not listed here cannot be used in this map.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum game version</b></span> <kbd  class="tooltip" data-tooltip="choices">scversion2</kbd> :
Game version required for this map to run. Leave that as it is.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>524 </b> : 5.24 Patch</li>
<li><b>523 </b> : 5.23 Patch</li>
<li><b>522 </b> : 5.22 Patch</li>
<li><b>521 </b> : 5.21 Patch</li>
<li><b>520 </b> : 5.20 Patch</li>
<li><b>519 </b> : 5.19 Patch</li>
<li><b>518 </b> : 5.18 Patch</li>
<li><b>517 </b> : 5.17 Patch</li>
<li><b>516 </b> : 5.16 Patch</li>
<li><b>515 </b> : 5.15 Patch</li>
<li><b>514 </b> : 5.14 Patch</li>
<li><b>513 </b> : 5.13 Patch</li>
<li><b>512 </b> : 5.12 Patch</li>
<li><b>511 </b> : 5.11 Patch</li>
<li><b>510 </b> : 5.10 Patch</li>
<li><b>509 </b> : 5.09 Patch</li>
<li><b>508 </b> : 5.08 Patch</li>
<li><b>507 </b> : 5.07 Patch</li>
<li><b>506 </b> : 5.06 Patch</li>
<li><b>505 </b> : 5.05 Patch</li>
<li><b>504 </b> : 5.04 Patch</li>
<li><b>503 </b> : 5.03 Patch</li>
<li><b>502 </b> : 5.02 Patch</li>
<li><b>501 </b> : 5.01 Patch</li>
<li><b>500 </b> : 5.0 Milestone</li>
<li><b>480 </b> : 4.8 Update</li>
<li><b>470 </b> : 4.7 Update</li>
<li><b>460 </b> : 4.6 Update</li>
<li><b>450 </b> : 4.5 Update</li>
<li><b>407 </b> : 4.07 Hotfix</li>
<li><b>406 </b> : 4.06 Hotfix</li>
<li><b>405 </b> : 4.05 Hotfix</li>
<li><b>401 </b> : 4.0b1 Milestone</li>
<li><b>400 </b> : 4.0 Internal</li>
<li><b>300 </b> : 3.0 (or earlier)</li>
</ul>
</div>
</div>
</div>
