---
title: func_group
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">A func_group is made into solid world brushes upon map compilation. It only exists to be able to group objects in old versions of the Hammer editor, when it was still called Worldcraft. Still, you can use func_group for Vluzacn's compile operations like editing cliphull but it's highly recommended to use [func_detail](../func_detail) for this.</div>
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Priority when faces overlap</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_coplanarpriority</kbd> :
Prevents z-fighting. When two brushes have overlapping faces, this value controls which of those brushes faces have rendering priority.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Enable or disable collision of entity.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Keep default collision.</li>
<li><b>1 </b> : Always non-solid : This makes entity non-solid- all collision info from this entity will be ignored.</li>
</ul>
</div>
</div>
</div>
</div>
