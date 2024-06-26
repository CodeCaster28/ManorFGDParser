---
title: light_shadow
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows mapper to toggle shadows among all toggleable/killable entities that cast shadows. Best effect when using among light_bounce. To use this entity place it anywhere on the map and set it's target to entity that will appear/disappear dynamically in-game. Targeting light_shadow will toggle the shadows. Note that entity need to have 'Opaque' selected in "ZHLT Lightflags" to cast a shadow. Does not support multiple or switchable light_environments.</div>
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
<span style="color:#9fc5e8;"><b>Target solid entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Target solid entity that casted shadows will be toggled.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to toggle shadows on "Target solid entity".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Appearance (no name allowed)</b></span> <kbd  class="tooltip" data-tooltip="choices">style</kbd> :
Not tested for {{ entname }}.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Normal</li>
<li><b>10</b> : Fluorescent flicker</li>
<li><b>2 </b> : Slow, strong pulse</li>
<li><b>11</b> : Slow pulse, no black</li>
<li><b>5 </b> : Gentle pulse</li>
<li><b>1 </b> : Flicker A</li>
<li><b>6 </b> : Flicker B</li>
<li><b>3 </b> : Candle A</li>
<li><b>7 </b> : Candle B</li>
<li><b>8 </b> : Candle C</li>
<li><b>4 </b> : Fast strobe</li>
<li><b>9 </b> : Slow strobe</li>
<li><b>12 </b> : Underwater mutation</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Appearance</b></span> <kbd  class="tooltip" data-tooltip="string">pattern</kbd> :
Not tested for {{ entname }}.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classname in game</b></span> <kbd  class="tooltip" data-tooltip="choices">convertto</kbd> :
Used by compilers. You don't need to set this.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>"light" </b> : light</li>
<li><b>"light_spot" </b> : light_spot</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Initially dark</span> : Shadows starts turned ON at start (should be reverted to light_shadow at start). Make sure this is selected when the brush is visible at start.</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
