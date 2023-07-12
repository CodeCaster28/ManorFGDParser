---
title: trigger_changevalue
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Trigger_changevalue can perform arithmetic and logic operations on base-keyvalues of entities, as well as replace their private keyvalues. See [trigger_copyvalue](../trigger_copyvalue) for a variant of this with more options. Supports [custom keyvalues](../custom_keyvalues).</div>
</div>
</div>
<div>
<table class="titletable">
<tbody>
<tr>
<td markdown="1">###Keyvalues</td>
<td class="titletablecheck" id="checkboxandlabel"><input type="checkbox" id="displaycommon"><label for="displaycommon"> Display Common Keyvalues</label></input></td>
</tr>
</tbody>
</table>
<hr>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to apply value change. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Destination entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the entity which keyvalue is to change. This can refer to more than one.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszValueName</kbd> :
Name of the key which's value is to be changed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source value</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszNewValue</kbd> :
Value to be applied to the destination keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Action</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iszValueType</kbd> :
This specifies how destination keyvalue and static source-value correlate. What exactly happens also depends on the types of the two.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Replace (= source) : Replace "Destination Key" value with "Source value".</li>
<li><b>1 </b> : Add (= old + source) : Add "Source value" to "Destination Key" value.</li>
<li><b>2 </b> : Mul (= old * source) : Multiply "Destination Key" value by "Source value".</li>
<li><b>3 </b> : Sub (= old - source) : Subtract "Source value" from "Destination Key" value.</li>
<li><b>4 </b> : Div (= old / source) : Divide "Destination Key" value by "Source value".</li>
<li><b>16 </b> : Pow (= old ^ source) : "Source value" to the power of "Destination Key" value. To keep things simple, zero to the power of zero magically equals one and taking a negative value to the power of a non-integer will cause the base to be treated as positive.</li>
<li><b>12 </b> : Mod (= old % source) : Short for "Modulo", this calculates the rest of a division. For example, 63 % 13 equals 11, because 63 - 13 = 50, 50 - 13 = 37, 37 - 13 = 24 and 24 - 13 = 11. Subtracting a fifth time would deliver a negative result and is henceforth omitted. The actual computation of this value uses a smarter, fast method; this is just for presentiveness. Usage example: You have a value in seconds, e.g. 285, and want to know how many minutes and seconds that are, so you divide by 60 and get 4.75. Omitting the 0.75 you're left with 4. For the remaining seconds, you'd calculate 285 % 60 = 45, which is the same as 60 * 0.75. Then you'd know that 285 seconds equals 4 minutes plus 45 seconds. Real numbers and negative values are supported.</li>
<li><b>5 </b> : AND (= old & source) : Bitwise operation "Destination Key" AND "Source value". The output of bitwise AND is 1 if the corresponding bits of two operands is 1. Result is saved in "Destination Key" value.</li>
<li><b>6 </b> : OR (= old | source) : Bitwise operation "Destination Key" OR "Source value". The output of bitwise OR is 1 if at least one corresponding bit of two operands is 1. Result is saved in "Destination Key" value.</li>
<li><b>13 </b> : XOR (= old ^ source) : Bitwise operation "Destination Key" XOR "Source value". The output of bitwise XOR is 1 if corresponding bits of two operands are opposite. Result is saved in "Destination Key" value.</li>
<li><b>7 </b> : NAND (= !(old & source)) : Bitwise operation "Destination Key" NAND "Source value". The output of bitwise NAND is 1 if at least one corresponding bit of two operands is 0. Result is saved in "Destination Key" value.</li>
<li><b>8 </b> : NOR (= !(old | source)) : Bitwise operation "Destination Key" NOR "Source value". The output of bitwise NOR is 1 if the corresponding bits of two operands is 0. Result is saved in "Destination Key" value.</li>
<li><b>14 </b> : NXOR (= !(old ^ source)) : Bitwise operation "Destination Key" NXOR "Source value". The output of bitwise NXOR is 1 if the corresponding bits of two operands are the same. Result is saved in "Destination Key" value.</li>
<li><b>11 </b> : Append (String concatenation) : Appends your source value to the destination keyvalue. The later must be a string, otherwise this cannot work.</li>
<li><b>17 </b> : Sin (= sin(source))</li>
<li><b>18 </b> : Cos (= cos(source))</li>
<li><b>19 </b> : Tan (= tan(source))</li>
<li><b>23 </b> : Cot (= cot(source))</li>
<li><b>20 </b> : Arcsin (= arcsin(source))</li>
<li><b>21 </b> : Arccos (= arccos(source))</li>
<li><b>22 </b> : Arctan (= arctan(source))</li>
<li><b>24 </b> : Arccot (= arccot(source))</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigonometric funcs. I/O</b></span> <kbd  class="tooltip" data-tooltip="choices">m_trigonometricBehaviour</kbd> :
When using trigonometric or arc-functions as per the "Operation"-keyvalue, this is used to determine what your input/desired output measure is. You'll usually want to stick to degrees.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Degrees in (out for arc.)</li>
<li><b>1 </b> : Radian measure in (out for arc.)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Append spaces (for strings)</b></span> <kbd  class="tooltip" data-tooltip="integer">m_iAppendSpaces</kbd> :
When the destination keyvalue is a string, this specifies how many spaces to append after the operations. You'll usually want to use this with either the "Replace"- or "Append"-operation. This was implemented because Valve Hammer Editor omits any trailing spaces in keyvalues (but not leading ones).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after action</b></span> <kbd  class="tooltip" data-tooltip="target_destination">message</kbd> :
Entity to trigger after the trigger_changevalue has set the new keyvalue, by targetname as usual. This is very useful when you need a chain of operations to happen in a specific order and without any delay in between. Trigger use-type is 'Toggle'.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Don't use X</span> : When using vectors/arrays, this will ignore the first array. E.g., when setting render-color, specifying this flag would ignore the 'Red'-value.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Don't use Y</span> : When using vectors/arrays, this will ignore the second array. E.g., when setting angles, specifying this flag would ignore the 'Yaw'-value.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Don't use Z</span> : When using vectors/arrays, this will ignore the third array. E.g., when setting velocity, specifying this flag would ignore the vertical velocity.</li>
<li class="imagepadding" markdown="1"><b>32 </b> : <span style="color:#9fc5e8;">Invert target value</span> : The destination keyvalue will be multiplied with minus one before proceeding.</li>
<li class="imagepadding" markdown="1"><b>64 </b> : <span style="color:#9fc5e8;">Invert source value</span> : The source-value will be multiplied with minus one before proceeding; this change is only temporary and this keyvalue is rather useless, as you can always prepend a minus-sign to the static source-value.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Trigger_changevalue supports the use of "!activator" and "!caller" in the "Destination Entity"-field.</div>
<div class="notices blue" markdown="1">Trying to write a vector to a float or integer will cause the vector's length to be written. This is in respect to any ignored dimensions as per spawnflags.</div>
