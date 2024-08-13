# 7 Days to Die Mod - Phantom Silence

[![nexus-mods-collection-immersive-hud](https://img.shields.io/badge/Nexus%20Mods%20Collection-Immersive%20HUD%20-orange?style=flat-square&logo=spinrilla)](https://next.nexusmods.com/7daystodie/collections/epfqzi) [![nexus-mods-page](https://img.shields.io/badge/Nexus%20Mod-Phantom%20Silence%20-orange?style=flat-square&logo=spinrilla)](https://www.nexusmods.com/7daystodie/mods/5749) [![github-repository](https://img.shields.io/badge/GitHub-Repository-green?style=flat-square&logo=github)](https://github.com/rdok/7dtd_phantom_silence)

> **Phantom Silence:** Turns off creepy ambient noises during nighttime and day-night transitions.
> **EAC Caveat:** This mod uses custom code that is not compatible with Easy Anti-Cheat (EAC).

[![Phantom Silence Showcase](https://github.com/rdok/7dtd_phantom_silence/blob/main/documentation/showcase.jpg?raw=true)](https://www.nexusmods.com/7daystodie/mods/5749)

## Features
- Turns off creepy ambient noises during nighttime and day-night transitions.
- 7dtd Version: 1.0 (b333)
- Install with [Vortex](https://www.nexusmods.com/about/vortex/).

## Changelog
### v1.0.0 13-Aug-24
- Turns off `a_daybreak_oneshot[1-6]`, `a_nightfall_oneshot` and `a_daybreak_oneshot` audio clips.

## UA Testing
```
# Creepy (annoying) sounds
settime night
# Break day
settime 3980
# Night fall
settime 21980
```

## Sources
- Cross verified between code & old findings from other people: [https://community.7daystodie.com/topic/4388-how-to-remove-bg-spooky-music-at-night/](https://community.7daystodie.com/topic/4388-how-to-remove-bg-spooky-music-at-night/)