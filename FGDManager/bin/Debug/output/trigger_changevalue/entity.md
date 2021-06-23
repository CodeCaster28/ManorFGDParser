---
title: trigger_changevalue
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
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszValueName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source value</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszNewValue</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iszValueType</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Replace (= source) : Choice_Description_here</li>
<li><b>1 </b> : Add (= old + source) : Choice_Description_here</li>
<li><b>2 </b> : Mul (= old * source) : Choice_Description_here</li>
<li><b>3 </b> : Sub (= old - source) : Choice_Description_here</li>
<li><b>4 </b> : Div (= old / source) : Choice_Description_here</li>
<li><b>16 </b> : Pow (= old ^ source) : Choice_Description_here</li>
<li><b>12 </b> : Mod (= old % source) : Choice_Description_here</li>
<li><b>5 </b> : AND (= old & source) : Choice_Description_here</li>
<li><b>6 </b> : OR (= old | source) : Choice_Description_here</li>
<li><b>13 </b> : XOR (= old ^ source) : Choice_Description_here</li>
<li><b>7 </b> : NAND (= !(old & source)) : Choice_Description_here</li>
<li><b>8 </b> : NOR (= !(old | source)) : Choice_Description_here</li>
<li><b>14 </b> : NXOR (= !(old ^ source)) : Choice_Description_here</li>
<li><b>11 </b> : Append (String concatenation) : Choice_Description_here</li>
<li><b>17 </b> : Sin (= sin(source)) : Choice_Description_here</li>
<li><b>18 </b> : Cos (= cos(source)) : Choice_Description_here</li>
<li><b>19 </b> : Tan (= tan(source)) : Choice_Description_here</li>
<li><b>23 </b> : Cot (= cot(source)) : Choice_Description_here</li>
<li><b>20 </b> : Arcsin (= arcsin(source)) : Choice_Description_here</li>
<li><b>21 </b> : Arccos (= arccos(source)) : Choice_Description_here</li>
<li><b>22 </b> : Arctan (= arctan(source)) : Choice_Description_here</li>
<li><b>24 </b> : Arccot (= arccot(source)) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigonometric funcs. I/O</b></span> <kbd  class="tooltip" data-tooltip="choices">m_trigonometricBehaviour</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Degrees in (out for arc.) : Choice_Description_here</li>
<li><b>1 </b> : Radian measure in (out for arc.) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Append spaces (for strings)</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iAppendSpaces</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after action</b></span> <kbd  class="tooltip" data-tooltip="target_destination">message</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Don't use X : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Don't use Y : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Don't use Z : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32 </b> : Invert target value : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64 </b> : Invert source value : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
