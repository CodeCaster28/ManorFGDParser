---
title: trigger_random_unique
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Obsolete, use [trigger_random](../trigger_random) with "Unique" flag. Trigger which will pick one of its targets, which has not been triggered by it before, randomly and fire it when triggered.</div>
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
Set name of {{ entname }} so other entities can trigger it to pick random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target Count</b></span> <kbd  class="tooltip" data-tooltip="integer">target_count</kbd> :
Amount of random targets you have specified below. E.g. if you used "Target 1'" "Target 2" and "Target 3" then set it to 3.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 1</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target1</kbd> :
Target no. 1 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 2</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target2</kbd> :
Target no. 2 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 3</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target3</kbd> :
Target no. 3 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 4</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target4</kbd> :
Target no. 4 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 5</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target5</kbd> :
Target no. 5 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 6</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target6</kbd> :
Target no. 6 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 7</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target7</kbd> :
Target no. 7 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 8</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target8</kbd> :
Target no. 8 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 9</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target9</kbd> :
Target no. 9 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 10</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target10</kbd> :
Target no. 10 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 11</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target11</kbd> :
Target no. 11 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 12</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target12</kbd> :
Target no. 12 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 13</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target13</kbd> :
Target no. 13 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 14</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target14</kbd> :
Target no. 14 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 15</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target15</kbd> :
Target no. 15 that can be triggered when picking random target.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target 16</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target16</kbd> :
Target no. 16 that can be triggered when picking random target.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Re-usable</span> : If set, the trigger_random_unique can be used again after having fired its targets, handling all of them as if not triggered before again.</li>
</ul>
</div>
