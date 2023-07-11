---
title: trigger_save
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Trigger_save allows to save an entity's keyvalue to external map-data stored in mapname.save in the "maps"-folder, which is stored on the server running the map. Its counterpart is [trigger_load](../trigger_load). Supports [custom keyvalues](../custom_keyvalues).</div>
</div>
</div>
###Keyvalues
<hr>
<div class="accordion entityentry">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<span style="color:#cae4fc;"><b>OnDestroy Function</b></span>
<i class="icon icon-arrow-right mr-1"></i>
</label>
<div class="accordion-body entgroup">
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to save keyvalue data.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Label to store in</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
A label under which data is to be stored.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source Entity</b></span> <kbd  class="tooltip" data-tooltip="string">target</kbd> :
Entity to read value from.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Source Keyvalue</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Name of the keyvalue of the source entity to read value from.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after saving</b></span> <kbd  class="tooltip" data-tooltip="String">m_iszTrigger</kbd> :
Entity to trigger after the save-operation, even if nothing was loaded.
</div>
<div class="notices blue" markdown="1">If the entity to read from is not found, the save-file won't be touched.</div>
<div class="notices red" markdown="1">Trying to write strings containing line breaks (this does e.g. apply to game_text message-keyvalues containing the "\n"-character sequence) or colons will corrupt the save-file. This is because of how the feature was implemented and is simply not supported.</div>
