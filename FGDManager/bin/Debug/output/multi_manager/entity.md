---
title: multi_manager
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity that allows to trigger multiple targets when triggered (max 64), each having it's own time delay and triggering use-type (On, Off, Toggle or Kill). Useful when we need to trigger more than one target with different names. In order to do this, you will have to disable Valve Hammer Editor's smart edit mode while viewing a multi_manager entity properties. There, you may add custom keyvalues. The name of the key be the targetname of the entity/entities to be triggered. The value be the time, in seconds, till the target will be triggered after the multi_manager entity is triggered (E.g.: "2.5"). The default use-type is 'Toggle'. For other use-types, you must add a token to the value (without the quotes):<br>For 'Off', add "#0".<br>For 'On', add "#1".<br>For 'Kill', add "#2".<br>E.g. a value could be "3.25#2" to killtarget after 3.25 seconds. You may add the same targetnames/keys multiple times. Valve Hammer Editor will automatically add a hash ('#') followed by an ID to the key, as identical keys in the same entity aren't originally supported.</div>
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
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>OnDestroy Function</b></span> <kbd  class="tooltip" data-tooltip="string">ondestroyfn</kbd> :
Name of the function to use from already parsed .as script files when entity is destroyed (killed) in any way. If the function belongs to namespace, you must use prefix with the namespace name (e.g. mynamespace::MyFunction) for the keyvalue.
</div>
<div class="entityentry commonkeys-checkbox" markdown="1">
<span style="color:#9fc5e8;"><b>Name</b></span> <kbd  class="tooltip" data-tooltip="target_source">targetname</kbd> :
Set name of {{ entname }} so other entities can trigger it to fire targets. Can be kill-targeted in which case all already running actions are terminated.
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : <span style="color:#9fc5e8;">multithreaded</span> : If set, a single multi_manager can have multiple instances. That means, it can be activated while already running, causing a temporary copy of it to be created and run on its own. It is worth remembering that if you have problems when attempting to trigger multi_manager again (in case all events were supposed to be completed before retriggering, but somehow multi_manager is still blocked), this key may help you fix an issue.</li>
</ul>
</div>
<div class="notices blue" markdown="1">Removing a multi_manager from the game while it is running results in it properly ceasing all of its triggering-actions. A running multi_manager entity cannot be stopped through other means than removing it.</div>
