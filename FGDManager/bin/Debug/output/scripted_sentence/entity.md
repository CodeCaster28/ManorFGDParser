---
title: scripted_sentence
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows any monster to speak a pre-assembled sentence or a custom audio file. Does automatic lip-syncing based on the file contents. If sentence have no given name, it will be activated on map start or when search radius is reached.</div>
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
Set name of {{ entname }} so other entities can trigger it to play a sentence. This will only work if "Search Radius" is set to '0'. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger on sentence play. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove on sentence play.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sentence Name</b></span> <kbd  class="tooltip" data-tooltip="string">sentence</kbd> :
Name of sentence from "sentences.txt" or sound file to play. Lip syncing is automatic when sound file is typed. To use sound file write '+' symbol and then filename with path (e.g. if you want to set file located in "svencoop/sound/mymap/bell1.wav", type '+mymap/bell1.wav'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speaker Type</b></span> <kbd  class="tooltip" data-tooltip="string">entity</kbd> :
Name OR classname of monster who will "speak" this sentence. If classname is specified, the search radius is used (sentence is activated when monster with specified classname reach radius).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sentence Time</b></span> <kbd  class="tooltip" data-tooltip="string">duration</kbd> :
Duration of monster speaking, in seconds. Best value is a sound file duration.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Search Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">radius</kbd> :
Radius, in units, in which to search for a valid target monster. This will only work if you specified a monster classname for 'Speaker Type'. Disables direct triggering. Set to 0 to disable.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Refire</b></span> <kbd  class="tooltip" data-tooltip="string">refire</kbd> :
Time interval between playing sentence. When sentence have a name this feature is disabled.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Listener Type</b></span> <kbd  class="tooltip" data-tooltip="string">listener</kbd> :
The name of entity the monster will look at when "speaking" a sentence.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Volume 0-10</b></span> <kbd  class="tooltip" data-tooltip="string">volume</kbd> :
Audibility of speaker.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Radius</b></span> <kbd  class="tooltip" data-tooltip="Choices">attenuation</kbd> :
Custom sound radius (just like radius flags in [ambient_generic](../ambient_generic)).
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Small Radius : About ~384 units.</li>
<li><b>1 </b> : Medium Radius : About ~768 units.</li>
<li><b>2 </b> : Large  Radius : About ~1536 units.</li>
<li><b>3 </b> : Play Everywhere : The sound will play everywhere.</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Fire Once</span> : Can be activated only once.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Followers Only</span> : Speak only if this monster is following player (by 'USE' follow command).</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Interrupt Speech</span> : Override current speech on affected monster (including default ones). Still some monsters interactions can break this sentence.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Concurrent</span> : This sentence cannot be played among other sentences (pick random sentence from those which are called at the moment). Also override any other sentences (like interrupt speech but works globally) except default sentences of other monsters.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Sound files are precached automatically (unlike sentences in monster classes).</div>
