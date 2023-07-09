---
title: trigger_vote
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">The trigger_vote entity, when triggered, throws a vote window at the players where they can select either 'Yes' or 'No'. The question of the vote and the time till it will be evaluated can be customized.</div>
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
Set name of {{ entname }} so other entities can trigger it to start vote. Every trigger use-type works uniformly. Can be kill-targeted.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Vote Message</b></span> <kbd  class="tooltip" data-tooltip="String">message</kbd> :
Specify the question/message to vote on. You have to do line breaks ('\n') manually!
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Time To Vote (Seconds)</b></span> <kbd  class="tooltip" data-tooltip="integer">frags</kbd> :
Time, in seconds, till the vote result will be evaluated and the result's according target is triggered. This time is not skipped if the result is already certain for the amount of players currently on the server.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Percentage needed</b></span> <kbd  class="tooltip" data-tooltip="integer">health</kbd> :
Specify the percentage of players who have to vote 'Yes' in order for its according target to be fired. Players who do not vote are ignored, meaning their voice counts as neither a 'No' nor a 'Yes' vote.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Yes Target</b></span> <kbd  class="tooltip" data-tooltip="String">target</kbd> :
Entity to trigger when the vote's result is 'Yes'. Trigger use-type is 'On'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>No Target</b></span> <kbd  class="tooltip" data-tooltip="String">netname</kbd> :
Entity to trigger when the vote's result is 'No'. Trigger use-type is 'On'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>No Vote Target</b></span> <kbd  class="tooltip" data-tooltip="String">noise</kbd> :
Entity to trigger when nobody voted on anything. Trigger use-type is 'On'.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Yes string (optional)</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszYesString</kbd> :
If specified, overrides default 'Yes' button text to the one typed here.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>No string (optional)</b></span> <kbd  class="tooltip" data-tooltip="string">m_iszNoString</kbd> :
If specified, overrides default 'No' button text to the one typed here.
</div>
<div class="notices blue" markdown="1">Unlike other entities, trigger_vote sends 'On' output instead of 'Toggle'.</div>
