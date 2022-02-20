---
title: trigger_numericdisplay
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity_Description_here</div>
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
<span style="color:#9fc5e8;"><b>Entity to track</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Key to read</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Base digit name</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Update delay</b></span> <kbd  class="tooltip" data-tooltip="string">frags</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start On</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Cyclic</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Ignore leading zeroes</span> : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Zero as leading</span> : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
