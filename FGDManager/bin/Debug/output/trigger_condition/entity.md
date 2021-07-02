---
title: trigger_condition
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
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
This always means an identifier for the entity in question so other entities can trigger or refer to it. Many entities need no name, or behave differently depending on whether they have one or not.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monitored entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monitored key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszValueName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">m_iszSourceName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszSourceKey</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-value (alternative)</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszCheckValue</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Comparator; mon. val. -> comp.-val.</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iCheckType</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : == (Equal) : Choice_Description_here</li>
<li><b>1 </b> : != (Not equal) : Choice_Description_here</li>
<li><b>2 </b> : < (Less) : Choice_Description_here</li>
<li><b>3 </b> : > (Greater) : Choice_Description_here</li>
<li><b>4 </b> : <= (Less or equal) : Choice_Description_here</li>
<li><b>5 </b> : >= (Greater or equal) : Choice_Description_here</li>
<li><b>6 </b> : & (Logical AND) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target for 'true'-case</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target for 'false'-case</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Constant mode trigger behaviour</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iCheckBehaviour</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Fire true/false alternatingly : Choice_Description_here</li>
<li><b>1 </b> : Only wait after false : Choice_Description_here</li>
<li><b>2 </b> : Only wait after true : Choice_Description_here</li>
<li><b>3 </b> : Always fire for both : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Check-interval (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">m_fCheckInterval</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Start Off : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Don't use X (R) : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Don't use Y (G) : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Don't use Z (B) : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>16 </b> : Don't use W (A) : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32 </b> : Cyclic; no toggle : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64 </b> : Keep '!activator' : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>128 </b> : Ignore initial result : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
