# blips-fmod-implementation
This repository contains the files created for the following Blips Blog tutorial:
[How to implement Blips game music packs in FMOD](https://blog.blips.fm/articles/how-to-implement-blips-music-packs-in-fmod).
Contains the tutorial's FMOD project and Unity Engine scripts.

**NOTE:** This project does not contain the audio files. Blips provides free music packs you can use with this project, though. To follow this tutorial, we recommend the use of a music "Pack M". You'll find a link to a Pack M we provide for free on the first part of the tutorial.

Place your audio files within the loop/magnet regions detailed in the tutorial. Depending on the music pack, you may need to adjust the region's handles to correctly wrap the layers beginning and end. To import the files, you can use the FMOD's "Audio Bin" window or directly place them on the timeline by drag and drop. To make your project ready for implementation make sure to build it by going to the "File” top menu and clicking “Build”. You may also want to check your build settings and target platforms on the FMOD Studio preferences.

## Scripts license
[MIT License](/Unity%20Scripts/LICENSE)
