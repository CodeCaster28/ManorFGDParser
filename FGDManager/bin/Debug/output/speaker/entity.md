---
title: speaker
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
<span style="color:#9fc5e8;"><b>Announcement Presets</b></span> <kbd  class="tooltip" data-tooltip="choices">preset</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None : Choice_Description_here</li>
<li><b>1</b> : C1A0 Announcer : Choice_Description_here</li>
<li><b>2</b> : C1A1 Announcer : Choice_Description_here</li>
<li><b>3</b> : C1A2 Announcer : Choice_Description_here</li>
<li><b>4</b> : C1A3 Announcer : Choice_Description_here</li>
<li><b>5</b> : C1A4 Announcer : Choice_Description_here</li>
<li><b>6</b> : C2A1 Announcer : Choice_Description_here</li>
<li><b>7</b> : C2A2 Announcer : Choice_Description_here</li>
<li><b>9</b> : C2A4 Announcer : Choice_Description_here</li>
<li><b>11</b> : C3A1 Announcer : Choice_Description_here</li>
<li><b>12</b> : C3A2 Announcer : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sentence Group Name</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Volume (10 = loudest)</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Start Silent : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
