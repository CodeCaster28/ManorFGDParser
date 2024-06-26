---
title: info_texlights
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">This is a compiler-specific entity used to allow textures to emit light, which provides a more realistically looking effect than point light sources. To use this entity, simply place it anywhere in your map, open its properties, disable smart edit mode when using Valve Hammer Editor and add custom keyvalues, whereas the key's name be the name of the texture to emit light (case-insensitive) and the value be the amount of red, green and blue color from '0' (None) to '255' (Full) and the brightness, separated by spaces and in that order. A valid keyvalue-pair could look like so: "+0~LIGHT6A" "255 0 0 2000". Note that texture lights tend to be less bright than point light sources. As a rule of thumb, give ten times the brightness you would give a point light source. For every 16*16 pixels of the texture occurring in your map, one light will be rendered. As a result, faces which have been scaled down produce more light and faces which have been scaled up produce less light.</div>
</div>
</div>
</div>
