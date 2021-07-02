---
title: worldspawn
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
<span style="color:#9fc5e8;"><b>Map description / title</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Environment map (cl_skyname)</b></span> <kbd  class="tooltip" data-tooltip="string">skyname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CD track to play</b></span> <kbd  class="tooltip" data-tooltip="integer">sounds</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default light level</b></span> <kbd  class="tooltip" data-tooltip="integer">light</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default wave height</b></span> <kbd  class="tooltip" data-tooltip="string">WaveHeight</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Max viewable distance</b></span> <kbd  class="tooltip" data-tooltip="string">MaxRange</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Chapter title message</b></span> <kbd  class="tooltip" data-tooltip="string">chaptertitle</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Level fade in</b></span> <kbd  class="tooltip" data-tooltip="choices">startdark</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Display game title</b></span> <kbd  class="tooltip" data-tooltip="choices">gametitle</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>New level unit</b></span> <kbd  class="tooltip" data-tooltip="choices">newunit</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No, keep current : Choice_Description_here</li>
<li><b>1 </b> : Yes, clear previous levels : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Map team List</b></span> <kbd  class="tooltip" data-tooltip="string">mapteams</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Default team</b></span> <kbd  class="tooltip" data-tooltip="choices">defaultteam</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Fewest Players : Choice_Description_here</li>
<li><b>1 </b> : First Team : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Roaming monsters (node graph)</b></span> <kbd  class="tooltip" data-tooltip="choices">freeroam</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Sentences File</b></span> <kbd  class="tooltip" data-tooltip="string">sentence_file</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Materials File</b></span> <kbd  class="tooltip" data-tooltip="string">materials_file</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">globalsoundlist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Model Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">globalmodellist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Force Player Models a;b;c etc</b></span> <kbd  class="tooltip" data-tooltip="string">forcepmodels</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum game version</b></span> <kbd  class="tooltip" data-tooltip="choices">scversion2</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>524 </b> : 5.24 Patch : Choice_Description_here</li>
<li><b>523 </b> : 5.23 Patch : Choice_Description_here</li>
<li><b>522 </b> : 5.22 Patch : Choice_Description_here</li>
<li><b>521 </b> : 5.21 Patch : Choice_Description_here</li>
<li><b>520 </b> : 5.20 Patch : Choice_Description_here</li>
<li><b>519 </b> : 5.19 Patch : Choice_Description_here</li>
<li><b>518 </b> : 5.18 Patch : Choice_Description_here</li>
<li><b>517 </b> : 5.17 Patch : Choice_Description_here</li>
<li><b>516 </b> : 5.16 Patch : Choice_Description_here</li>
<li><b>515 </b> : 5.15 Patch : Choice_Description_here</li>
<li><b>514 </b> : 5.14 Patch : Choice_Description_here</li>
<li><b>513 </b> : 5.13 Patch : Choice_Description_here</li>
<li><b>512 </b> : 5.12 Patch : Choice_Description_here</li>
<li><b>511 </b> : 5.11 Patch : Choice_Description_here</li>
<li><b>510 </b> : 5.10 Patch : Choice_Description_here</li>
<li><b>509 </b> : 5.09 Patch : Choice_Description_here</li>
<li><b>508 </b> : 5.08 Patch : Choice_Description_here</li>
<li><b>507 </b> : 5.07 Patch : Choice_Description_here</li>
<li><b>506 </b> : 5.06 Patch : Choice_Description_here</li>
<li><b>505 </b> : 5.05 Patch : Choice_Description_here</li>
<li><b>504 </b> : 5.04 Patch : Choice_Description_here</li>
<li><b>503 </b> : 5.03 Patch : Choice_Description_here</li>
<li><b>502 </b> : 5.02 Patch : Choice_Description_here</li>
<li><b>501 </b> : 5.01 Patch : Choice_Description_here</li>
<li><b>500 </b> : 5.0 Milestone : Choice_Description_here</li>
<li><b>480 </b> : 4.8 Update : Choice_Description_here</li>
<li><b>470 </b> : 4.7 Update : Choice_Description_here</li>
<li><b>460 </b> : 4.6 Update : Choice_Description_here</li>
<li><b>450 </b> : 4.5 Update : Choice_Description_here</li>
<li><b>407 </b> : 4.07 Hotfix : Choice_Description_here</li>
<li><b>406 </b> : 4.06 Hotfix : Choice_Description_here</li>
<li><b>405 </b> : 4.05 Hotfix : Choice_Description_here</li>
<li><b>401 </b> : 4.0b1 Milestone : Choice_Description_here</li>
<li><b>400 </b> : 4.0 Internal : Choice_Description_here</li>
<li><b>300 </b> : 3.0 (or earlier) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
