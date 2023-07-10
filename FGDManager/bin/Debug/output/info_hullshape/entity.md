---
title: info_hullshape
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows to modify player behavior when standing on spiked ramps by replacing the default cuboid shape of the player when generating collision hulls for certain brushes. You can use brush shape of this info_hullshape as player hull. This is used mostly for "surf" maps to prevent player standing on top of curved brushes. You can set this shape globally or use it only on certain brushes. For global hull shape use "Set as default shape" keyvalue. To apply hull shapes into desired brushes do the following: firstly, there have to be two 'info_hullshape' entities, one with the shape of a standing player and the other with the shape of a crouching player. Secondly, the ramp should be tied to a brush entity or func_detail or func_group, and then you set the 'zhlt_hull1' and 'zhlt_hull3' keys in that entity to specify the player's shape for the entity's standing hull and crouching hull. Note that the crouching player must not be bigger than the standing player, otherwise the player will get stuck when he presses the crouch key. If the shape is too complex, the brushes that use this shape will consume much more clipnodes than normal brushes.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Name of this info_hullshape. This name need to be specified in [func_detail](../func_detail) or [func_group](../func_group).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Set as default shape</b></span> <kbd  class="tooltip" data-tooltip="choices">defaulthulls</kbd> :
If set, this brush will replace player hull shape globally.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No : No</li>
<li><b>2</b> : Hull 1 : Set this brush as a player standing player hull (hull 1).</li>
<li><b>4</b> : Hull 2 : Set this brush as big monster's hull (hull 2) but ask yourself- do you really need to change this?.</li>
<li><b>8</b> : Hull 3 : Set this brush as a player crouching hull shape (hull 3).</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable</b></span> <kbd  class="tooltip" data-tooltip="choices">disabled</kbd> :
You can temporarily disable this entity.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
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
