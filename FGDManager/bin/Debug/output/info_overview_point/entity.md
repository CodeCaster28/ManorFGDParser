---
title: info_overview_point
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">You can make all visleafs be visible from vis leaf where this entity is created. Also you can make a specified leaf visible from all other visleafs. Just place entity in a place where you want overview point. If reversed, place it at the center of a model/entity enclosed in a hollowed area (that are not always visible despite to player's position in the world) you wish to be visible from within the whole map.</div>
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
<span style="color:#9fc5e8;"><b>Reversed</b></span> <kbd  class="tooltip" data-tooltip="choices">reverse</kbd> :
If set to yes, instead of making this leaf an overview point for all other leafs, make this leaf visible from every place of the map.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No</li>
<li><b>1</b> : Yes</li>
</ul>
</div>
</div>
</div>
</div>
