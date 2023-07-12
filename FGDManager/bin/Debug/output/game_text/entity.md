---
title: game_text
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">An entity to display HUD messages to the player who activated it, or all players.</div>
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
Set name of {{ entname }} so other entities can trigger it to display text. Every trigger use-type works uniformly. Firing on already displaying text resets it. Can be kill-targeted but already displayed text stays.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity to trigger when text is displayed. Trigger use-type is 'Toggle'.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity to remove when text is displayed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Message Text</b></span> <kbd  class="tooltip" data-tooltip="string">message</kbd> :
The message to send. Can have a maximum of 490 chars. However, Valve Hammer Editor will truncate the string to 128 if longer than that and crash if the keyvalue is displayed while having more than 127 chars. If you need a message that long, it is advised to manually assemble it once using a few [trigger_changevalue](../trigger_changevalue) entities. Using '\n', you can get into the next line.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>X (0 - 1.0 = left to right) (-1 centers)</b></span> <kbd  class="tooltip" data-tooltip="string">x</kbd> :
Horizontal positioning. 0.0 to 1.0. 0.0 means left. 1.0 means right. More accurately, this defines the horizontal offset of where every line of the message starts. A value of 1.0 would literally shove the message off of the right side of the screen. '-1' centers every line depending on its length.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Y (0 - 1.0 = top to bottom) (-1 centers)</b></span> <kbd  class="tooltip" data-tooltip="string">y</kbd> :
Vertical positioning. 0.0 to 1.0. 0.0 means top. 1.0 means bottom. '-1' centers the whole message as one, if it has multiple lines. It is advised to not center this, as it obscures the players view too much and looks shabby when drawn over the crosshair. Try values like 0.4 or 0.6 instead. Note that depending on the resolution, too high/low values may end up out of screen. Try to stay between 0.2 and 0.8. In case you ever wondered how big of an y-value equals exactly one line break, here is a list showing that in dependence on the player's resolution:
1600 x 1200: 0.016666
1280 x 960: 0.020800
1280 x 1024: 0.019550
1152 x 864: 0.023150
1024 x 768: 0.026000
800 x 600: 0.033333
720 x 576: 0.034700
640 x 480: 0.041600
960 x 600: 0.033333
1088 x 612: 0.032700
1280 x 720: 0.027800
1280 x 800: 0.025000
1600 x 900: 0.022222
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Text Effect</b></span> <kbd  class="tooltip" data-tooltip="Choices">effect</kbd> :
Specify a text effect..
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Fade In/Out : Has a time-value to fade in, to stay on screen and to fade out.</li>
<li><b>1 </b> : Credits : Same as 'Fade in/out', except that it causes the message to flicker.</li>
<li><b>2 </b> : Scan Out : Has a time-value for per-char color transition and fade-in time per char.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Color 1 (Add 4th number >0 for opaque)</b></span> <kbd  class="tooltip" data-tooltip="color255">color</kbd> :
Color with which the text is rendered. Note that HUD messages are rendered additive. If you want your text to appear darker, make the color darker. You can add optional 4th parameter for opaque.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Color 2 (Add 4th number >0 for opaque)</b></span> <kbd  class="tooltip" data-tooltip="color255">color2</kbd> :
Another color with which the text is rendered. It comes to use with 'Credits'- and 'Scan out'-effect only. Note that HUD messages are rendered additive. If you want your text to appear darker, make the color darker. You can add optional 4th parameter for opaque.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade in Time (or character scan time)</b></span> <kbd  class="tooltip" data-tooltip="string">fadein</kbd> :
If the effect is 'Fade in/out' or 'Credits', this specifies the fade-in time. If the effect is set to 'Scan out', this sets the time that is taken for every single char to change its color from 'Color 2' to 'Color 1'. Fade-in time should be short.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Fade Out Time</b></span> <kbd  class="tooltip" data-tooltip="string">fadeout</kbd> :
If the effect is 'Fade in/out' or 'Credits', this specifies the fade-out time. If the effect is set to 'Scan out', this has no effect. Fade-out time should be longer than fade-in time, so the player notices that the message is going to disappear and can react by trying to read faster.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hold Time</b></span> <kbd  class="tooltip" data-tooltip="string">holdtime</kbd> :
Time the message stays on screen after fading in, before it will being to fade out. For effect 'Scan out', this delay will start after all chars have faded in.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Scan time (scan effect only)</b></span> <kbd  class="tooltip" data-tooltip="string">fxtime</kbd> :
For effect 'Scan out', this defines the time required for a character to fade in to 'Color 2'. The next char will only start fading in as the previous one finishes. Small values like 0.01 to 0.1 seconds make sense here.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Text Channel</b></span> <kbd  class="tooltip" data-tooltip="choices">channel</kbd> :
Select one of four channels to use. If a message already exists in one channel, it will be replaced.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>1 </b> : Channel 1</li>
<li><b>2 </b> : Channel 2</li>
<li><b>3 </b> : Channel 3</li>
<li><b>4 </b> : Channel 4</li>
</ul>
</div>
</div>
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the [multisource](../multisource) entity that (temporary) locks this {{ entname }}. If master is specified the {{ entname }} will be disabled and it will not show text. When [multisource](../multisource) entity is triggered/being triggering by all possible inputs, the {{ entname }} will be unlocked. When [multisource](../multisource) lost at least one input signal, the entities becomes locked again.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">All Players</span> : If set, the game_text's message will be displayed to all players instead of just the activator.</li>
<li class="imagepadding" markdown="1"><b>2</b> : <span style="color:#9fc5e8;">No console echo</span> : If set, players will not receive a duplicate of the message in their console. Set this for messages that can be reread or are sent often to prevent console-spam and reduce network-bandwidth-usage.</li>
</ul>
</div>
<div class="notices blue" markdown="1">The game_text's target will be triggered when the game_text entity is triggered. This is very useful when you want to use a single notification sound consistently on all your game_text entities.</div>
<div class="notices blue" markdown="1">Sven Co-op features a HUD monster-/player-info, which uses HUD message channel 3. Avoid using that channel for important messages. Even if you disable monster-info by setting the CVar 'mp_allowmonsterinfo' to '0', player-info will still display on that channel.</div>
<div class="notices red" markdown="1">If a text message is replaced by another one because it is set to use the same channel, the time-values won't be updated, causing the new message to expire earlier than desired. Furthermore, only one text message can exist at a specific screen coordinate at a time, even if two different channels are provided.</div>
<div class="notices red" markdown="1">If one line of the message is too long to fit on a player's screen, it will crash the game.</div>
