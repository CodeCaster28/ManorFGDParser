---
title: trigger_load
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Trigger_load allows to read external map-data into an entity keyvalue from mapname.save in the "maps"-folder, which is stored on the server running the map. Its counterpart is [trigger_save](../trigger_save). Supports [custom keyvalues](../custom_keyvalues)..</div>
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
Set name of {{ entname }} so other entities can trigger it to load keyvalue data into entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Alternate Level Save File</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszLevelName</kbd> :
Need more info.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Label to read from</b></span> <kbd  class="tooltip" data-tooltip="string">netname</kbd> :
A label under which data is stored.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination Entity</b></span> <kbd  class="tooltip" data-tooltip="string">target</kbd> :
Entity to write value to.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Destination Keyvalue</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
Name of the keyvalue of the destination entity to write loaded value to.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger after loading</b></span> <kbd  class="tooltip" data-tooltip="String">m_iszTrigger</kbd> :
Entity to trigger after the load-operation, even if nothing was loaded.
</div>
<div class="notices blue" markdown="1">If the requested data was not found or no save-file for the map has been created, yet, the target keyvalue won't be touched.</div>
<div class="notices red" markdown="1">This will only set the keyvalue of the first destination entity found.</div>
