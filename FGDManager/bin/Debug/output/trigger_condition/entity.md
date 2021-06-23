---
title: trigger_condition
---

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
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
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
<li><b>0 </b></span> : == (Equal) : Choice_Description_here</li>
<li><b>1 </b></span> : != (Not equal) : Choice_Description_here</li>
<li><b>2 </b></span> : < (Less) : Choice_Description_here</li>
<li><b>3 </b></span> : > (Greater) : Choice_Description_here</li>
<li><b>4 </b></span> : <= (Less or equal) : Choice_Description_here</li>
<li><b>5 </b></span> : >= (Greater or equal) : Choice_Description_here</li>
<li><b>6 </b></span> : & (Logical AND) : Choice_Description_here</li>
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
<li><b>0 </b></span> : Fire true/false alternatingly : Choice_Description_here</li>
<li><b>1 </b></span> : Only wait after false : Choice_Description_here</li>
<li><b>2 </b></span> : Only wait after true : Choice_Description_here</li>
<li><b>3 </b></span> : Always fire for both : Choice_Description_here</li>
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
<li><b>1 </b></span> : Start Off : Choice_Description_here</li>
<li><b>2 </b></span> : Don't use X (R) : Choice_Description_here</li>
<li><b>4 </b></span> : Don't use Y (G) : Choice_Description_here</li>
<li><b>8 </b></span> : Don't use Z (B) : Choice_Description_here</li>
<li><b>16 </b></span> : Don't use W (A) : Choice_Description_here</li>
<li><b>32 </b></span> : Cyclic; no toggle : Choice_Description_here</li>
<li><b>64 </b></span> : Keep '!activator' : Choice_Description_here</li>
<li><b>128 </b></span> : Ignore initial result : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
