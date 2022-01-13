---
title: game_player_hurt
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Point entity which will apply damage to its activator. For a more feature-rich version see [trigger_hurt_remote](../trigger_hurt_remote).</div>
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
Set name of {{ entname }} so other entities can trigger it to apply damage to activator. All signal types are accepted. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">target</kbd> :
Entity or entities to trigger when damage is dealt. It sends same trigger state signal as it has received.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Delay Before Trigger</b></span> <kbd  class="tooltip" data-tooltip="string">delay</kbd> :
Delay before trigger entity specified in "Target".
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Kill Target</b></span> <kbd  class="tooltip" data-tooltip="target_destination">killtarget</kbd> :
Entity or entities to destroy when damage is dealt.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Damage To Apply</b></span> <kbd  class="tooltip" data-tooltip="string">dmg</kbd> :
Set how much damage to apply. Can kill the activator. Can be negative, but won't heal above 100, except when 'starthealth' is greater than that.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Master</b></span> <kbd  class="tooltip" data-tooltip="string">master</kbd> :
Name of the [multisource](../multisource) entity that (temporary) locks this {{ entname }}. If master specified the {{ entname }} will be disabled and it will not deal damage to player. When [multisource](../multisource) entity is triggered/being triggering by all possible inputs, the {{ entname }} will be unlocked. When [multisource](../multisource) lost at least one input signal, the entities becomes locked again.
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1</b> : Remove On fire : The game_player_hurt is removed from the game after being used once.</li>
</ul>
</div>
<div class="notices blue">Unlike other entities, game_player_hurt sends the same output type as received, instead of 'Toggle'.</div>
