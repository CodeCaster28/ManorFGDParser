---
title: ambient_generic
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This entity is used to play sound-files. They can be looping or not. You can use this to play music as well but [ambient_music](../ambient_music) fits more for this purpose.</div>
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
Set name of {{ entname }} so other entities can trigger it to play sound. Depending on trigger use-type: 'Off'- stop the sound, 'Toggle'- play/stop sound interchangeably, 'On'- start the sound but it's working only when any other signal was received previously. Kill-targeting this entity will stop sound from playing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound File</b></span> <kbd  class="tooltip" data-tooltip="sound">message</kbd> :
Name of the sound file to play. Supported formats are: AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WAV, WMA, XM. Hammer will only let you select WAV-files, but other formats do work as they are fully supported by the game's sound engine. Type the path in manually in that case. File Path starts in the 'sound'-folder, example: 'mymap/soundfile.ogg'. Alternatively, a sentence can be played using the ! prefix followed by a sentence name for the keyvalue, e.g. "!C1A2_0". Check the default_sentences.txt file for options.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Volume (10 = loudest)</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Set how loud the sound shall be in a range from 0 (not audible) to 10 (normal). Note that this is linear, while the human hearing sense is logarithmic. That means, 10 people talking sound two times as loud as one person talking. 100 people talking sound three times as loud as one person talking. So, a value of '1' will make the sound sound only half as loud as a value of '10' would. A value of '0.1' would make it a third as loud as a value of '10' would. So, if you want your sound to actually be quiet, you are likely to set a value below 1.0.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Play Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">playmode</kbd> :
This is the new way of setting whether a sound will loop or not. If a value other than 'Default' is selected, the 'Unlooped/Cyclic'-flag will be ignored and this option will be referenced to instead. You can also enable linear rolloff with this option, to allow you to setup your own radius. Note that linear rolloff isn't true to how sound works in real life, so it might sound/feel odd.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Default : Looping /on/off set to default for sound.</li>
<li><b>1</b> : Play Once : Always play once. 'Unlooped/Cyclic'-flag will be ignored.</li>
<li><b>2</b> : Loop : Always loop. 'Unlooped/Cyclic'-flag will be ignored</li>
<li><b>5</b> : Linear / Play Once : Always play once and use linear rolloff- "Linear minimum radius" and "Linear maximum radius". 'Unlooped/Cyclic'-flag will be ignored</li>
<li><b>6</b> : Linear / Loop : Always loop and use linear rolloff- "Linear minimum radius" and "Linear maximum radius". 'Unlooped/Cyclic'-flag will be ignored</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Dynamic Presets</b></span> <kbd  class="tooltip" data-tooltip="choices">preset</kbd> :
Allows you to specify a dynamic preset to enhance the sound. Used for sounds like machines warmup as it will repeatedly play a sound changing it's pitch and other parameters. You should probably experiment with these to find something that sounds good, if you don't want to stick with the default.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : None</li>
<li><b>1</b> : Huge Machine</li>
<li><b>2</b> : Big Machine</li>
<li><b>3</b> : Machine</li>
<li><b>4</b> : Slow Fade in</li>
<li><b>5</b> : Fade in</li>
<li><b>6</b> : Quick Fade in</li>
<li><b>7</b> : Slow Pulse</li>
<li><b>8</b> : Pulse</li>
<li><b>9</b> : Quick pulse</li>
<li><b>10</b> : Slow Oscillator</li>
<li><b>11</b> : Oscillator</li>
<li><b>12</b> : Quick Oscillator</li>
<li><b>13</b> : Grunge pitch</li>
<li><b>14</b> : Very low pitch</li>
<li><b>15</b> : Low pitch</li>
<li><b>16</b> : High pitch</li>
<li><b>17</b> : Very high pitch</li>
<li><b>18</b> : Screaming pitch</li>
<li><b>19</b> : Oscillate spinup/down</li>
<li><b>20</b> : Pulse spinup/down</li>
<li><b>21</b> : Random pitch</li>
<li><b>22</b> : Random pitch fast</li>
<li><b>23</b> : Incremental Spinup</li>
<li><b>24</b> : Alien</li>
<li><b>25</b> : Bizzare</li>
<li><b>26</b> : Planet X</li>
<li><b>27</b> : Haunted</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Start Volume</b></span> <kbd  class="tooltip" data-tooltip="integer">volstart</kbd> :
Start volume for fade-in; between 0.0 and 10.0.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade in time (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">fadein</kbd> :
Time, in seconds, till the sound will reach "Volume"-value after being triggered on, starting from "Start volume"-value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade out time (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">fadeout</kbd> :
Time, in seconds, till the sound will have faded out completely after being triggered off.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Pitch (> 100 = higher)</b></span> <kbd  class="tooltip" data-tooltip="integer">pitch</kbd> :
Sound playback speed, in per-cent.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Start Pitch</b></span> <kbd  class="tooltip" data-tooltip="integer">pitchstart</kbd> :
Initial sound playback speed, in per-cent. Changes towards "Pitch" within fade in time.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Spin up time (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">spinup</kbd> :
Time, in seconds, over which a spinup sound-effect (consecutive fade-ins) shall be applied as the sound starts playing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Spin down time (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">spindown</kbd> :
Time, in seconds, over which a spindown sound-effect (consecutive fade-outs) shall be applied as the sound is turned off.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>LFO type</b></span> <kbd  class="tooltip" data-tooltip="choices">lfotype</kbd> :
Allows you to set up a low frequency oscillator to modify volume and/or pitch over time, as the sound plays.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Off</li>
<li><b>1</b> : Square Wave</li>
<li><b>2</b> : Triangle Wave</li>
<li><b>3</b> : Random</li>
<li><b>4</b> : Saw Tooth Wave</li>
<li><b>5</b> : Sine Wave</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>LFO rate (0-1000)</b></span> <kbd  class="tooltip" data-tooltip="integer">lforate</kbd> :
Rate, in Hertz, at which the LFO oscillates. You'll usually want to put low values like 0.3.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>LFO mod pitch (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">lfomodpitch</kbd> :
Set how much the LFO shall affect the sound's pitch.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>LFO mod vol (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">lfomodvol</kbd> :
Set how much the LFO shall affect the sound's volume.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Incremental spinup count</b></span> <kbd  class="tooltip" data-tooltip="integer">cspinup</kbd> :
Set how many consecutive fade-ins/fade-outs shall be applied to spin-up and spin-down sound-effect.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Linear Min Radius</b></span> <kbd  class="tooltip" data-tooltip="choices">linearmin</kbd> :
When you set the play mode to use linear rolloff, the value set here will be used as the minimum sound radius, meaning the sound will be heard at full volume within this radius around the ambient_generic. You may only choose one of these preset values, as the volume curves need to be precalculated for performance reasons.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : 0 - 0 units</li>
<li><b>1</b> : 1 - 256 units</li>
<li><b>2</b> : 2 - 512 units</li>
<li><b>3</b> : 3 - 768 units</li>
<li><b>4</b> : 4 - 1,024 units</li>
<li><b>5</b> : 5 - 1,280 units</li>
<li><b>6</b> : 6 - 1,536 units</li>
<li><b>7</b> : 7 - 1,792 units</li>
<li><b>8</b> : 8 - 2,048 units</li>
<li><b>9</b> : 9 - 2,304 units</li>
<li><b>10</b> : 10 - 2,560 units</li>
<li><b>11</b> : 11 - 2,816 units</li>
<li><b>12</b> : 12 - 3,072 units</li>
<li><b>13</b> : 13 - 3,328 units</li>
<li><b>14</b> : 14 - 3,584 units</li>
<li><b>15</b> : 15 - 3,840 units</li>
<li><b>16</b> : 16 - 4,096 units</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Linear End Radius</b></span> <kbd  class="tooltip" data-tooltip="choices">linearmax</kbd> :
When you set the play mode to use linear rolloff, the value set here will be used as the maximum sound radius, meaning the sound cannot be heard outside of this radius around the ambient_generic. You may only choose one of these preset values, as the volume curves need to be precalculated for performance reasons.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>1</b> : 1 - 256 units</li>
<li><b>2</b> : 2 - 512 units</li>
<li><b>3</b> : 3 - 768 units</li>
<li><b>4</b> : 4 - 1,024 units</li>
<li><b>5</b> : 5 - 1,280 units</li>
<li><b>6</b> : 6 - 1,536 units</li>
<li><b>7</b> : 7 - 1,792 units</li>
<li><b>8</b> : 8 - 2,048 units</li>
<li><b>9</b> : 9 - 2,304 units</li>
<li><b>10</b> : 10 - 2,560 units</li>
<li><b>11</b> : 11 - 2,816 units</li>
<li><b>12</b> : 12 - 3,072 units</li>
<li><b>13</b> : 13 - 3,328 units</li>
<li><b>14</b> : 14 - 3,584 units</li>
<li><b>15</b> : 15 - 3,840 units</li>
<li><b>16</b> : 16 - 4,096 units</li>
</ul>
</div>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">Play Everywhere</span> : The sound will play everywhere.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : <span style="color:#9fc5e8;">Small Radius (~384)</span> : Non-linear big sound radius.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : <span style="color:#9fc5e8;">Medium Radius (~768)</span> : Non-linear huge sound radius.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : <span style="color:#9fc5e8;">Large Radius (~1536)</span> : Non-linear extra-huge sound radius.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : <span style="color:#9fc5e8;">Start Silent</span> : If set, this sound will start off. Only makes sense for looped sounds. This is usually left unchecked for ambient looping sounds, however only with other than default play mode. See notes for more info.</li>
<li class="imagepadding" markdown="1"><b>32 </b> : <span style="color:#9fc5e8;">Un-looped|Cyclic</span> : The sound will play once when triggered. If triggered while playing, the sound will stop and restart immediately.</li>
<li class="imagepadding" markdown="1"><b>64 </b> : <span style="color:#9fc5e8;">User Only (+origin)</span> : The sound will only be audible to the activator of this entity when triggered. If "Play everywhere" flag is set, the sound will be audible to everyone at their own position.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Looped sounds that starts enabled ("Start silent" flag unchecked) should use other than default play mode (preferably Linear/Looped) or they need to be triggered by trigger_auto after short delay (e.g. one second) with "Start silent" flag selected. This is because ambient_generics with default play mode are not correctly processed at map start, and works only after triggered.</div>
<div class="notices blue" markdown="1">If no sound radius is set, 'Medium radius' is used as a default. You should set only one sound radius, or 'Play everywhere'.</div>
