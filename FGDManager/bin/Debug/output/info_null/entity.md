---
title: info_null
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The info_null entity is commonly used as a target for [light_spot](../light_spot) entities. The compile tools will make any light_spot entity with a target 'look at' their targets. This is useful if the hierarchical Euler angles principle is too much for your brain to grasp properly, which doesn't appear to be rare. All info_null entities are removed when the map is loaded.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set the name so other entity can point to this entity as a target, preferably [light_spot](../light_spot).
</div>
