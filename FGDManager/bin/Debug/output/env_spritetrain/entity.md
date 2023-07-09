---
title: env_spritetrain
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The env_spritetrain entity resembles an [env_sprite](../env_sprite) which can move along [path_corner](../path_corner) entities as a [func_train](../func_train) can. Ever wanted to make a flame travel along a fuse to a bomb? This entity is for you.</div>
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
Set name of {{ entname }} so other entities can trigger it to start or stop sprite movement. Depending on trigger use-type: 'On'- start movement, 'Off'- stop movement, 'Toggle'- toggle movement. Can be kill-targeted but sprite is not removed, only the 'train' part.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Global name of entity, allows to have one entity in the multiple maps (e.g. elevator in map1 and map2 have the same "Global Entity Name" which tells the engine to treat those entities as a one single entity, so all elevator settings, positions, actions e.t.c. are copied to another map in a moment of map transitions.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
Set custom render FX effect. Only works when "Render Mode" is set to different than 'Normal'
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
<span style="color:#9fc5e8;"><b>Render Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">rendermode</kbd> :
Render mode determines how this entity is rendered.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Normal : Normal rendering. Entity will receive light, except if it is a sprite. "FX Amount" is obsolete when this is used.</li>
<li><b>1</b> : Color : Brush entities only: Instead of rendering the texture, the whole entity will appear in one color, set by "FX Color". "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque.</li>
<li><b>2</b> : Texture : Texture-only rendering. Entity will not receive light. Instead, only the texture will be rendered as is. "FX Amount" sets the transparency. 0 means invisible. 255 means fully opaque. This is used for transparent things such as windows. Tip: If you have a window separating a dark and a bright room using only one entity, you can apply a brighter glass texture to the side of the window seen from within the dark room than to the side seen from the bright room. That way, the window's brightness will look realistic from both sides, instead of from just one. Generally, darker rooms require the render amount to be lower, making the glass more transparent, or it would look illogically bright.</li>
<li><b>3</b> : Glow : Sprites only. The sprite will appear in the same size regardless of your distance to it. In addition to that, the further away you are from it, the less visible it will be. (It's only barely visible at about 500 units far away) Good for light coronas. This renders the sprite in additive mode.</li>
<li><b>4</b> : Solid : Brush entities only. All textures of the brush entity starting with '{' will have the last color of their palette (usually blue, black or purple) be rendered fully transparent. This is used for textures with see-through parts, such as grates and railings. Requires "FX Amount" to be set to a value greater than 0, commonly 255.</li>
<li><b>5</b> : Additive : Works just as the "Render Mode" 'Texture', except that the entity's appearance will be added to the background instead of forming a mean. This means, black pixels of textures will be fully transparent, while full-bright pixels are added with a factor of "FX Amount" divided by 255. This is often used for sprites indicating a glowing light, as well as for overlay func_illusionaries to give a computer texture the appearance of having many small, glowing lights, screens and whatever other elements. Render-amount of 255 makes it bright. 0 makes it invisible.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Amount (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Render amount to use when other than "Render Mode" 'Normal' is used.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>FX Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Used with "Render Mode" 'Color' and 'Glow' to set color. Also sets color of 'Glow Shell' "Render Mode".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">movesnd</kbd> :
Sound that is played while the {{ entname }} is moving.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No Sound</li>
<li><b>1</b> : big elev 1<div class="imagepadding" markdown="1">![big elev 1](../audio/big-elev-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>2</b> : big elev 2<div class="imagepadding" markdown="1">![big elev 2](../audio/big-elev-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>3</b> : tech elev 1<div class="imagepadding" markdown="1">![tech elev 1](../audio/tech-elev-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>4</b> : tech elev 2<div class="imagepadding" markdown="1">![tech elev 2](../audio/tech-elev-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>5</b> : tech elev 3<div class="imagepadding" markdown="1">![tech elev 3](../audio/tech-elev-3.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>6</b> : freight elev 1<div class="imagepadding" markdown="1">![freight elev 1](../audio/freight-elev-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>7</b> : freight elev 2<div class="imagepadding" markdown="1">![freight elev 2](../audio/freight-elev-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : heavy elev<div class="imagepadding" markdown="1">![heavy elev](../audio/heavy-elev.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>9</b> : rack elev<div class="imagepadding" markdown="1">![rack elev](../audio/rack-elev.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>10</b> : rail elev<div class="imagepadding" markdown="1">![rail elev](../audio/rail-elev.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>11</b> : squeek elev<div class="imagepadding" markdown="1">![squeek elev](../audio/squeek-elev.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>12</b> : odd elev 1<div class="imagepadding" markdown="1">![odd elev 1](../audio/odd-elev-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>13</b> : odd elev 2<div class="imagepadding" markdown="1">![odd elev 2](../audio/odd-elev-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound Loops?</b></span> <kbd  class="tooltip" data-tooltip="choices">movesnd_loop</kbd> :
Sets if "Move Sound" should be looped during movement until it stops.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No</li>
<li><b>1</b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Sound</b></span> <kbd  class="tooltip" data-tooltip="choices">stopsnd</kbd> :
Sound which is played once as the {{ entname }} stops moving.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : No Sound</li>
<li><b>1</b> : big elev stop1<div class="imagepadding" markdown="1">![big elev stop1](../audio/big-elev-stop-1.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>2</b> : big elev stop2<div class="imagepadding" markdown="1">![big elev stop2](../audio/big-elev-stop-2.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>3</b> : freight elev stop<div class="imagepadding" markdown="1">![freight elev stop](../audio/freight-elev-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>4</b> : heavy elev stop<div class="imagepadding" markdown="1">![heavy elev stop](../audio/heavy-elev-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>5</b> : rack stop<div class="imagepadding" markdown="1">![rack stop](../audio/rack-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>6</b> : rail stop<div class="imagepadding" markdown="1">![rail stop](../audio/rail-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>7</b> : squeek stop<div class="imagepadding" markdown="1">![squeek stop](../audio/squeek-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
<li><b>8</b> : quick stop<div class="imagepadding" markdown="1">![quick stop](../audio/quick-stop.wav?controlsList=nodownload-nofullscreen-noremoteplayback)</div></li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Move Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">noise</kbd> :
Sound file to use when the {{ entname }} is moving. Useful when you don't want to use sound from default sound list. This overrides default "Move Sound" sound.  Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Stop Sound Override</b></span> <kbd  class="tooltip" data-tooltip="sound">noise1</kbd> :
Sound file to use when the {{ entname }} is stop moving. Useful when you don't want to use sound from default sound list. This overrides default "Stop Sound" sound.  Note that other sounds format (AIFF, ASF, DLS, FLAC, IT, M3U, MID, MOD, MP2, MP3, OGG, S3M, VAG, WMA, XM) can be used, even if editor sound browser allows to pick only WAV files.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Volume 0.0 - 1.0</b></span> <kbd  class="tooltip" data-tooltip="string">volume</kbd> :
Move and stop sound volume.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Allows you to setup a sound replacement file for the {{ entname }} sounds. The path begins in 'svencoop/sound/mapname', whereas 'mapname' would be your map's name. You can go to the parent directory using '../'. A valid sound replacement file contains one or more lines with two sound-paths, which are separated by a space and wrapped into quotes. The first sound is the sound to be replaced. The second sound is the new sound. Sound-paths start in the sound directory. You cannot go to the parent directory using '../' in that case. These sounds do not need to be precached using a [custom_precache](../custom_precache) point entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>First stop target</b></span> <kbd  class="tooltip" data-tooltip="target_source">target</kbd> :
The name of the first [path_corner](../path_corner) (where the train starts). The {{ entname }} is teleported to this position on map start, no matter where it's placed.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Speed (units per second)</b></span> <kbd  class="tooltip" data-tooltip="integer">speed</kbd> :
Movement-speed in units per second.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Obey Trigger Mode</b></span> <kbd  class="tooltip" data-tooltip="choices">m_iObeyTriggerMode</kbd> :
Controls how {{ entname }} behave when triggered with different use-types.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : No : 'Off', 'On' and 'Toggle'- toggle {{ entname }} movement.</li>
<li><b>1 </b> : Yes : 'On'- start moving, 'Off'- stop moving, 'Toggle'- toggle moving.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Name</b></span> <kbd  class="tooltip" data-tooltip="sprite">model</kbd> :
Set a sprite here. Path starts in modification's folder.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Scale</b></span> <kbd  class="tooltip" data-tooltip="string">scale</kbd> :
Scaling factor for the sprite. Defaults to 0.25 if not set.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>2048 </b> : <span style="color:#9fc5e8;">Not in Deathmatch</span> : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Spritetrains are not efficient on the network-code. You should use them as little as possible and only temporarily.</div>
