---
title: ambient_music
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity that allows to play sounds, designed to play music clips which volume can be adjusted in option menu (with 'Music Volume' slider), separately from normal game audio effects. Audio played with this entity are not affected by it's position.</div>
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
Set name of {{ entname }} so other entities can trigger it to play music. Depending on trigger use-type: 'Off'- stop the music, 'Toggle'- play/stop music interchangeably, 'On'- start the music. Kill-targeting this entity will stop music from playing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound File</b></span> <kbd  class="tooltip" data-tooltip="sound">message</kbd> :
Name of the sound file to play. Supported formats are: AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WAV, WMA, XM. Hammer will only let you select WAV-files, but other formats do work as they are fully supported by the game's sound engine. Type the path in manually in that case. File Path starts in the 'sound'-folder, example: 'mymap/soundfile.ogg'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Volume (10 = loudest)</b></span> <kbd  class="tooltip" data-tooltip="integer">volume</kbd> :
Set how loud the sound shall be in a range from 0 (not audible) to 10 (normal).
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Start Silent</span> : Entity need to be triggered to start playing music.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Loop</span> : The sound will play looped when triggered.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Activator Only</span> : Music will be heard only by player who is an activator of script (e.g. he pressed a button that triggers this entity).</li>
</ul>
</div>
<div class="notices blue" markdown="1">Music will be playing even for players who just connected to the server, it will start playing on appropriate offset.</div>
