---
title: trigger_condition
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A, by default, toggleable entity, which, while activated, will compare any value of any entity's key with either a specified value or the keyvalue of another entity, using a specified comparator and fire its target for the according result- true or false- whenever the result of the condition changes (by default) or at the instant the trigger_condition entity is activated manually. While activated, the trigger_condition checks its condition every 0.1 seconds, by default. Supports [custom keyvalues](../custom_keyvalues).</div>
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
Set name of {{ entname }} so other entities can trigger it to start monitoring keyvalue (or compare once when "Cyclic" flag is checked). With "Cyclic" flag disabled the behaviour is based on trigger use-type: 'On'- turn comparator on, 'Off'- turn comparator off, 'Toggle'- toggle comparator. With "Cyclic" flag enabled only "On" and "Toggle" trigger use-types are accepted to compare once. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Monitored entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the entity of which a keyvalue is to be monitored. The target entity may be removed in the process. Only one entity by this name should exist.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monitored key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszValueName</kbd> :
Name of the key which value is to be compared to the value of the compare-key.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">m_iszSourceName</kbd> :
Name of the entity of which a keyvalue shall serve as a compare-value. Only one entity by this name should exist.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-key</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszSourceKey</kbd> :
Name of the key which value is to be compared to the monitored key.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compare-value (alternative)</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszCheckValue</kbd> :
If you do not want to compare the monitored keyvalue to the keyvalue of another entity, you can directly specify a value here. Leave "Compare-entity" empty in that case.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Comparator; mon. val. -> comp.-val.</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iCheckType</kbd> :
Set the comparison type between monitored keyvalue and the other compare value.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : == (Equal)</li>
<li><b>1 </b> : != (Not equal)</li>
<li><b>2 </b> : < (Less)</li>
<li><b>3 </b> : > (Greater)</li>
<li><b>4 </b> : <= (Less or equal)</li>
<li><b>5 </b> : >= (Greater or equal)</li>
<li><b>6 </b> : & (Logical AND)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target for 'true'-case</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
Target to trigger in case the condition is true. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target for 'false'-case</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Target to trigger in case the condition is false. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Constant mode trigger behaviour</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iCheckBehaviour</kbd> :
If the trigger_condition uses constant/non-cyclic/toggle-mode, this specifies how it will fire its true- and false- target.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Fire true/false alternatingly : Default. Wait for the condition to change in order to trigger a target.</li>
<li><b>1 </b> : Only wait after false : Only wait for true-case after a false-case.</li>
<li><b>2 </b> : Only wait after true : Only wait for false-case after a true-case.</li>
<li><b>3 </b> : Always fire for both : Trigger regardless of the previous result on every interval.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Check-interval (seconds)</b></span> <kbd  class="tooltip" data-tooltip="string">m_fCheckInterval</kbd> :
If the trigger_condition is toggleable/constant, this specifies the delay between check-intervals, in seconds. Set to 0.0 to check every server-frame. Default is 0.1 seconds.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start Off</span> : The trigger_condition starts off and has to be triggered on manually in order to work. This is automatically the case when "Cyclic" flag is selected.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Don't use X (R)</span> : When using vectors/arrays, this will ignore the first array.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Don't use Y (G)</span> : When using vectors/arrays, this will ignore the second array.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Don't use Z (B)</span> : When using vectors/arrays, this will ignore the third array.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : <span style="color:#9fc5e8;">Don't use W (A)</span> : When using vectors/arrays, this will ignore the fourth array.</li>
<li class="imagepadding" markdown="1"><b>32 </b> : <span style="color:#9fc5e8;">Cyclic; no toggle</span> : Changes the trigger_condition's behaviour to a single-fire-behaviour. With this flag set, the entity will fire a target according to its condition's result once, and then idle until triggered again.</li>
<li class="imagepadding" markdown="1"><b>64 </b> : <span style="color:#9fc5e8;">Keep '!activator'</span> : Because of trigger_condition's default behavior, the reference to the original activator is overwritten with the trigger_condition itself, because of an expected delay between activating the trigger_condition and a change in its condition's result; within this delay the original activator could have been removed already and thus cause unwanted behaviour when used. Because of that, you have to explicitly enable this flag for the activator to be forwarded normally. This is only dangerous to use if an entity triggered by trigger_condition will expect the activator to refer to a valid entity.</li>
<li class="imagepadding" markdown="1"><b>128 </b> : <span style="color:#9fc5e8;">Ignore initial result</span> : If this is set and "Cyclic" flag is not selected, every time you activate it, the very first result it produces will be ignored and nothing will be triggered, and it will proceed normal according to the specified trigger-behaviour.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Trigger_condition supports the use of "!activator" and "!caller" in the "Monitored entity"- and "Compare-entity"-fields.</div>
<div class="notices blue" markdown="1">The type of comparison can depend on the types of the monitored keyvalue and comparison keyvalue. E.g. comparing a string "0 0 0" from monitored keyvalue to a vector { 0.0 0.0 0.0 } will cause the vector to be transformed into the string "0.000000 0.000000 0.000000". The string "0 0 0" is not equal to the string "0.000000 0.000000 0.000000". However, comparing a vector { 0.0 0.0 0.0 } from monitored keyvalue to a string "0 0 0" will cause the string to be parsed into another vector { 0.0 0.0 0.0 } which then is equal to the vector in the monitored keyvalue.</div>
<div class="notices blue" markdown="1">Comparing a vector to an integer or float will cause the length of that vector to be compared. (This works either way round) This happens in regards to the vector-dimension-exclusion keyvalues. Exception: If you exclude exactly two of the three vector-dimensions, you will get the extents of the vector in the one non-excluded dimension. That means if that extent is negative, you will also get it as negative.</div>
<div class="notices blue" markdown="1">Comparing vectors with each other will cause their lengths to be compared, unless comparison-type is "Equal" or "Unequal". Should that not be what you want, you'd have to parse the single extents into floats and compare them one by one for the time being.</div>
