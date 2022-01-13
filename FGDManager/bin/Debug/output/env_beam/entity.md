---
title: env_beam
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The env_beam entity is used to create a bolt between two entities.</div>
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
Set name of {{ entname }} so other entities can trigger it to enable/disable beam. Signals: 'On' to enable, 'Off' to disable and 'Toggle' to toggle beam. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Start Entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">LightningStart</kbd> :
Entity at which the beam starts. If this and the "End Entity" are not set, the env_beam entity will cast a random bolt hitting a solid surface in the specified radius around itself. This is not guaranteed to work unless there are solid faces in every direction from the env_beam entity within the specified radius.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ending Entity</b></span> <kbd  class="tooltip" data-tooltip="target_destination">LightningEnd</kbd> :
Entity at which the beam ends. If this is not set, the env_beam entity will cast a random bolt hitting a solid surface in the specified radius the start entity. This is not guaranteed to work unless there are solid faces in every direction from the start entity within the specified radius.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Set custom render FX effect. Only works when "Render Mode" is set to different 'Normal'
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Default rendering.</li>
<li><b>1</b> : Slow Pulse : Transparency slow fading in and out in a loop.</li>
<li><b>2</b> : Fast Pulse : Transparency fast fading in and out in a loop.</li>
<li><b>3</b> : Slow Wide Pulse : Transparency slow fading in and out widely in a loop.</li>
<li><b>4</b> : Fast Wide Pulse : Transparency fast fading in and out widely in a loop.</li>
<li><b>9</b> : Slow Strobe : Regular slow appearing/dissapearing.</li>
<li><b>10</b> : Fast Strobe : Regular fast appearing/dissapearing.</li>
<li><b>11</b> : Faster Strobe : Regular very fast appearing/dissapearing.</li>
<li><b>12</b> : Slow Flicker : Random slow appearing/dissapearing.</li>
<li><b>13</b> : Fast Flicker : Random fast appearing/dissapearing.</li>
<li><b>5</b> : Slow Fade Away : Not working. Fading out slowly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>6</b> : Fast Fade Away : Not working. Fading out quickly until reaching invisibility. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires high "FX Amount"</li>
<li><b>7</b> : Slow Become Solid : Not working. Fading in slowly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>8</b> : Fast Become Solid : Not working. Fading in quickly from invisible to fully visible. Works once when entity spawns or have changed it's "Render FX" at a runtime (e.g. through env_render). Requires low or zero "FX Amount"</li>
<li><b>14</b> : Constant Glow : Sprites with 'Glow' render mode only. Disables sprite resizing.</li>
<li><b>15</b> : Distort : Random distortion, looped.</li>
<li><b>16</b> : Hologram (Distort + fade) : 'Random distortion' + 'Pulse' applied, looped.</li>
<li><b>17</b> : Dead Player (DONT USE!)</li>
<li><b>18</b> : Explode (Garg Like)</li>
<li><b>19</b> : Glow Shell : Applies nice animated glowing shell on model. Color can be applied. "FX Amount" manipulates glow shell size.</li>
<li><b>20</b> : ClampMinScale (Sprites)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Brightness (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Set how bright/visible/transparent the beam shall be on a scale from '0' (invisible) to '255' (very bright).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Set the beam's color. Note that, because of bolts being rendered additively, darker colors mean greater transparency.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">Radius</kbd> :
Maximum distance from the start entity or {{ entname }}, depending on how you have set it up, to the destination of a random strike. Note that this kind of random strike has nothing to do with the flag 'Random strike', which only affects the timing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Life (seconds 0 = infinite)</b></span> <kbd  class="tooltip" data-tooltip="string">life</kbd> :
Time, in seconds, the beam/bolt will be visible after being triggered. A value of '0' makes it last forever.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Width of beam (pixels*0.1 0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">BoltWidth</kbd> :
Set the width of the bolt-/beam-texture in inches * 0.25. Note that one unit in Valve Hammer Editor equals one inch and the beam texture you are using possibly has entirely transparent sides, so the beam may appear a bit thinner than expected.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of noise (0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">NoiseAmplitude</kbd> :
Set how much the bolt shivers on a scale from 0 (not at all) to 255 (very much).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Name</b></span> <kbd  class="tooltip" data-tooltip="sprite">texture</kbd> :
Set the sprite to use to display the bolt. Path starts in modification's folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Scroll Rate (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">TextureScroll</kbd> :
The texture of the beam is not supposed to be displayed statically. Setting a texture scroll rate gives a visual effect of an actual, moving electric current. The value you set here specifies how often the texture will scroll for the length of its own height per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Frames per 10 seconds</b></span> <kbd  class="tooltip" data-tooltip="integer">framerate</kbd> :
Set how often the bolt texture should be updated within ten seconds. Now correctly supported.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Starting Frame</b></span> <kbd  class="tooltip" data-tooltip="integer">framestart</kbd> :
Set the number of the frame of the sprite to start animating at. This is rarely ever useful, e.g. when you have two identical beams next to each other and need them to look slightly different. Setting '0' here is safe.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Strike again time (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">StrikeTime</kbd> :
Time, in seconds, the env_beam entity will be idle after a bolt has run out, before creating the next one, when the 'Toggle'-flag is set. Negative values allow you to have the next beam fire before the current one runs out. However, setting a negative value that causes the next beam to be created the instant a beam is created causes an infinite amount of beams to be created, eventually causing overflows.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage / second</b></span> <kbd  class="tooltip" data-tooltip="string">damage</kbd> :
Average damage per second for beams with infinite lifetime. Damage in the moment of creation for temporary beams.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Start On : Causes the beam to be activated from map load onwards. Only makes sense in combination with the 'Toggle'-flag below.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Toggle : Causes the env_beam entity to be toggleable instead of causing just one temporary beam when triggered.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Random Strike :  If the 'Toggle'-flag is set along with this, this causes the env_beam's delay till striking again to be a random number between zero and the 'Strike again time'-value you specified.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Ring : Set it to form a circled beam which uses start and end point as the ring's intersection points, with the ring's center being in the middle between them. This requires start and end entity to be brush entities. Use of two func_trains with origin brushes is encouraged, as that is seen in the Half-Life single player! The ring always aligns itself to lie on the horizon of either of the two points looking at the other in respect to the z-axis.</li>
<li class="imagepadding" markdown="1"><b>16</b> : StartSparks : If set, sparks will be emitted at the start entity.</li>
<li class="imagepadding" markdown="1"><b>32</b> : EndSparks : If set, sparks will be emitted at the end entity.</li>
<li class="imagepadding" markdown="1"><b>64</b> : Decal End : If set, a bullet hole decal will be created whenever the beam hits a surface.</li>
<li class="imagepadding" markdown="1"><b>128</b> : Shade Start : If set, the beam will fade invisible towards the start point.</li>
<li class="imagepadding" markdown="1"><b>256</b> : Shade End : If set, the beam will fade invisible towards the end point.</li>
</ul>
</div>
<div class="notices blue">In case multiple entities match the name specified under start- and/or end-entity, the env_beam entity will pick one randomly each for every beam created.</div>
<div class="notices blue">Of the 'Shade start'- and 'Shade end'-flag, you may select one or neither. Using both makes only one function.</div>
<div class="notices blue">Ring-beams cannot have 'Shade start' nor 'Shade end' by design.</div>
<div class="notices blue">Contrary to what you may have read elsewhere, it is not possible to alter how fine a beam will be, as in, of how many segments it will consist.</div>
<div class="notices blue">The noise-value does not affect the area in which damage will be applied. The damage area only depends on startpoint, endpoint and beam-width.</div>
<div class="notices blue">When turning off a toggleable env_beam entity, its bolts will remain active until they run out of the specified lifetime, unless they are infinite. When reactivated, the next new beam will be created immediately, regardless of when the last one was created.</div>
<div class="notices blue">Setting "Sprite name" to 'sprite_01.spr' with moderate "Amount of Noise" makes it look like magical (but not too pretty) fairy.</div>
<div class="notices red">Ring-beams with infinite lifetime do not react to getting triggered off.</div>
<div class="notices red">If the 'Ring'-flag is set, damage will be applied as if the beam still was linear. (Only on a line between start and end point)</div>
<div class="notices red">Non-moving ring-beams with infinite lifetime occasionally disappear for specific clients completely. Set a lifetime of e.g. one second and a 'Strike again time'-value of '0' to encounter this issue.</div>
<div class="notices red">Ring-beams always apply damage as if they were temporary beams. (In moment of creation)</div>
<div class="notices red">Beams with limited lifetime cannot have 'Shade start' nor 'Shade end'.</div>
<div class="notices red">Non-toggleable env_beams act as toggleable env_beams do, except that they can never be turned off again.</div>
<div class="notices red">Setting a Render FX makes no change whatsoever.</div>
