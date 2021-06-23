---
title: trigger_copyvalue
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
<span style="color:#9fc5e8;"><b>Source entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszSrcValueName</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszDstValueName</kbd> :
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
<li><b>0 </b></span> : Replace (= source) : Choice_Description_here</li>
<li><b>1 </b></span> : Add (= old + source) : Choice_Description_here</li>
<li><b>2 </b></span> : Mul (= old * source) : Choice_Description_here</li>
<li><b>3 </b></span> : Sub (= old - source) : Choice_Description_here</li>
<li><b>4 </b></span> : Div (= old / source) : Choice_Description_here</li>
<li><b>16 </b></span> : Pow (= old ^ source) : Choice_Description_here</li>
<li><b>12 </b></span> : Mod (= old % source) : Choice_Description_here</li>
<li><b>5 </b></span> : AND (= old & source) : Choice_Description_here</li>
<li><b>6 </b></span> : OR (= old | source) : Choice_Description_here</li>
<li><b>13 </b></span> : XOR (= old ^ source) : Choice_Description_here</li>
<li><b>7 </b></span> : NAND (= !(old & source)) : Choice_Description_here</li>
<li><b>8 </b></span> : NOR (= !(old | source)) : Choice_Description_here</li>
<li><b>14 </b></span> : NXOR (= !(old ^ source)) : Choice_Description_here</li>
<li><b>9 </b></span> : Direction to Angles : Choice_Description_here</li>
<li><b>10 </b></span> : Angles to Direction : Choice_Description_here</li>
<li><b>11 </b></span> : Append (String concatenation) : Choice_Description_here</li>
<li><b>17 </b></span> : Sin (= sin(source)) : Choice_Description_here</li>
<li><b>18 </b></span> : Cos (= cos(source)) : Choice_Description_here</li>
<li><b>19 </b></span> : Tan (= tan(source)) : Choice_Description_here</li>
<li><b>23 </b></span> : Cot (= cot(source)) : Choice_Description_here</li>
<li><b>20 </b></span> : Arcsin (= arcsin(source)) : Choice_Description_here</li>
<li><b>21 </b></span> : Arccos (= arccos(source)) : Choice_Description_here</li>
<li><b>22 </b></span> : Arctan (= arctan(source)) : Choice_Description_here</li>
<li><b>24 </b></span> : Arccot (= arccot(source)) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Float-to-string/-int conversion</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iFloatConversion</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0  </b></span> : 6 decimal places (Default) : Choice_Description_here</li>
<li><b>1  </b></span> : 5 d. p., rounded to 5 d. p. : Choice_Description_here</li>
<li><b>4  </b></span> : 4 d. p., rounded to 4 d. p. : Choice_Description_here</li>
<li><b>7  </b></span> : 3 d. p., rounded to 3 d. p. : Choice_Description_here</li>
<li><b>10 </b></span> : 2 d. p., rounded to 2 d. p. : Choice_Description_here</li>
<li><b>13 </b></span> : 1 d. p., rounded to 1 d. p. : Choice_Description_here</li>
<li><b>16 </b></span> : Integer, rounded : Choice_Description_here</li>
<li><b>17 </b></span> : Integer, rounded up : Choice_Description_here</li>
<li><b>18 </b></span> : Integer, rounded down : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigonometric funcs. I/O</b></span> <kbd  class="tooltip" data-tooltip="choices">m_trigonometricBehaviour</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Degrees in (out for arc.) : Choice_Description_here</li>
<li><b>1 </b></span> : Radian measure in (out for arc.) : Choice_Description_here</li>
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Copy-interval (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">dmg</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>1 </b></span> : Don't use X : Choice_Description_here</li>
<li><b>2 </b></span> : Don't use Y : Choice_Description_here</li>
<li><b>4 </b></span> : Don't use Z : Choice_Description_here</li>
<li><b>8 </b></span> : Constant : Choice_Description_here</li>
<li><b>16 </b></span> : Start On : Choice_Description_here</li>
<li><b>32 </b></span> : Invert target value : Choice_Description_here</li>
<li><b>64 </b></span> : Invert source value : Choice_Description_here</li>
<li><b>128 </b></span> : Multiple destinations : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
