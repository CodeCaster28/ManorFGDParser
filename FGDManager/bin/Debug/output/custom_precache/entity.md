---
title: custom_precache
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows you to set 9 custom models, 9 custom sounds and 9 custom skies to be precached. Note that model and sound replacements done through model and/or sound replacement file are already precached automatically. In case 9 of either sort do not suffice for your case, create another custom_precache entity. Model path starts in Sven Co-op's directory. You should put your models into the 'models'-folder. Sound path starts in the 'sound'-folder. Creating subfolders by your map's name is advised. As for skies, it allows to additional envmaps in cause you use trigger_changevalue or trigger_copyvalue towards trigger_changesky (as default target sky in trigger_changesky is precached automatically)</div>
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
<span style="color:#9fc5e8;"><b>Model 1</b></span> <kbd  class="tooltip" data-tooltip="studio">model_1</kbd> :
Model #1 to precache. Example path: models/myMap/myModel.mdl.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 2</b></span> <kbd  class="tooltip" data-tooltip="studio">model_2</kbd> :
Model #2 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 3</b></span> <kbd  class="tooltip" data-tooltip="studio">model_3</kbd> :
Model #3 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 4</b></span> <kbd  class="tooltip" data-tooltip="studio">model_4</kbd> :
Model #4 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 5</b></span> <kbd  class="tooltip" data-tooltip="studio">model_5</kbd> :
Model #5 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 6</b></span> <kbd  class="tooltip" data-tooltip="studio">model_6</kbd> :
Model #6 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 7</b></span> <kbd  class="tooltip" data-tooltip="studio">model_7</kbd> :
Model #7 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 8</b></span> <kbd  class="tooltip" data-tooltip="studio">model_8</kbd> :
Model #8 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Model 9</b></span> <kbd  class="tooltip" data-tooltip="studio">model_9</kbd> :
Model #9 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 1</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_1</kbd> :
Sound #1 to precache. Example path (starts at /sounds folder): myMap/mySound.ogg.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 2</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_2</kbd> :
Sound #2 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 3</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_3</kbd> :
Sound #3 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 4</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_4</kbd> :
Sound #4 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 5</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_5</kbd> :
Sound #5 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 6</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_6</kbd> :
Sound #6 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 7</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_7</kbd> :
Sound #7 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 8</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_8</kbd> :
Sound #8 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound 9</b></span> <kbd  class="tooltip" data-tooltip="sound">sound_9</kbd> :
Sound #9 to precache.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 1</b></span> <kbd  class="tooltip" data-tooltip="string">sky_1</kbd> :
Sky #1. Not needed when using trigger_changesky.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 2</b></span> <kbd  class="tooltip" data-tooltip="string">sky_2</kbd> :
Sky #2.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 3</b></span> <kbd  class="tooltip" data-tooltip="string">sky_3</kbd> :
Sky #3
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 4</b></span> <kbd  class="tooltip" data-tooltip="string">sky_4</kbd> :
Sky #4
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 5</b></span> <kbd  class="tooltip" data-tooltip="string">sky_5</kbd> :
Sky #5
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 6</b></span> <kbd  class="tooltip" data-tooltip="string">sky_6</kbd> :
Sky #6
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 7</b></span> <kbd  class="tooltip" data-tooltip="string">sky_7</kbd> :
Sky #7
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 8</b></span> <kbd  class="tooltip" data-tooltip="string">sky_8</kbd> :
Sky #8
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sky map 9</b></span> <kbd  class="tooltip" data-tooltip="string">sky_9</kbd> :
Sky #9
</div>
</div>
