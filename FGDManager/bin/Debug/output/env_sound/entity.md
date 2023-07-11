---
title: env_sound
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows you to set up specific ambient effects for increasing the sound experience and making it consistent with the visuals of your map.</div>
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
Set name of {{ entname }} so other entities can trigger it to apply sound effect to entities in radius- only when 'Use only' and 'Radius' are used. Every trigger use-type works uniformly. Can be kill-targeted but already applied effects persist.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Radius</b></span> <kbd  class="tooltip" data-tooltip="integer">radius</kbd> :
Radius, in units, in which a player has to be for the ambient effect to change for him. The ambient effect will stay after leaving the radius, until another env_sound is entered. If set to 0, the radius won't be used, this is useful when entity is "Use only".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Room Type</b></span> <kbd  class="tooltip" data-tooltip="Choices">roomtype</kbd> :
Pick the ambient effect here. There are 29 options.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : Normal (off)</li>
<li><b>1 </b> : Generic</li>
<li><b>2 </b> : Metal Small</li>
<li><b>3 </b> : Metal Medium</li>
<li><b>4 </b> : Metal Large</li>
<li><b>5 </b> : Tunnel Small</li>
<li><b>6 </b> : Tunnel Medium</li>
<li><b>7 </b> : Tunnel Large</li>
<li><b>8 </b> : Chamber Small</li>
<li><b>9 </b> : Chamber Medium</li>
<li><b>10</b> : Chamber Large</li>
<li><b>11</b> : Bright Small</li>
<li><b>12</b> : Bright Medium</li>
<li><b>13</b> : Bright Large</li>
<li><b>14</b> : Water Small</li>
<li><b>15</b> : Water Medium</li>
<li><b>16</b> : Water Large</li>
<li><b>17</b> : Concrete Small</li>
<li><b>18</b> : Concrete Medium</li>
<li><b>19</b> : Concrete Large</li>
<li><b>20</b> : Big Room</li>
<li><b>21</b> : Bigger Room</li>
<li><b>22</b> : Biggest Room</li>
<li><b>23</b> : Cavern Small</li>
<li><b>24</b> : Cavern Medium</li>
<li><b>25</b> : Cavern Large</li>
<li><b>26</b> : Weirdo - Drugged</li>
<li><b>27</b> : Weirdo - Dizzy</li>
<li><b>28</b> : Weirdo - Psychotic</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : <span style="color:#9fc5e8;">USE Only</span> : If selected, the env_sound apply sound effect directly (if radius is 0), or will check for players inside that radius single time whenever it is triggered.</li>
</ul>
</div>
<div class="notices red" markdown="1">When a player spawns within the radius of an env_sound, he won't be affected.</div>
<div class="notices red" markdown="1">Being in an env_sound for too short of a time won't cause its effects to be applied on the player.</div>
<div class="notices red" markdown="1">An env_sound effect is not reset to normal after a map change. If you do not want to use env_sounds in your map, you should at least add a few around its start locations to properly reset the effect.</div>
