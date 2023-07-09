---
title: trigger_copyvalue
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Provides options for performing operations on an entity's keyvalue in relation to another keyvalue of another entity. This is a beefier version of [trigger_changevalue](../trigger_changevalue). Supports [custom keyvalues](../custom_keyvalues).</div>
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
Set name of {{ entname }} so other entities can trigger it to apply value change (or enable constant copier when "Constant" flag is checked). With "Constant" flag enabled the behaviour is based on trigger use-type: 'On'- turn constant copier on, 'Off'- turn constant copier off, 'Toggle'- toggle constant copier. With "Constant" flag disabled all use-types are accepted to copy once. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">netname</kbd> :
Name of an entity to provide a source keyvalue for the operation.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszSrcValueName</kbd> :
Name of the source entity's keyvalue - the keyvalue which shall play the later part in the operation.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the one entity to have a keyvalue altered.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszDstValueName</kbd> :
Name of the keyvalue to be written on the destination entity.
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
<li><b>9 </b> : Direction to Angles</li>
<li><b>10 </b> : Angles to Direction</li>
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
<span style="color:#9fc5e8;"><b>Float-to-string/-int conversion</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iFloatConversion</kbd> :
Specify how floats should be written to strings or converted into integers.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0  </b> : 6 decimal places (Default)</li>
<li><b>1  </b> : 5 d. p., rounded to 5 d. p.</li>
<li><b>4  </b> : 4 d. p., rounded to 4 d. p.</li>
<li><b>7  </b> : 3 d. p., rounded to 3 d. p.</li>
<li><b>10 </b> : 2 d. p., rounded to 2 d. p.</li>
<li><b>13 </b> : 1 d. p., rounded to 1 d. p.</li>
<li><b>16 </b> : Integer, rounded</li>
<li><b>17 </b> : Integer, rounded up</li>
<li><b>18 </b> : Integer, rounded down</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigonometric funcs. I/O</b></span> <kbd  class="tooltip" data-tooltip="choices">m_trigonometricBehaviour</kbd> :
When using trigonometric or arc-functions, use this to specify what measure you are using as input, or which measure you expect as output (when using arc-functions).
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
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
When the destination keyvalue is a string and you are setting it or appending to it, this specifies how many spaces to append to the end of the new string. This was implemented because Valve Hammer Editor cuts trailing spaces in keyvalues.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after action</b></span> <kbd  class="tooltip" data-tooltip="target_destination">message</kbd> :
Entity to trigger after the operation. This is very useful when you require a logic chain of operations to achieve a specific effect, e.g. assemble a message for a game_text entity to print. This will also be triggered for every interval in constant mode, when set. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Copy-interval (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">dmg</kbd> :
When using constant mode, use this to specify the delay between intervals where the trigger_copyvalue performs its operation, in seconds. This defaults to 0.0 seconds, meaning once every server frame.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Don't use X</span> : When using vectors/arrays, this will ignore the first array. E.g., when setting render-color, specifying this flag would ignore the 'Red'-value.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Don't use Y</span> : When using vectors/arrays, this will ignore the second array. E.g., when setting angles, specifying this flag would ignore the 'Yaw'-value.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Don't use Z</span> : When using vectors/arrays, this will ignore the third array. E.g., when setting velocity, specifying this flag would ignore the vertical velocity.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Constant</span> : Makes trigger_copyvalue toggleable, and perform the specified operation on the destination keyvalue on every update interval (See "Copy-interval (seconds)" below) while it is activated.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : <span style="color:#9fc5e8;">Start On</span> : Does not work. Supposed to cause this entity to be enabled from level load onward, this only makes sense in combination with "Constant". Use delayed trigger_auto instead.</li>
<li class="imagepadding" markdown="1"><b>32 </b> : <span style="color:#9fc5e8;">Invert target value</span> : The destination keyvalue will be multiplied with minus one before proceeding.</li>
<li class="imagepadding" markdown="1"><b>64 </b> : <span style="color:#9fc5e8;">Invert source value</span> : The source-value will be multiplied with minus one before proceeding; this change is only temporary and this keyvalue is rather useless, as you can always prepend a minus-sign to the static source-value.</li>
<li class="imagepadding" markdown="1"><b>128 </b> : <span style="color:#9fc5e8;">Multiple destinations</span> : Causes trigger_copyvalue to affect all destination entities instead of only the first one found.</li>
</ul>
</div>
<div class="notices blue" markdown="1">When source keyvalue type is a vector and destination keyvalue type is a float or integer, the length of the vector will be used for operation. Any vector-extents excluded with spawnflags will not contribute to the length. If only one vector-extent is used, it will be transmitted directly, meaning the original value, not the length/absolute value of it.</div>
<div class="notices blue" markdown="1">The spawnflags to exclude vector-dimensions affect source and destination keyvalue. When you set the value of a float or integer to a vector, only those vector-extents not excluded will be set to the value of the float/integer.</div>
<div class="notices blue" markdown="1">"Direction to Angles" and "Angles to Direction" are useful if you want to move something in the direction it's facing or force players to look in the direction of a train they are on. It's also very useful when you want to glue one entity to another and have it rotate around it. Direction vector is outputted normalized, meaning with a total length of exactly 1 unit.</div>
<div class="notices blue" markdown="1">You cannot copy the model from one brush entity to another brush entity, because additional actions are required for that to work. Use [trigger_changemodel](../trigger_changemodel) for that instead.</div>
<div class="notices red" markdown="1">Writing to strings currently does continuously eat away at server memory because of how Valve did string-"management" in the Goldsource-engine; that means strings you have set remain in server memory unless it restarts, eventually causing memory to be full and the server to shut down. While this is rather obsolete (strings don't need much memory), try not to write them THAT often, e.g. not every server frame when in constant mode, but only every 0.3 seconds, at least when you assemble larger strings.</div>
<div class="notices red" markdown="1">Constant mode with "Start On" doesn't work. Use delayed [trigger_auto](../trigger_auto) instead to activate this entity on map start.</div>
