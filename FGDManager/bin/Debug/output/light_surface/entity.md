---
title: light_surface
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
<span style="color:#9fc5e8;"><b>Texture name</b></span> <kbd  class="tooltip" data-tooltip="string">_tex</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter max distance</b></span> <kbd  class="tooltip" data-tooltip="string">_frange</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter max dist to plane</b></span> <kbd  class="tooltip" data-tooltip="string">_fdist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter entity classname</b></span> <kbd  class="tooltip" data-tooltip="string">_fclass</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Filter entity name</b></span> <kbd  class="tooltip" data-tooltip="string">_fname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture brightness</b></span> <kbd  class="tooltip" data-tooltip="color255">_light</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Color(replace texture color)</b></span> <kbd  class="tooltip" data-tooltip="color255">_texcolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Inner(bright) angle(90default)</b></span> <kbd  class="tooltip" data-tooltip="string">_cone</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Outer(fading) angle(90default)</b></span> <kbd  class="tooltip" data-tooltip="string">_cone2</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Adjust emit scale(1.0default)</b></span> <kbd  class="tooltip" data-tooltip="string">_scale</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Grid size of sampling</b></span> <kbd  class="tooltip" data-tooltip="string">_chop</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Dark gap in front of texlight</b></span> <kbd  class="tooltip" data-tooltip="choices">_texlightgap</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>""</b> : Default (no gap) : Choice_Description_here</li>
<li><b>"0.0"</b> : 0.0 - no gap : Choice_Description_here</li>
<li><b>"3.0"</b> : 3.0 - small gap : Choice_Description_here</li>
<li><b>"12.0"</b> : 12.0 - large gap : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fast</b></span> <kbd  class="tooltip" data-tooltip="choices">_fast</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>""</b> : Auto : Choice_Description_here</li>
<li><b>1</b> : Yes : Choice_Description_here</li>
<li><b>2</b> : No : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classname in game</b></span> <kbd  class="tooltip" data-tooltip="choices">convertto</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"light" </b> : light : Choice_Description_here</li>
<li><b>"light_spot" </b> : light_spot : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Appearance (no name allowed)</b></span> <kbd  class="tooltip" data-tooltip="choices">style</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"" </b> : Normal : Choice_Description_here</li>
<li><b>10</b> : Fluorescent flicker : Choice_Description_here</li>
<li><b>2 </b> : Slow, strong pulse : Choice_Description_here</li>
<li><b>11</b> : Slow pulse, no black : Choice_Description_here</li>
<li><b>5 </b> : Gentle pulse : Choice_Description_here</li>
<li><b>1 </b> : Flicker A : Choice_Description_here</li>
<li><b>6 </b> : Flicker B : Choice_Description_here</li>
<li><b>3 </b> : Candle A : Choice_Description_here</li>
<li><b>7 </b> : Candle B : Choice_Description_here</li>
<li><b>8 </b> : Candle C : Choice_Description_here</li>
<li><b>4 </b> : Fast strobe : Choice_Description_here</li>
<li><b>9 </b> : Slow strobe : Choice_Description_here</li>
<li><b>12 </b> : Underwater mutation : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Appearance</b></span> <kbd  class="tooltip" data-tooltip="string">pattern</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Initially dark : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
