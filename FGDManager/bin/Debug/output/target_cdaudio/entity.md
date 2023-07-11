---
title: target_cdaudio
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Entity that, when triggered, play a music track chosen from predefined list of tracks.</div>
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
Set name of {{ entname }} so other entities can trigger it to play audio track. Every trigger use-type works uniformly. Kill-targeting this entity will not stop audio from playing.
</div>
<div class="entityentry" markdown="1">
<span style="color:#9fc5e8;"><b>Track #</b></span> <kbd  class="tooltip" data-tooltip="choices">health</kbd> :
Track to play. Pick 'Stop' to stop any currently playing track. Tracks are located in "media" folder, options starts from 'Track 2' (Half-Life0.mp3) and ends at 'Track 28' (Half-Life27.mp3). Tracks number 1, 29 and 30 are empty.
<div class="accordion">
<input type="checkbox" id="accordion-2" name="accordion-checkbox" hidden>
<label class="accordion-header" for="accordion-2">
<i class="icon icon-arrow-right mr-1"></i>
Choices:
</label>
<div class="accordion-body">
<ul>
<li><b>-1 </b> : Stop</li>
<li><b>1 </b> : Track 1</li>
<li><b>2 </b> : Track 2</li>
<li><b>3 </b> : Track 3</li>
<li><b>4 </b> : Track 4</li>
<li><b>5 </b> : Track 5</li>
<li><b>6 </b> : Track 6</li>
<li><b>7 </b> : Track 7</li>
<li><b>8 </b> : Track 8</li>
<li><b>9 </b> : Track 9</li>
<li><b>10 </b> : Track 10</li>
<li><b>11 </b> : Track 11</li>
<li><b>12 </b> : Track 12</li>
<li><b>13 </b> : Track 13</li>
<li><b>14 </b> : Track 14</li>
<li><b>15 </b> : Track 15</li>
<li><b>16 </b> : Track 16</li>
<li><b>17 </b> : Track 17</li>
<li><b>18 </b> : Track 18</li>
<li><b>19 </b> : Track 19</li>
<li><b>20 </b> : Track 20</li>
<li><b>21 </b> : Track 21</li>
<li><b>22 </b> : Track 22</li>
<li><b>23 </b> : Track 23</li>
<li><b>24 </b> : Track 24</li>
<li><b>25 </b> : Track 25</li>
<li><b>26 </b> : Track 26</li>
<li><b>27 </b> : Track 27</li>
<li><b>28 </b> : Track 28</li>
<li><b>29 </b> : Track 29</li>
<li><b>30 </b> : Track 30</li>
</ul>
</div>
</div>
</div>
