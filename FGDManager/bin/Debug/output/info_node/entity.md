---
title: info_node
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
<span style="color:#9fc5e8;"><b>Hint type</b></span> <kbd  class="tooltip" data-tooltip="Choices">hinttype</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : None : Choice_Description_here</li>
<li><b>4 </b> : World machinery : Choice_Description_here</li>
<li><b>8 </b> : World blinking light : Choice_Description_here</li>
<li><b>10 </b> : World human blood : Choice_Description_here</li>
<li><b>11 </b> : World alien blood : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Hint activity</b></span> <kbd  class="tooltip" data-tooltip="Choices">activity</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : None : Choice_Description_here</li>
<li><b>0 </b> : Reset : Choice_Description_here</li>
<li><b>1 </b> : Idle : Choice_Description_here</li>
<li><b>2 </b> : Guard : Choice_Description_here</li>
<li><b>3 </b> : Walk : Choice_Description_here</li>
<li><b>4 </b> : Run : Choice_Description_here</li>
<li><b>5 </b> : Fly : Choice_Description_here</li>
<li><b>6 </b> : Swim : Choice_Description_here</li>
<li><b>7 </b> : Hop : Choice_Description_here</li>
<li><b>8 </b> : Leap : Choice_Description_here</li>
<li><b>9 </b> : Fall : Choice_Description_here</li>
<li><b>10 </b> : Land : Choice_Description_here</li>
<li><b>11 </b> : Strafe left : Choice_Description_here</li>
<li><b>12 </b> : Strafe right : Choice_Description_here</li>
<li><b>13 </b> : Roll left : Choice_Description_here</li>
<li><b>14 </b> : Roll right : Choice_Description_here</li>
<li><b>15 </b> : Turn left : Choice_Description_here</li>
<li><b>16 </b> : Turn Right : Choice_Description_here</li>
<li><b>17 </b> : Crouch : Choice_Description_here</li>
<li><b>18 </b> : Crouch idle : Choice_Description_here</li>
<li><b>19 </b> : Stand up from crouch : Choice_Description_here</li>
<li><b>20 </b> : Use : Choice_Description_here</li>
<li><b>21 </b> : Signal 1 : Choice_Description_here</li>
<li><b>22 </b> : Signal 2 : Choice_Description_here</li>
<li><b>23 </b> : Signal 3 : Choice_Description_here</li>
<li><b>24 </b> : Twitch : Choice_Description_here</li>
<li><b>25 </b> : Cower : Choice_Description_here</li>
<li><b>26 </b> : Small flinch : Choice_Description_here</li>
<li><b>27 </b> : Big flinch : Choice_Description_here</li>
<li><b>28 </b> : Range attack 1 : Choice_Description_here</li>
<li><b>29 </b> : Range attack 2 : Choice_Description_here</li>
<li><b>30 </b> : Melee attack 1 : Choice_Description_here</li>
<li><b>31 </b> : Melee attack 2 : Choice_Description_here</li>
<li><b>32 </b> : Reload : Choice_Description_here</li>
<li><b>33 </b> : Arm : Choice_Description_here</li>
<li><b>34 </b> : Disarm : Choice_Description_here</li>
<li><b>35 </b> : Eat : Choice_Description_here</li>
<li><b>36 </b> : Die simple : Choice_Description_here</li>
<li><b>37 </b> : Die backward : Choice_Description_here</li>
<li><b>38 </b> : Die forward : Choice_Description_here</li>
<li><b>39 </b> : Die violent : Choice_Description_here</li>
<li><b>40 </b> : Barnacle hit : Choice_Description_here</li>
<li><b>41 </b> : Barnacle pull : Choice_Description_here</li>
<li><b>42 </b> : Barnacle chomp : Choice_Description_here</li>
<li><b>43 </b> : Barnacle chew : Choice_Description_here</li>
<li><b>44 </b> : Sleep : Choice_Description_here</li>
<li><b>45 </b> : Inspect floor : Choice_Description_here</li>
<li><b>46 </b> : Inspect wall : Choice_Description_here</li>
<li><b>47 </b> : Idle angry : Choice_Description_here</li>
<li><b>48 </b> : Walk hurt : Choice_Description_here</li>
<li><b>49 </b> : Run hurt : Choice_Description_here</li>
<li><b>50 </b> : Hover : Choice_Description_here</li>
<li><b>51 </b> : Glide : Choice_Description_here</li>
<li><b>52 </b> : Fly left : Choice_Description_here</li>
<li><b>53 </b> : Fly right : Choice_Description_here</li>
<li><b>54 </b> : Detect scent : Choice_Description_here</li>
<li><b>55 </b> : Sniff : Choice_Description_here</li>
<li><b>56 </b> : Bite : Choice_Description_here</li>
<li><b>57 </b> : Threat display : Choice_Description_here</li>
<li><b>58 </b> : Fear display : Choice_Description_here</li>
<li><b>59 </b> : Excited : Choice_Description_here</li>
<li><b>60 </b> : Special attack 1 : Choice_Description_here</li>
<li><b>61 </b> : Special attack 2 : Choice_Description_here</li>
<li><b>62 </b> : Combat idle : Choice_Description_here</li>
<li><b>63 </b> : Walk scared : Choice_Description_here</li>
<li><b>64 </b> : Run scared : Choice_Description_here</li>
<li><b>65 </b> : Victory dance : Choice_Description_here</li>
<li><b>66 </b> : Die head shot : Choice_Description_here</li>
<li><b>67 </b> : Die chest shot : Choice_Description_here</li>
<li><b>68 </b> : Die gut shot : Choice_Description_here</li>
<li><b>69 </b> : Die back shot : Choice_Description_here</li>
<li><b>70 </b> : Flinch head : Choice_Description_here</li>
<li><b>71 </b> : Flinch chest : Choice_Description_here</li>
<li><b>72 </b> : Flinch stomach : Choice_Description_here</li>
<li><b>73 </b> : Flinch left arm : Choice_Description_here</li>
<li><b>74 </b> : Flinch right arm : Choice_Description_here</li>
<li><b>75 </b> : Flinch left leg : Choice_Description_here</li>
<li><b>76 </b> : Flinch right leg : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
