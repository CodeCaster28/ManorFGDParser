---
title: env_funnel
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">When triggered, this creates a large portal funnel particle effect of green particles being sucked into one point as can be seen in Half-Life's single player mode in the Black Mesa experiment accident scene. This creates many temporary entities and the entity is removed after use. The particles will appear in a large area above the env_funnel and be sucked into it. You can adjust the effect's rotation by changing the env_funnel's angles. This effect is purely visual.</div>
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
Set name of {{ entname }} so other entities can trigger it to create funnel effect. Every trigger use-type works uniformly. Triggering fade that is in progress restarts fade. Can be kill-targeted but funnel will emmit it's end.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom sprite</b></span> <kbd  class="tooltip" data-tooltip="sprite">sprite</kbd> :
Allows you to set a custom sprite.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Reverse</span> : If set, instead of particles appearing to be sucked into one point, they will be blown out of this point, like particle-explosion.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Reusable</span> : If set, the env_funnel can be triggered multiple times.</li>
</ul>
</div>
