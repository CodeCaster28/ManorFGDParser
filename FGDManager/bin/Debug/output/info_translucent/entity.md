---
title: info_translucent
---
<div>{% set entname = page.title|raw %}</div>
<div class="container previewimg">
<div class="columns">
<div class="imagepadding column col-auto" markdown="1">![](preview.png)</div>
<div class="column entityentry" markdown="1">Allows to customize received color on textures depending on lights sources behind and in front of them. It's perfect for materials like fabric, coarse glass, and other textures that may pass light through. Imagine a well-lit room with a window at night. The texture is brighter when we looking at window from the outside of building, and it's receive darker colors when we looking at it from inside of the room. Entity gives natural feel and it's perfect for making translucent textures. To use info_translucent, simply place it anywhere in your map, open its properties, disable smart edit mode when using Valve Hammer Editor and add custom keyvalues, where key is a name of texture, and the value is amount of translucency from 0.0 (normal light) to 1.0 (100% light receiving from back). It is said that there is support for custom color parameters (R G B), but I never managed to get it works. Note: walls must not be thicker than 2 units, unless command "-depth x" is used, where 'x' is maximum thickness (default 2).</div>
</div>
</div>
</div>
