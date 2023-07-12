---
title: info_node_air
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Equivalent of [info_node](../info_node) for flying monsters like [monster_alien_controller](../monster_alien_controller) and [monster_stukabat](../monster_stukabat).</div>
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
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hint type</b></span> <kbd  class="tooltip" data-tooltip="Choices">hinttype</kbd> :
Currently non-functional.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : None</li>
<li><b>4 </b> : World machinery</li>
<li><b>8 </b> : World blinking light</li>
<li><b>10 </b> : World human blood</li>
<li><b>11 </b> : World alien blood</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hint activity</b></span> <kbd  class="tooltip" data-tooltip="Choices">activity</kbd> :
Currently non-functional.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : None</li>
<li><b>0 </b> : Reset</li>
<li><b>1 </b> : Idle</li>
<li><b>2 </b> : Guard</li>
<li><b>3 </b> : Walk</li>
<li><b>4 </b> : Run</li>
<li><b>5 </b> : Fly</li>
<li><b>6 </b> : Swim</li>
<li><b>7 </b> : Hop</li>
<li><b>8 </b> : Leap</li>
<li><b>9 </b> : Fall</li>
<li><b>10 </b> : Land</li>
<li><b>11 </b> : Strafe left</li>
<li><b>12 </b> : Strafe right</li>
<li><b>13 </b> : Roll left</li>
<li><b>14 </b> : Roll right</li>
<li><b>15 </b> : Turn left</li>
<li><b>16 </b> : Turn Right</li>
<li><b>17 </b> : Crouch</li>
<li><b>18 </b> : Crouch idle</li>
<li><b>19 </b> : Stand up from crouch</li>
<li><b>20 </b> : Use</li>
<li><b>21 </b> : Signal 1</li>
<li><b>22 </b> : Signal 2</li>
<li><b>23 </b> : Signal 3</li>
<li><b>24 </b> : Twitch</li>
<li><b>25 </b> : Cower</li>
<li><b>26 </b> : Small flinch</li>
<li><b>27 </b> : Big flinch</li>
<li><b>28 </b> : Range attack 1</li>
<li><b>29 </b> : Range attack 2</li>
<li><b>30 </b> : Melee attack 1</li>
<li><b>31 </b> : Melee attack 2</li>
<li><b>32 </b> : Reload</li>
<li><b>33 </b> : Arm</li>
<li><b>34 </b> : Disarm</li>
<li><b>35 </b> : Eat</li>
<li><b>36 </b> : Die simple</li>
<li><b>37 </b> : Die backward</li>
<li><b>38 </b> : Die forward</li>
<li><b>39 </b> : Die violent</li>
<li><b>40 </b> : Barnacle hit</li>
<li><b>41 </b> : Barnacle pull</li>
<li><b>42 </b> : Barnacle chomp</li>
<li><b>43 </b> : Barnacle chew</li>
<li><b>44 </b> : Sleep</li>
<li><b>45 </b> : Inspect floor</li>
<li><b>46 </b> : Inspect wall</li>
<li><b>47 </b> : Idle angry</li>
<li><b>48 </b> : Walk hurt</li>
<li><b>49 </b> : Run hurt</li>
<li><b>50 </b> : Hover</li>
<li><b>51 </b> : Glide</li>
<li><b>52 </b> : Fly left</li>
<li><b>53 </b> : Fly right</li>
<li><b>54 </b> : Detect scent</li>
<li><b>55 </b> : Sniff</li>
<li><b>56 </b> : Bite</li>
<li><b>57 </b> : Threat display</li>
<li><b>58 </b> : Fear display</li>
<li><b>59 </b> : Excited</li>
<li><b>60 </b> : Special attack 1</li>
<li><b>61 </b> : Special attack 2</li>
<li><b>62 </b> : Combat idle</li>
<li><b>63 </b> : Walk scared</li>
<li><b>64 </b> : Run scared</li>
<li><b>65 </b> : Victory dance</li>
<li><b>66 </b> : Die head shot</li>
<li><b>67 </b> : Die chest shot</li>
<li><b>68 </b> : Die gut shot</li>
<li><b>69 </b> : Die back shot</li>
<li><b>70 </b> : Flinch head</li>
<li><b>71 </b> : Flinch chest</li>
<li><b>72 </b> : Flinch stomach</li>
<li><b>73 </b> : Flinch left arm</li>
<li><b>74 </b> : Flinch right arm</li>
<li><b>75 </b> : Flinch left leg</li>
<li><b>76 </b> : Flinch right leg</li>
</ul>
</div>
</div>
</div>
</div>
