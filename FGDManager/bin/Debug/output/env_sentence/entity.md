---
title: env_sentence
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The env_sentence entity allows you to make announcements. Tthink of the announcer in Black Mesa from Half-Life's single player mode.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger on sentence start. Trigger use-type is the same as received.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to play a sentence. Every trigger use-type works uniformly. Multiple triggering will overlap sentences. Can be kill-targeted but sentence won't stop playing until finished.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sentence</b></span> <kbd  class="tooltip" data-tooltip="string">_text</kbd> :
Put a space-separated list of WAV-file names from the 'sounds/vox' -folder here, without the '.wav'-extension. Put a period for a pause, e.g. when at the end of a sentence. E.g. "unlocked maximum power.get out of hazard zone immediately".
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Activator Only</span> : Announcement will be heard only by player who is an activator of script (e.g. he pressed a button that triggers this entity).</li>
</ul>
</div>
<div class="notices blue">The announcer is audible over the whole map, in full volume, with no stereo or 3D-audio effect in relation to the env_sentence's position.</div>
<div class="notices blue">This can be triggered repeatedly and cause the same sentence to be read out multiple times in one moment.</div>
<div class="notices blue">Unlike other entities, env_sentence sends the same output type as received, instead of 'Toggle'.</div>
