---
title: func_detail
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Func_detail is useful brush entity, similar to [func_wall](../func_wall) except it doesn't support Render Modes. Detailed brushes like tables, signs, computers, pipes, cars e.t.c. should be turned into func_detail instead of func_wall. Brushes tied into func_detail are Detail Brushes. Detail brushes don't block vis, nor slowing vis processing down. It won't chop other brushes- it helps to avoid many compiling warnings. The one of most important feature of func_detail is that detail brushes won't count into models limit (just like func_walls) which is very easy to exceed in Sven Co-op. You can customize detail level (description below), and collision of func_brush (it's better than func_illusionary because of better lightning receiving and in-game decals support). Using this brush in replace of func_wall is highly recommended. Every keyvalue are optional, it's recommended to leave them as they are (with an except of "Passable" key) for beginner mappers.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Detail level</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_detaillevel</kbd> :
The brush's detail level. Each level will be chopped by brushes of equal or lower detail level, and always be chopped by world brushes, and only chop brushes of equal or greater level. Use higher amount for smaller details. Try to avoid too many detail levels in the map (it increases .bsp file size). Example: func_detail table made of brushes have detail level of 1. On the table there are another func_details that represents computer screen, keyboard and mug. Those should have detail level value of 2 so they won't chop the faces of the table.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Lower its level to chop others</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_chopdown</kbd> :
If you set this value to no less than a detail level, this brush can chop world brushes (if 'detail level' minus 'lower it's level to chop others' is equal to 0) and brushes from lower detail levels.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Raise its level to get chopped</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_chopup</kbd> :
Specify to chop brushes from higher detail levels than this func_detail.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Priority when faces overlap</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_coplanarpriority</kbd> :
Helps prevent z-fighting between two or more overlapping detail brush faces by giving each detail its own priority. Note that both of those brushes must have the same detail level to make use of this priority (use detail level 0 to work with world brushes).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Detail level of clip hulls</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_clipnodedetaillevel</kbd> :
Should always be '0' or '1' unless you are grappling with cliphull errors.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Specify whenever func_detail can be walked through ('Yes') or have full collision ('No'). Note that bullets will still hit this entity when it's passable.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default</li>
<li><b>1 </b> : Always non-solid</li>
</ul>
</div>
</div>
</div>
<div class="notices blue" markdown="1">Detail layers uses an advanced method to decide leafnode content, so they won't cause "Ambiguous leafnode contents" compile warning.</div>
<div class="notices blue" markdown="1">Despite becoming an ordinary world brush during compilation, it cannot be used to seal the map. It is kept separate from ordinary world brushes during processing of Hull 0 and as such cannot be used to prevent leaks. Only ordinary world brushes should be used to close up a map.</div>
<div class="notices blue" markdown="1">Even if Passable is set to Yes (zhlt_noclip 1) it will still be affected by decals such as sprays and bullet holes.</div>
