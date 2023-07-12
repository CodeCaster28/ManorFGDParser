---
title: trigger_setorigin
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Copies the position and orientation of one entity to another, providing several additional options for angles and relative rotation. Entities moved with this won't shove away any objects blocking them, but pass through them, blocking said objects instead. (This entity does set the origin, it does not perform movement of an entity) This entity has several inconsistencies in its design. Most of the time you are better off assembling the operation you require using a few [trigger_copyvalue](../trigger_copyvalue).</div>
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
Set name of {{ entname }} so other entities can trigger it to set origin (or start constant origin copier with "Constant" flag checked). With "Constant" flag enabled the behaviour is based on trigger use-type: 'On','Toggle'- start constant origin set, 'Off'- stop constant origin set. With "Constant" flag disabled only 'On' and 'Toggle' use-types are accepted which sets origin once. Can be kill-targeted and constantly positioned entities are dropped.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of the entity to attach to or move to the copy-pointer entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Copy Pointer</b></span> <kbd  class="tooltip" data-tooltip="string">copypointer</kbd> :
The entity to copy coordinates/angles from.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Position Offset (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">offset</kbd> :
Offset the target entity by this vector when "Offset Difference" is set.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Angle Offset (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angleoffset</kbd> :
Offsets the target entity's angles by this value when trigger_setorigin is first activated. Will only touch angles set to be copied as per spawnflags.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invert X Angle</b></span> <kbd  class="tooltip" data-tooltip="choices">invert_x</kbd> :
Use inverted pitch for the target entity's orientation.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invert Y Angle</b></span> <kbd  class="tooltip" data-tooltip="choices">invert_y</kbd> :
Use inverted yaw for the target entity's orientation.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Invert Z Angle</b></span> <kbd  class="tooltip" data-tooltip="choices">invert_z</kbd> :
Use inverted roll for the target entity's orientation.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">Constant</span> : Always update the target's position and orientation.</li>
<li class="imagepadding" markdown="1"><b>4</b> : <span style="color:#9fc5e8;">Set Once</span> : Only update the target once and remove the trigger_setorigin from the game afterwards.</li>
<li class="imagepadding" markdown="1"><b>8</b> : <span style="color:#9fc5e8;">Lock Offsets</span> : Use the vector between the target and the copypointer plus the "Offset"-keyvalue as the offset vector.</li>
<li class="imagepadding" markdown="1"><b>16</b> : <span style="color:#9fc5e8;">Copy X Angle</span> : Copy the X angle of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>32</b> : <span style="color:#9fc5e8;">Copy Y Angle</span> : Copy the Y angle of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>64</b> : <span style="color:#9fc5e8;">Copy Z Angle</span> : Copy the Z angle of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>128</b> : <span style="color:#9fc5e8;">Copy X Axis</span> : Copy the X axis of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>256</b> : <span style="color:#9fc5e8;">Copy Y Axis</span> : Copy the Y axis of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>512</b> : <span style="color:#9fc5e8;">Copy Z Axis</span> : Copy the Z axis of the copypointer.</li>
<li class="imagepadding" markdown="1"><b>1024</b> : <span style="color:#9fc5e8;">Skip Initial Set</span> : If set, the target entity will not be moved to the copypointer's origin before doing the offset difference calculation (set this unless you want the target entity stuck to the center of the copypointer).</li>
</ul>
</div>
<div class="notices blue" markdown="1">If you are copying the origin/angles from or to a brush based entity, then that entity must have an origin brush attached to it. The center of that origin brush will be used as the origin of the entire brush entity.</div>
<div class="notices red" markdown="1">When using "Constant" flag and the entity does not have a targetname, the entity will not automatically turn itself on. Use a [trigger_auto](../trigger_auto).</div>
