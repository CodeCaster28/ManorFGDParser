---
title: info_compile_parameters
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Set various map compile parameters without need of using batch file for advanced compilation settings. Makes compile settings inseparable from map, very useful when multiple mappers are involved in creation process. No extra actions are needed- place entity anywhere, tweak desired keyvalues and during compile process all parameters will be applied automatically. Each keyvalue sets parameter for compilers, in spawnflags all parameters for each compilers (CSG, BSP, VIS, RAD) can be disabled- with separated option for parameters shared bewteen compilers. See official ZHLT parameters documentation: [ZHLT Command Reference](http://zhlt.info/command-reference.html). You can also check my advanced lightning tutorial that covers basics of compile process and explains most important parameters: Advanced Compilation.</div>
</div>
</div>
###Keyvalues
<hr>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Verbose messages?</b></span> <kbd  class="tooltip" data-tooltip="choices">verbose</kbd> :
Compile with verbose messages.
<div class="accordion">
<input type="checkbox" id="accordion-1" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-1">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't show tool configuration information?</b></span> <kbd  class="tooltip" data-tooltip="choices">noinfo</kbd> :
Do not show tool configuration information.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't generate compile log file?</b></span> <kbd  class="tooltip" data-tooltip="choices">nolog</kbd> :
Don't generate the compile logfiles.
<div class="accordion">
<input type="checkbox" id="accordion-3" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-3">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Developer message level</b></span> <kbd  class="tooltip" data-tooltip="choices">dev</kbd> :
Compile with developer message.
<div class="accordion">
<input type="checkbox" id="accordion-4" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-4">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : None</li>
<li><b>1 </b> : Error</li>
<li><b>2 </b> : Warning</li>
<li><b>3 </b> : Info</li>
<li><b>4 </b> : Fluff</li>
<li><b>5 </b> : Spam</li>
<li><b>6 </b> : Mega spam</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Estimate compile times?</b></span> <kbd  class="tooltip" data-tooltip="choices">estimate</kbd> :
Display estimated time during compile.
<div class="accordion">
<input type="checkbox" id="accordion-5" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-5">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Display statistics charts?</b></span> <kbd  class="tooltip" data-tooltip="choices">chart</kbd> :
Display bsp statitics.
<div class="accordion">
<input type="checkbox" id="accordion-6" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-6">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CPU thread count (0 for auto/max)</b></span> <kbd  class="tooltip" data-tooltip="integer">threads</kbd> :
Manually specify the number of threads to run.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>CPU process priority</b></span> <kbd  class="tooltip" data-tooltip="choices">priority</kbd> :
Run program an altered priority level.
<div class="accordion">
<input type="checkbox" id="accordion-7" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-7">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>1 </b> : Low</li>
<li><b>2 </b> : Normal</li>
<li><b>3 </b> : High</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Texture data memory (KiB)</b></span> <kbd  class="tooltip" data-tooltip="integer">texdata</kbd> :
Alter maximum texture memory limit (in KB).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Lighting data memory (KiB)</b></span> <kbd  class="tooltip" data-tooltip="integer">lightdata</kbd> :
Set custom lightdata maximum (MB).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>--- Perform CSG stage? ---</b></span> <kbd  class="tooltip" data-tooltip="choices">csg</kbd> :
Set to compile CSG.
<div class="accordion">
<input type="checkbox" id="accordion-8" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-8">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
<li><b>2 </b> : Yes, entity updates only mode</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>No WAD textures? (Embed textures into BSP.)</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_nowadtextures</kbd> :
Include all used textures into bsp.
<div class="accordion">
<input type="checkbox" id="accordion-9" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-9">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable clipping hull generation?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_noclip</kbd> :
Don't process the clipping hull (not for final runs).
<div class="accordion">
<input type="checkbox" id="accordion-10" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-10">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Strip redundant clip nodes? (Economy mode.)</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_clipeconomy</kbd> :
Disables redundant clipnode stripping.
<div class="accordion">
<input type="checkbox" id="accordion-11" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-11">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Clipping hull type</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_cliptype</kbd> :
Select the clip hull generation method.
<div class="accordion">
<input type="checkbox" id="accordion-12" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-12">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : Smallest</li>
<li><b>1 </b> : Normalized</li>
<li><b>2 </b> : Simple (most compact)</li>
<li><b>3 </b> : Precise (recommended)</li>
<li><b>4 </b> : Legacy</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Custom hull file</b></span> <kbd  class="tooltip" data-tooltip="string">csg_hullfile</kbd> :
Load a custom hullfile.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable sky clipping?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_noskyclip</kbd> :
Disable automatic clipping of SKY brushes.
<div class="accordion">
<input type="checkbox" id="accordion-13" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-13">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum brush face surface area before it is discarded</b></span> <kbd  class="tooltip" data-tooltip="string">csg_tiny</kbd> :
Minimum brush face surface area before it is discarded.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Threshold to warn about overlapping brushes</b></span> <kbd  class="tooltip" data-tooltip="string">csg_brushunion</kbd> :
Threshold to warn about overlapping brushes.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>NULL texture substitutions file</b></span> <kbd  class="tooltip" data-tooltip="string">csg_nullfile</kbd> :
Specify a file containing a list of entities to retexture with the NULL texture.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>WAD configuration file</b></span> <kbd  class="tooltip" data-tooltip="string">csg_wadcfgfile</kbd> :
Manually specifies the path to the wad.cfg file.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>WAD configuration name</b></span> <kbd  class="tooltip" data-tooltip="string">csg_wadcfgname</kbd> :
Use a custom wad configuration in the wad.cfg custom wad configuration file.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>WAD auto detect?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_wadautodetect</kbd> :
Enable automatic wad detection.
<div class="accordion">
<input type="checkbox" id="accordion-14" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-14">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't strip null texture faces?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_nonulltex</kbd> :
Disables NULL texture stripping.
<div class="accordion">
<input type="checkbox" id="accordion-15" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-15">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Strip trigger texture faces?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_nullifytrigger</kbd> :
Set all trigger textures to NULL.
<div class="accordion">
<input type="checkbox" id="accordion-16" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-16">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't optimize engine light entities?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_nolightopt</kbd> :
Remove light duplicates to save memory.
<div class="accordion">
<input type="checkbox" id="accordion-17" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-17">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't convert game_text from ANSI to UTF-8 format?</b></span> <kbd  class="tooltip" data-tooltip="choices">csg_notextconvert</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-18" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-18">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Scale the world (USE AT OWN RISK!)</b></span> <kbd  class="tooltip" data-tooltip="string">csg_scale</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>--- Perform BSP stage? ---</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp</kbd> :
Set to compile CSG.
<div class="accordion">
<input type="checkbox" id="accordion-19" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-19">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
<li><b>2 </b> : Yes, leak only mode</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Face subdivide size (64-528)</b></span> <kbd  class="tooltip" data-tooltip="integer">bsp_subdivide</kbd> :
Sets the face subdivide size.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Maximum portal node size (64-1024)</b></span> <kbd  class="tooltip" data-tooltip="integer">bsp_maxnodesize</kbd> :
Sets the maximum portal node size.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't break edges on t-junctions?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_notjunc</kbd> :
Don't break edges on t-junctions (not for final runs).
<div class="accordion">
<input type="checkbox" id="accordion-20" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-20">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't smooth brinks?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_nobrink</kbd> :
Disables feature that fixes brinks error. You need to have strong reasons for disabling it.
<div class="accordion">
<input type="checkbox" id="accordion-21" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-21">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't process the clipping hull?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_noclip</kbd> :
Don't process the clipping hull (not for final runs).
<div class="accordion">
<input type="checkbox" id="accordion-22" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-22">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't fill outside? (Leaks will be masked.)</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_nofill</kbd> :
Don't fill outside- will mask LEAKs (not for final runs).
<div class="accordion">
<input type="checkbox" id="accordion-23" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-23">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't fill empty spaces?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_noinsidefill</kbd> :
Disable automatic empty areas filling.
<div class="accordion">
<input type="checkbox" id="accordion-24" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-24">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't optimize planes?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_noopt</kbd> :
Skip plane optimization on output.
<div class="accordion">
<input type="checkbox" id="accordion-25" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-25">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't optimize clip nodes?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_noclipnodemerge</kbd> :
When used, disables clipnode merging, which increased clipnodes memory.
<div class="accordion">
<input type="checkbox" id="accordion-26" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-26">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't strip NULL textures?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_nonulltex</kbd> :
Disables NULL texture stripping.
<div class="accordion">
<input type="checkbox" id="accordion-27" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-27">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes (not recommended)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't generate hull 2? (Big monsters & pushable fall out map!)</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_nohull2</kbd> :
This one is mystery for me.
<div class="accordion">
<input type="checkbox" id="accordion-28" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-28">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Show portal boundaries in PTS file?</b></span> <kbd  class="tooltip" data-tooltip="choices">bsp_viewportal</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-29" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-29">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>--- Perform VIS stage? ---</b></span> <kbd  class="tooltip" data-tooltip="choices">vis</kbd> :
Set to compile VIS.
<div class="accordion">
<input type="checkbox" id="accordion-30" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-30">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
<li><b>2 </b> : Yes, fast mode</li>
<li><b>3 </b> : Yes, full mode</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>--- Perform RAD stage? ---</b></span> <kbd  class="tooltip" data-tooltip="choices">rad</kbd> :
Set to compile RAD.
<div class="accordion">
<input type="checkbox" id="accordion-31" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-31">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
<li><b>2 </b> : Yes, fast mode</li>
<li><b>3 </b> : Yes, extra mode</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>WAD search directory</b></span> <kbd  class="tooltip" data-tooltip="string">rad_waddir</kbd> :
Directory to search for WAD. Leave so it pick the same WADs as map file.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Use visibility matrix?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_vismatrix</kbd> :
Usage of vismatrix.
<div class="accordion">
<input type="checkbox" id="accordion-32" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-32">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : Normal (65,536 patch limit)</li>
<li><b>1 </b> : Sparse</li>
<li><b>2 </b> : None (slowest but most accurate lighting)</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Bounces</b></span> <kbd  class="tooltip" data-tooltip="integer">rad_bounce</kbd> :
Set number of radiosity bounces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ambient world light (R G B)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_ambient</kbd> :
Set ambient world light (0.0 to 1.0, r g b).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Light clipping threshold (-1 for none)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_limiter</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Circus mode?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_circus</kbd> :
Enable 'circus' mode for locating unlit lightmaps.
<div class="accordion">
<input type="checkbox" id="accordion-33" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-33">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable sunlight spread angles?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_nospread</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-34" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-34">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable opaque light flags?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_nopaque</kbd> :
Disable all entities using zhlt_lightflags 2 to block light.
<div class="accordion">
<input type="checkbox" id="accordion-35" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-35">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Smoothing threshold for blending (In degrees)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_smooth</kbd> :
Set smoothing threshold for blending (in degrees).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Smoothing threshold between different textures</b></span> <kbd  class="tooltip" data-tooltip="string">rad_smooth2</kbd> :

</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Patch size for normal textures</b></span> <kbd  class="tooltip" data-tooltip="string">rad_chop</kbd> :
Set radiosity patch size for normal textures.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Patch size for texture light faces</b></span> <kbd  class="tooltip" data-tooltip="string">rad_texchop</kbd> :
Set radiosity patch size for texture light faces.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Scale patches with texture scale?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_notexscale</kbd> :
Do not scale radiosity patches with texture scale.
<div class="accordion">
<input type="checkbox" id="accordion-36" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-36">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>1 </b> : No</li>
<li><b>-1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Patch subdivide?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_subdivide</kbd> :
Sets the face subdivide size.
<div class="accordion">
<input type="checkbox" id="accordion-37" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-37">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Lighting threshold before blackness</b></span> <kbd  class="tooltip" data-tooltip="string">rad_coring</kbd> :
Set lighting threshold before blackness.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Direct lighting threshold</b></span> <kbd  class="tooltip" data-tooltip="string">rad_dlight</kbd> :
Set direct lighting threshold.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Direct lighting scale</b></span> <kbd  class="tooltip" data-tooltip="string">rad_dscale</kbd> :
Set direct lighting scale.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable interpolation? (Nearest point instead.)</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_nolerp</kbd> :
Disable three multi-point interpolation for radiosity patch blending, use nearest point sample instead.
<div class="accordion">
<input type="checkbox" id="accordion-38" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-38">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global fade (Larger values = shorter lights)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_fade</kbd> :
Set global fade (larger values = shorter lights).
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global gap distance for texture lights</b></span> <kbd  class="tooltip" data-tooltip="string">rad_texlightgap</kbd> :
Pushes light from texture lights by specified units value, what removes "light bleeding" problem.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global light scaling</b></span> <kbd  class="tooltip" data-tooltip="string">rad_scale</kbd> :
Set global light scaling value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Per-colour light scaling (R G B)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_colourscale</kbd> :
Sets different lightscale values for r, g ,b.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Global gamma</b></span> <kbd  class="tooltip" data-tooltip="string">rad_gamma</kbd> :
Set global gamma value.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Per-colour gamma (R G B)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_colourgamma</kbd> :
Sets different gamma values for r, g, b.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Ambient sunlight shade contribution</b></span> <kbd  class="tooltip" data-tooltip="string">rad_sky</kbd> :
Set ambient sunlight contribution in the shade outside.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Light textures file</b></span> <kbd  class="tooltip" data-tooltip="string">rad_lights</kbd> :
Manually specify a lights.rad file to use.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Disable sky light being global?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_noskyfix</kbd> :
Disable light_environment being global.
<div class="accordion">
<input type="checkbox" id="accordion-39" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-39">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Use/create an incremental transfer list file?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_incremental</kbd> :
Use or create an incremental transfer list file.
<div class="accordion">
<input type="checkbox" id="accordion-40" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-40">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Dump light patches to a file for debugging?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_dump</kbd> :
Dumps light patches to a file for RAD debugging info.
<div class="accordion">
<input type="checkbox" id="accordion-41" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-41">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Adds noise, independent colours, for dithering (R G B)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_colourjitter</kbd> :
Adds noise, monochromatic, for dithering.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Adds noise, monochromatic, for dithering (R G B)</b></span> <kbd  class="tooltip" data-tooltip="string">rad_jitter</kbd> :
Adds noise, independent colours, for dithering.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Enables custom shadows with bounce light?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_customshadowwithbounce</kbd> :
Enable custom shadows for bounced light.
<div class="accordion">
<input type="checkbox" id="accordion-42" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-42">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Enable RGB transfers? (For custom shadows.)</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_rgbtransfers</kbd> :
Enables RGB Transfers (for custom shadows).
<div class="accordion">
<input type="checkbox" id="accordion-43" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-43">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Minimum final light (0-255)</b></span> <kbd  class="tooltip" data-tooltip="integer">rad_minlight</kbd> :
Use to determine minimal lightning level for this map, in a range from 0 to 255.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compress transfers?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_compresstransfers</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-44" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-44">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : 32-bit</li>
<li><b>1 </b> : 16-bit</li>
<li><b>2 </b> : 8-bit</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Compress RGB transfers?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_compressrgbtransfers</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-45" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-45">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : 96-bit</li>
<li><b>1 </b> : 48-bit</li>
<li><b>2 </b> : 32-bit</li>
<li><b>3 </b> : 24-bit</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Smooth skylight?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_softsky</kbd> :
Makes better light_environment diffusion.
<div class="accordion">
<input type="checkbox" id="accordion-46" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-46">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ] : Choice_Description_here</li>
<li><b>-1 </b> : No : Choice_Description_here</li>
<li><b>1 </b> : Yes : Choice_Description_here</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Thickness of translucent faces</b></span> <kbd  class="tooltip" data-tooltip="string">rad_depth</kbd> :
Controls thickness tolerance of the walls whose are affected by info_translucent entity.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Remove the black areas around opaque entities?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_blockopaque</kbd> :
Disabling it stop preventing black areas on opaque entities from leaking out.
<div class="accordion">
<input type="checkbox" id="accordion-47" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-47">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't load textures?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_notextures</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-48" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-48">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Reflection gamma</b></span> <kbd  class="tooltip" data-tooltip="string">rad_texreflectgamma</kbd> :
Normally, the surface hit by bounced light has gamma value dependent on that light. It is set to 1.76 by default, and can be customized by this command.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Reflection scale</b></span> <kbd  class="tooltip" data-tooltip="string">rad_texreflectscale</kbd> :
Normally, the bounced light brightness depends on texture of the surface from which this light is bouncing. It's set to 0.7 by default, and it's fully customizable by parameter of this command.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Enlarge light map sample to blur the light map</b></span> <kbd  class="tooltip" data-tooltip="string">rad_blur</kbd> :
Controls shadow sharpness. The higher value is, the more blurred and less blocky shadows are.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't fix pointy texture lights?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_noemitterrange</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-49" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-49">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Don't fix wall bleeding problem for large blur value?</b></span> <kbd  class="tooltip" data-tooltip="choices">rad_nobleedfix</kbd> :

<div class="accordion">
<input type="checkbox" id="accordion-50" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-50">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>0 </b> : [ Unset ]</li>
<li><b>-1 </b> : No</li>
<li><b>1 </b> : Yes</li>
</ul>
</div>
</div>
</div>
###Flags
<hr>
<div class="entityflags">
<ul>
<li class="imagepadding" markdown="1"><b>1 </b> : Ignore shared settings : Ignore parameters shared between compilers.</li>
<li class="imagepadding" markdown="1"><b>2 </b> : Ignore CSG settings : Ignore CSG parameters.</li>
<li class="imagepadding" markdown="1"><b>4 </b> : Ignore BSP settings : Ignore BSP parameters.</li>
<li class="imagepadding" markdown="1"><b>8 </b> : Ignore VIS settings : Ignore VIS parameters.</li>
<li class="imagepadding" markdown="1"><b>16 </b> : Ignore RAD settings : Ignore RAD parameters.</li>
</ul>
</div>
