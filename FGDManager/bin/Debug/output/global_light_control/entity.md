---
title: global_light_control
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows mapper to change appearance of all unnamed lights without modified appearance keyvalue. Additionally toggles on and off all light specified in a target field, but only those without modified appearance. Usefulness of this entity is questionable.</div>
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Name of light entity or entities to turn on or off depending on received trigger type: 'Off'- turn light off, 'On'- turn light on, 'Toggle'- toggle light.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to do both: toggle lights specified in "Target'" field AND apply custom appearance to all lights on map with custom appearance set to 'Normal'. Every trigger use-type works uniformly. Signal type is interpreted by lights specified in "Target". Can be multiple triggered for "Target" lights but globally applied light styles will be applied once and cannot be reverted (you need another {{ entname }} with normal style to reset this). Can be kill-targeted but effects done by this entity are not reverted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Appearance</b></span> <kbd  class="tooltip" data-tooltip="string">pattern</kbd> :
Allows you to set up a custom appearance of all unnamed lights on the map with Normal appearance. To do this, you will have to enter 1 to 64 chars from the alphabet ('a' to 'z'), whereas 'a' stands for being dark and 'z' for very bright. Normal lights' appearances uses 'm'. The program [Custom Lightstyle Generator](http://goldsource.gamebanana.com/tools/5590) by Craig "CRAZG" McLaren might help you here. Whatever sequence you enter is stepped through at about 8 Hertz. This will only work when a targetname is set and you manually delete the 'style'-keyvalue from your light under disabled 'Smart edit'-mode right before closing the 'Properties'-window. Note that there can be at most 4 different light styles affecting a face in your map. Otherwise, light styles will be discarded from it, causing unrealistic lighting in extreme cases.
</div>
</div>
<div class="notices blue" markdown="1">Every light with "Custom Appearance" set to other than 'Normal' will be ignored (unless they are named, which makes custom appearance doesn't work").</div>
