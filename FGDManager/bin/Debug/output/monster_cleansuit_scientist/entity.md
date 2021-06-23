---
title: monster_cleansuit_scientist
---

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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
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
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Slow Pulse : Choice_Description_here</li>
<li><b>2</b></span> : Fast Pulse : Choice_Description_here</li>
<li><b>3</b></span> : Slow Wide Pulse : Choice_Description_here</li>
<li><b>4</b></span> : Fast Wide Pulse : Choice_Description_here</li>
<li><b>9</b></span> : Slow Strobe : Choice_Description_here</li>
<li><b>10</b></span> : Fast Strobe : Choice_Description_here</li>
<li><b>11</b></span> : Faster Strobe : Choice_Description_here</li>
<li><b>12</b></span> : Slow Flicker : Choice_Description_here</li>
<li><b>13</b></span> : Fast Flicker : Choice_Description_here</li>
<li><b>5</b></span> : Slow Fade Away : Choice_Description_here</li>
<li><b>6</b></span> : Fast Fade Away : Choice_Description_here</li>
<li><b>7</b></span> : Slow Become Solid : Choice_Description_here</li>
<li><b>8</b></span> : Fast Become Solid : Choice_Description_here</li>
<li><b>14</b></span> : Constant Glow : Choice_Description_here</li>
<li><b>15</b></span> : Distort : Choice_Description_here</li>
<li><b>16</b></span> : Hologram (Distort + fade) : Choice_Description_here</li>
<li><b>17</b></span> : Dead Player (DONT USE!) : Choice_Description_here</li>
<li><b>18</b></span> : Explode (Garg Like) : Choice_Description_here</li>
<li><b>19</b></span> : Glow Shell : Choice_Description_here</li>
<li><b>20</b></span> : ClampMinScale (Sprites) : Choice_Description_here</li>
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
<li><b>0</b></span> : Normal : Choice_Description_here</li>
<li><b>1</b></span> : Color : Choice_Description_here</li>
<li><b>2</b></span> : Texture : Choice_Description_here</li>
<li><b>3</b></span> : Glow : Choice_Description_here</li>
<li><b>4</b></span> : Solid : Choice_Description_here</li>
<li><b>5</b></span> : Additive : Choice_Description_here</li>
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
<span style="color:#9fc5e8;"><b>Pitch Yaw Roll (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">angles</kbd> :
Where Z means Y and Y means Z, that is, when you're thinking Hammer-grid. (Hammer uses Z for height and Y for depth, while every other sane 3D-application does this the other way round; nonetheless this keyvalue description has the letters in the conventional order) This, technically, is a 3D-vector containing Euler-angles to describe either the entity's rotation or direction of effect. E.g. a func_door_rotating will use this as its initial rotation, while a trigger_push will keep its original alignment and use this for the direction of its push-effect instead. Euler-angles are a hierarchical system to determine an object's orientation in 3D-space. A yaw-value of 0 would mean the entity would face east. (right in top-down view) 90 would mean it would face north. (up in top-down-view) After yaw, pitch is applied. Think aiming up/down with your character in first person. At last, the roll-value is applied. Think your character falling over sideways in first person. Some entities, mostly point entities, do not use the angles keyvalue for any purpose.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classification</b></span> <kbd  class="tooltip" data-tooltip="choices">classify</kbd> :
Set the class of the spawned entity. Think of how even though zombies and human grunts, by default, both are the players' enemies, yet have a dislike for and attack each other as well. This relation is created through the respective classes of the two entity types. For a complete table of how different classes react to each other, see [monster class relation table](https://wiki.svencoop.com/Class_Relationship_Table).
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b></span> : None</li>
<li><b>0 </b></span> : Object Default : Keep default classification.</li>
<li><b>1 </b></span> : Machine</li>
<li><b>2 </b></span> : Player</li>
<li><b>3 </b></span> : Human Passive</li>
<li><b>4 </b></span> : Human Military</li>
<li><b>5 </b></span> : Alien Military</li>
<li><b>6 </b></span> : Alien Passive</li>
<li><b>7 </b></span> : Alien Monster</li>
<li><b>8 </b></span> : Alien Prey</li>
<li><b>9 </b></span> : Alien Predator</li>
<li><b>10 </b></span> : Insect</li>
<li><b>11 </b></span> : Player Ally</li>
<li><b>12 </b></span> : Player Hornet/Snark</li>
<li><b>13 </b></span> : Alien Hornet/Snark</li>
<li><b>14 </b></span> : X-Race</li>
<li><b>15 </b></span> : X-Race: Shocktrooper/Voltigore</li>
<li><b>16 </b></span> : Team 1 : Use it to classify to custom team.</li>
<li><b>17 </b></span> : Team 2 : Use it to classify to custom team.</li>
<li><b>18 </b></span> : Team 3 : Use it to classify to custom team.</li>
<li><b>19 </b></span> : Team 4 : Use it to classify to custom team.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is not revivable</b></span> <kbd  class="tooltip" data-tooltip="choices">is_not_revivable</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition</b></span> <kbd  class="tooltip" data-tooltip="Choices">TriggerCondition</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No Trigger : Choice_Description_here</li>
<li><b>1 </b></span> : See Player, Mad at Player : Choice_Description_here</li>
<li><b>2 </b></span> : Take Damage : Choice_Description_here</li>
<li><b>3 </b></span> : 50% Health Remaining : Choice_Description_here</li>
<li><b>4 </b></span> : Death : Choice_Description_here</li>
<li><b>7 </b></span> : Hear World : Choice_Description_here</li>
<li><b>8 </b></span> : Hear Player : Choice_Description_here</li>
<li><b>9 </b></span> : Hear Combat : Choice_Description_here</li>
<li><b>10</b></span> : See Player Unconditional : Choice_Description_here</li>
<li><b>11</b></span> : See Player, Not In Combat : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Trigger Condition Target</b></span> <kbd  class="tooltip" data-tooltip="String">TriggerTarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="choices">body</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : 0 : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Skin</b></span> <kbd  class="tooltip" data-tooltip="choices">skin</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : 0 : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is Player Ally?</b></span> <kbd  class="tooltip" data-tooltip="Choices">is_player_ally</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : No (Default) : Choice_Description_here</li>
<li><b>1 </b></span> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>In-game Name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Blood Color</b></span> <kbd  class="tooltip" data-tooltip="choices">bloodcolor</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Monster Default : Choice_Description_here</li>
<li><b>-1 </b></span> : No Blood : Choice_Description_here</li>
<li><b>1 </b></span> : Red : Choice_Description_here</li>
<li><b>2 </b></span> : Yellow : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Health</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Model</b></span> <kbd  class="tooltip" data-tooltip="studio">model</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Min Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">minhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom Max Hull Size (X Y Z)</b></span> <kbd  class="tooltip" data-tooltip="string">maxhullsize</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Monster Roaming (nodes)</b></span> <kbd  class="tooltip" data-tooltip="Choices">freeroam</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Map Default : Choice_Description_here</li>
<li><b>1 </b></span> : Never : Choice_Description_here</li>
<li><b>2 </b></span> : Always : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Path Name</b></span> <kbd  class="tooltip" data-tooltip="string">path_name</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Entity to Guard</b></span> <kbd  class="tooltip" data-tooltip="string">guard_ent</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Use Sentence</b></span> <kbd  class="tooltip" data-tooltip="String">UseSentence</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Un-Use Sentence</b></span> <kbd  class="tooltip" data-tooltip="String">UnUseSentence</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Is Player Ally?</b></span> <kbd  class="tooltip" data-tooltip="Choices">is_player_ally</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b></span> : Yes (Default) : Choice_Description_here</li>
<li><b>1 </b></span> : No : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Body</b></span> <kbd  class="tooltip" data-tooltip="Choices">body</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b></span> : Random : Choice_Description_here</li>
<li><b>0 </b></span> : Glasses : Choice_Description_here</li>
<li><b>1 </b></span> : Einstein : Choice_Description_here</li>
<li><b>2 </b></span> : Luther : Choice_Description_here</li>
<li><b>3 </b></span> : Slick : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Animation Sequence (editor)</b></span> <kbd  class="tooltip" data-tooltip="Choices">sequence</kbd> :
Keyvalue_Description_here
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>13 </b></span> : idle1 : Choice_Description_here</li>
<li><b>27 </b></span> : eye_wipe : Choice_Description_here</li>
<li><b>28 </b></span> : pull_needle : Choice_Description_here</li>
<li><b>29 </b></span> : return_needle : Choice_Description_here</li>
<li><b>30 </b></span> : give_shot : Choice_Description_here</li>
<li><b>41 </b></span> : germandeath : Choice_Description_here</li>
<li><b>48 </b></span> : console : Choice_Description_here</li>
<li><b>49 </b></span> : dryhands : Choice_Description_here</li>
<li><b>50 </b></span> : tieshoe : Choice_Description_here</li>
<li><b>51 </b></span> : whiteboard : Choice_Description_here</li>
<li><b>52 </b></span> : studycart : Choice_Description_here</li>
<li><b>53 </b></span> : lean : Choice_Description_here</li>
<li><b>54 </b></span> : pondering : Choice_Description_here</li>
<li><b>55 </b></span> : pondering2 : Choice_Description_here</li>
<li><b>56 </b></span> : pondering3 : Choice_Description_here</li>
<li><b>57 </b></span> : buysoda : Choice_Description_here</li>
<li><b>61 </b></span> : push_button : Choice_Description_here</li>
<li><b>62 </b></span> : converse1 : Choice_Description_here</li>
<li><b>63 </b></span> : converse2 : Choice_Description_here</li>
<li><b>64 </b></span> : retina : Choice_Description_here</li>
<li><b>65 </b></span> : talkleft : Choice_Description_here</li>
<li><b>66 </b></span> : talkright : Choice_Description_here</li>
<li><b>67 </b></span> : deskidle : Choice_Description_here</li>
<li><b>68 </b></span> : coffee : Choice_Description_here</li>
<li><b>69 </b></span> : franticbutton : Choice_Description_here</li>
<li><b>71 </b></span> : scientist_throwna : Choice_Description_here</li>
<li><b>72 </b></span> : scientist_thrownb : Choice_Description_here</li>
<li><b>73 </b></span> : scientist_beatwindow : Choice_Description_here</li>
<li><b>75 </b></span> : scientist_zombiefear : Choice_Description_here</li>
<li><b>77 </b></span> : teleport_fidget : Choice_Description_here</li>
<li><b>79 </b></span> : sitlookleft : Choice_Description_here</li>
<li><b>80 </b></span> : sitlookright : Choice_Description_here</li>
<li><b>81 </b></span> : sitscared : Choice_Description_here</li>
<li><b>82 </b></span> : sitting2 : Choice_Description_here</li>
<li><b>83 </b></span> : sitting3 : Choice_Description_here</li>
<li><b>84 </b></span> : cprscientist : Choice_Description_here</li>
<li><b>85 </b></span> : cprscientistrevive : Choice_Description_here</li>
<li><b>86 </b></span> : cowering_in_corner : Choice_Description_here</li>
<li><b>87 </b></span> : sstruggleidle : Choice_Description_here</li>
<li><b>88 </b></span> : sstruggle : Choice_Description_here</li>
<li><b>89 </b></span> : headcrabbed : Choice_Description_here</li>
<li><b>90 </b></span> : c1a0_catwalkidle : Choice_Description_here</li>
<li><b>91 </b></span> : c1a0_catwalk : Choice_Description_here</li>
<li><b>92 </b></span> : ceiling_dangle : Choice_Description_here</li>
<li><b>93 </b></span> : ventpull1 : Choice_Description_here</li>
<li><b>94 </b></span> : ventpull2 : Choice_Description_here</li>
<li><b>95 </b></span> : ventpullidle1 : Choice_Description_here</li>
<li><b>96 </b></span> : ventpullidle2 : Choice_Description_here</li>
<li><b>97 </b></span> : sitidle : Choice_Description_here</li>
<li><b>98 </b></span> : sitstand : Choice_Description_here</li>
<li><b>99 </b></span> : keypad : Choice_Description_here</li>
<li><b>101 </b></span> : lookwindow : Choice_Description_here</li>
<li><b>102 </b></span> : wave : Choice_Description_here</li>
<li><b>103 </b></span> : pulldoor : Choice_Description_here</li>
<li><b>104 </b></span> : beatdoor : Choice_Description_here</li>
<li><b>105 </b></span> : fallingloop : Choice_Description_here</li>
<li><b>106 </b></span> : crawlwindow : Choice_Description_here</li>
<li><b>107 </b></span> : divewindow : Choice_Description_here</li>
<li><b>108 </b></span> : locked_door : Choice_Description_here</li>
<li><b>109 </b></span> : push_button2 : Choice_Description_here</li>
<li><b>110 </b></span> : unlock_door : Choice_Description_here</li>
<li><b>112 </b></span> : handrailidle : Choice_Description_here</li>
<li><b>113 </b></span> : handrail : Choice_Description_here</li>
<li><b>114 </b></span> : hanging_idle : Choice_Description_here</li>
<li><b>115 </b></span> : fall : Choice_Description_here</li>
<li><b>116 </b></span> : scientist_get_pulled : Choice_Description_here</li>
<li><b>117 </b></span> : hanging_idle2 : Choice_Description_here</li>
<li><b>118 </b></span> : fall_elevator : Choice_Description_here</li>
<li><b>119 </b></span> : scientist_idlewall : Choice_Description_here</li>
<li><b>120 </b></span> : ickyjump_sci : Choice_Description_here</li>
<li><b>121 </b></span> : haulscientist : Choice_Description_here</li>
<li><b>122 </b></span> : c1a4_wounded_idle : Choice_Description_here</li>
<li><b>123 </b></span> : c1a4_dying_speech : Choice_Description_here</li>
<li><b>124 </b></span> : tentacle_grab : Choice_Description_here</li>
<li><b>125 </b></span> : helicack : Choice_Description_here</li>
<li><b>126 </b></span> : windive : Choice_Description_here</li>
<li><b>127 </b></span> : scicrashidle : Choice_Description_here</li>
<li><b>128 </b></span> : scicrash : Choice_Description_here</li>
<li><b>129 </b></span> : onguard : Choice_Description_here</li>
<li><b>130 </b></span> : seeya : Choice_Description_here</li>
<li><b>131 </b></span> : rocketcrawl : Choice_Description_here</li>
<li><b>132 </b></span> : portal : Choice_Description_here</li>
<li><b>133 </b></span> : gluonshow : Choice_Description_here</li>
<li><b>135 </b></span> : kneel : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li><b>1 </b></span> : WaitTillSeen : Choice_Description_here</li>
<li><b>2 </b></span> : Gag : Choice_Description_here</li>
<li><b>4 </b></span> : MonsterClip : Choice_Description_here</li>
<li><b>16</b></span> : Prisoner : Choice_Description_here</li>
<li><b>128</b></span> : WaitForScript : Choice_Description_here</li>
<li><b>256</b></span> : Pre-Disaster : Choice_Description_here</li>
<li><b>512</b></span> : Don't Fade Corpse : Choice_Description_here</li>
<li><b>2048 </b></span> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
<li><b>16384</b></span> : No Dyn Collision : Choice_Description_here</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
