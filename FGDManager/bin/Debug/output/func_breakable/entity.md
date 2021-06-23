---
title: func_breakable
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
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global Entity Name</b></span> <kbd  class="tooltip" data-tooltip="string">globalname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Classification</b></span> <kbd  class="tooltip" data-tooltip="choices">classify</kbd> :
Set the class of the spawned {{ entname }}. Think of how even though zombies and human grunts, by default, both are the players' enemies, yet have a dislike for and attack each other as well. This relation is created through the respective classes of the two entity types. For a complete table of how different classes react to each other, see [monster class relation table](https://wiki.svencoop.com/Class_Relationship_Table).
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : None</li>
<li><b>0 </b> : Object Default : Keep default classification.</li>
<li><b>1 </b> : Machine</li>
<li><b>2 </b> : Player</li>
<li><b>3 </b> : Human Passive</li>
<li><b>4 </b> : Human Military</li>
<li><b>5 </b> : Alien Military</li>
<li><b>6 </b> : Alien Passive</li>
<li><b>7 </b> : Alien Monster</li>
<li><b>8 </b> : Alien Prey</li>
<li><b>9 </b> : Alien Predator</li>
<li><b>10 </b> : Insect</li>
<li><b>11 </b> : Player Ally</li>
<li><b>12 </b> : Player Hornet/Snark</li>
<li><b>13 </b> : Alien Hornet/Snark</li>
<li><b>14 </b> : X-Race</li>
<li><b>15 </b> : X-Race: Shocktrooper/Voltigore</li>
<li><b>16 </b> : Team 1 : Use it to classify to custom team.</li>
<li><b>17 </b> : Team 2 : Use it to classify to custom team.</li>
<li><b>18 </b> : Team 3 : Use it to classify to custom team.</li>
<li><b>19 </b> : Team 4 : Use it to classify to custom team.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Render FX</b></span> <kbd  class="tooltip" data-tooltip="choices">renderfx</kbd> :
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
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
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
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
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
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
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
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
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
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
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
<span style="color:#9fc5e8;"><b>Strength</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Set how many hitpoints the {{ entname }} has.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Material type</b></span> <kbd  class="tooltip" data-tooltip="choices">material</kbd> :
Choose the material which matches what your {{ entname }} is supposed to be the most. The material type affects the {{ entname }}'s sounds emitted when it takes damage, as well as which gibs are created when it is destroyed. If the material is set to 'Unbreakable glass', the {{ entname }} is, regardless of how funny that is, in fact, unbreakable.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Glass</li>
<li><b>1</b> : Wood</li>
<li><b>2</b> : Metal</li>
<li><b>3</b> : Flesh</li>
<li><b>4</b> : Cinder Block</li>
<li><b>5</b> : Ceiling Tile</li>
<li><b>6</b> : Computer</li>
<li><b>7</b> : Unbreakable Glass</li>
<li><b>8</b> : Rocks</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Instant Break Weapon</b></span> <kbd  class="tooltip" data-tooltip="choices">weapon</kbd> :
Allows you to specify an instant-break weapon other than the crowbar. Requires "Instant Break" flag selected.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>1</b> : Crowbar</li>
<li><b>19</b> : Crowbar (Electric Only)</li>
<li><b>20</b> : Pipe Wrench</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gibs' direction and velocity</b></span> <kbd  class="tooltip" data-tooltip="choices">explosion</kbd> :
Set whether the gibs fly relative to where the attack came from, damage received and material (e.g. concrete gibs fly with less velocity) or randomly. This has no effect on the {{ entname }} destroyed via a trigger. Note: Blowing up stuff is much more fun when shit goes flying instead of just falling to the ground as if nothing happened.
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Random direction; no velocity</li>
<li><b>1</b> : Relative to attack/dmg./mat.</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Gib Model</b></span> <kbd  class="tooltip" data-tooltip="studio">gibmodel</kbd> :
Custom model of broken entity parts. Models with multiple 'Submodels' uses all of sub-models for gibs. If "Material Type" is set to 'Glass' then spawned gibs are transparent.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Spawn On Break</b></span> <kbd  class="tooltip" data-tooltip="choices">spawnobject</kbd> :
If the {{ entname }} is broken, the specified item will drop. It does respawn as standard item.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0</b> : Nothing</li>
<li><b>1</b> : Battery : [See details](../item_battery).</li>
<li><b>2</b> : Healthkit : Choice_Description_here</li>
<li><b>3</b> : 9mm Handgun : Choice_Description_here</li>
<li><b>4</b> : 9mm Clip : Choice_Description_here</li>
<li><b>5</b> : Machine Gun : Choice_Description_here</li>
<li><b>6</b> : Machine Gun Clip : Choice_Description_here</li>
<li><b>7</b> : Machine Gun Grenades : Choice_Description_here</li>
<li><b>8</b> : Shotgun : Choice_Description_here</li>
<li><b>9</b> : Shotgun Shells : Choice_Description_here</li>
<li><b>10</b> : Crossbow : Choice_Description_here</li>
<li><b>11</b> : Crossbow Bolts : Choice_Description_here</li>
<li><b>12</b> : 357 : Choice_Description_here</li>
<li><b>13</b> : 357 Clip : Choice_Description_here</li>
<li><b>14</b> : RPG : Choice_Description_here</li>
<li><b>15</b> : RPG Clip : Choice_Description_here</li>
<li><b>16</b> : Gauss Clip : Choice_Description_here</li>
<li><b>17</b> : Hand grenade : Choice_Description_here</li>
<li><b>18</b> : Tripmine : Choice_Description_here</li>
<li><b>19</b> : Satchel Charge : Choice_Description_here</li>
<li><b>20</b> : Snark : Choice_Description_here</li>
<li><b>21</b> : Hornet Gun : Choice_Description_here</li>
<li><b>22</b> : Crowbar : Choice_Description_here</li>
<li><b>23</b> : Pipewrench : Choice_Description_here</li>
<li><b>24</b> : Sniperrifle : Choice_Description_here</li>
<li><b>25</b> : Sniperrifle ammo : Choice_Description_here</li>
<li><b>26</b> : M16 Rifle : Choice_Description_here</li>
<li><b>27</b> : M249 Squad Automatic Weapon : Choice_Description_here</li>
<li><b>28</b> : Minigun : Choice_Description_here</li>
<li><b>29</b> : 556 Ammo Box : Choice_Description_here</li>
<li><b>30</b> : Sporelauncher : Choice_Description_here</li>
<li><b>31</b> : Spore Clip : Choice_Description_here</li>
<li><b>32</b> : 9mm Box : Choice_Description_here</li>
<li><b>33</b> : Uzi : Choice_Description_here</li>
<li><b>34</b> : Uzi akimbo : Choice_Description_here</li>
<li><b>35</b> : Desert Eagle : Choice_Description_here</li>
<li><b>36</b> : Barnacle Grapple : Choice_Description_here</li>
<li><b>37</b> : Medkit (portable) : Choice_Description_here</li>
<li><b>38</b> : HEV Suit : Choice_Description_here</li>
<li><b>39</b> : Antidote : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Explode Magnitude (0=none)</b></span> <kbd  class="tooltip" data-tooltip="integer">explodemagnitude</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Sound Replacement File</b></span> <kbd  class="tooltip" data-tooltip="string">soundlist</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>HUD Info name</b></span> <kbd  class="tooltip" data-tooltip="string">displayname</kbd> :
Keyvalue_Description_here
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum light level</b></span> <kbd  class="tooltip" data-tooltip="string">_minlight</kbd> :
Keyvalue_Description_here
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Only Trigger : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Touch : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Pressure : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>8</b> : Repairable : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>32</b> : Show HUD Info : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>64</b> : Immune To Clients : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>256</b> : Instant Break : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>512</b> : Explosives Only : Choice_Description_here</li>
<li class="imagepadding" markdown="1"><b>2048 </b> : Not in Deathmatch : Obsolete in Sven Co-op. Makes the entity don't appear in Multiplayer Games.</li>
</ul>
</div>
<div class="notices blue">Insert additional notes here</div>
<div class="notices red">Insert known issues here</div>
