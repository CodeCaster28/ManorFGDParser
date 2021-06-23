---
title: env_beam
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column">Entity_Description_here</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Keyvalue_Description_here
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
<span style="color:#9fc5e8;"><b>Brightness (1 - 255)</b></span> <kbd  class="tooltip" data-tooltip="integer">renderamt</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Beam Color (R G B)</b></span> <kbd  class="tooltip" data-tooltip="color255">rendercolor</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">Radius</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Life (seconds 0 = infinite)</b></span> <kbd  class="tooltip" data-tooltip="string">life</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Width of beam (pixels*0.1 0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">BoltWidth</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Amount of noise (0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">NoiseAmplitude</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sprite Name</b></span> <kbd  class="tooltip" data-tooltip="sprite">texture</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture Scroll Rate (0-100)</b></span> <kbd  class="tooltip" data-tooltip="integer">TextureScroll</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Frames per 10 seconds</b></span> <kbd  class="tooltip" data-tooltip="integer">framerate</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Starting Frame</b></span> <kbd  class="tooltip" data-tooltip="integer">framestart</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Strike again time (secs)</b></span> <kbd  class="tooltip" data-tooltip="string">StrikeTime</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage / second</b></span> <kbd  class="tooltip" data-tooltip="string">damage</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Start On : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Toggle : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Random Strike : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Ring : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>16</b> : StartSparks : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32</b> : EndSparks : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64</b> : Decal End : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>128</b> : Shade Start : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>256</b> : Shade End : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
