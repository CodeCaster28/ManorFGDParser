---
title: func_healthcharger
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column">The func_healthcharger is a visible, solid entity which can be used just as a func_button can, and will refill 15 health points per second while using it. Multiple players can use it at the same time, but the HP restored per second is distributed equally among them. Healthchargers refill themselves 30 seconds after being emptied.
> sk_healthcharger # (Default: 80, 80, 80): Sets how many health points health chargers store.
</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Choice_Description_here</li>
<li><b>1</b> : Slow Pulse : Choice_Description_here</li>
<li><b>2</b> : Fast Pulse : Choice_Description_here</li>
<li><b>3</b> : Slow Wide Pulse : Choice_Description_here</li>
<li><b>4</b> : Fast Wide Pulse : Choice_Description_here</li>
<li><b>9</b> : Slow Strobe : Choice_Description_here</li>
<li><b>10</b> : Fast Strobe : Choice_Description_here</li>
<li><b>11</b> : Faster Strobe : Choice_Description_here</li>
<li><b>12</b> : Slow Flicker : Choice_Description_here</li>
<li><b>13</b> : Fast Flicker : Choice_Description_here</li>
<li><b>5</b> : Slow Fade Away : Choice_Description_here</li>
<li><b>6</b> : Fast Fade Away : Choice_Description_here</li>
<li><b>7</b> : Slow Become Solid : Choice_Description_here</li>
<li><b>8</b> : Fast Become Solid : Choice_Description_here</li>
<li><b>14</b> : Constant Glow : Choice_Description_here</li>
<li><b>15</b> : Distort : Choice_Description_here</li>
<li><b>16</b> : Hologram (Distort + fade) : Choice_Description_here</li>
<li><b>17</b> : Dead Player (DONT USE!) : Choice_Description_here</li>
<li><b>18</b> : Explode (Garg Like) : Choice_Description_here</li>
<li><b>19</b> : Glow Shell : Choice_Description_here</li>
<li><b>20</b> : ClampMinScale (Sprites) : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Choice_Description_here</li>
<li><b>1</b> : Color : Choice_Description_here</li>
<li><b>2</b> : Texture : Choice_Description_here</li>
<li><b>3</b> : Glow : Choice_Description_here</li>
<li><b>4</b> : Solid : Choice_Description_here</li>
<li><b>5</b> : Additive : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Template Model Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_usemodel</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Copy Lighting From Target</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_copylight</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Disable Clipping</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_noclip</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Choice_Description_here</li>
<li><b>1 </b> : Always non-solid : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Invisible</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_invisible</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Visible (default) : Choice_Description_here</li>
<li><b>1 </b> : Invisible : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Custom Shadow (when opaque)</b></span> <kbd  class="tooltip" data-tooltip="string">zhlt_customshadow</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map (when translucent)</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_embedlightmap</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No (default) : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Embed Light Map Resolution</b></span> <kbd  class="tooltip" data-tooltip="integer">zhlt_embedlightmapresolution</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Flags</b></span> <kbd  class="tooltip" data-tooltip="choices">zhlt_lightflags</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Default : Choice_Description_here</li>
<li><b>1 </b> : Embedded Fix : Choice_Description_here</li>
<li><b>2 </b> : Opaque (blocks light) : Choice_Description_here</li>
<li><b>3 </b> : Opaque + Embedded fix : Choice_Description_here</li>
<li><b>6 </b> : Opaque + Concave Fix : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>ZHLT Light Origin Target</b></span> <kbd  class="tooltip" data-tooltip="string">light_origin</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum light level</b></span> <kbd  class="tooltip" data-tooltip="string">_minlight</kbd> :
Sets the minimum light level. Useful for when textures should always appear bright e.g. computer screens or holograms. Default is 0, max 1.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Allows you to setup a sound replacement file {{ entname }} sounds. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a custom_precache point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Juice Amount</b></span> <kbd  class="tooltip" data-tooltip="integer">CustomJuice</kbd> :
Custom max charges amount. '0' for default.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Recharge Time</b></span> <kbd  class="tooltip" data-tooltip="integer">CustomRechargeTime</kbd> :
Time, in seconds, for {{ entname }} to replenish it's charges. '0' for default.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger On Empty</b></span> <kbd  class="tooltip" data-tooltip="target_destination">TriggerOnEmpty</kbd> :
Entity to fire when charges are fully consumed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger on Recharged</b></span> <kbd  class="tooltip" data-tooltip="target_destination">TriggerOnRecharged</kbd> :
Entity to fire when {{ entname }} recharge itself after deplenishing and waiting "Custom Recharge Time".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Denied Sound</b></span> <kbd  class="tooltip" data-tooltip="sound">CustomDeniedSound</kbd> :
Custom sound file override to play when {{ entname }} holds no more charges, but player is still attempting to drain more.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Start Sound</b></span> <kbd  class="tooltip" data-tooltip="sound">CustomStartSound</kbd> :
Custom sound file override to play when player starts using the {{ entname }}.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Loop Sound</b></span> <kbd  class="tooltip" data-tooltip="sound">CustomLoopSound</kbd> :
Sound file to play (in a loop) when charging is in progress, just after "Custom Start Sound".
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">The medkit will refill once the player has recharged his health to his maximum health; the healthcharger still needs to have health remaining for that to work.</div>
<div class="notices blue">Charging the medkit won't drain the healthcharger.</div>
<div class="notices blue">Health Charger supports to have a name (even if it is not listed in object properties). You can set it by adding "targetname" key with SmartEdit mode disabled. Now entity can be killed and triggered to heal an activator by one point.</div>
