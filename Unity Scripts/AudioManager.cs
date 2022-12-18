using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum Track
    {
        TRACK1,
        TRACK2,
        //TRACK3
    }

    public enum Layer
    {
        DISABLED,
        ENABLED
    }

    public class LayersState
    {
        public Layer Layer1;
        public Layer Layer2;
        public Layer Layer3;
        public Layer Layer4;
        //public Layer Layer5;
    }

    AudioManager instance;
    static FMOD.Studio.EventInstance music;


    void Awake() // Singleton
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
    }

    public static void PlayMusic()
    {
        music.start();
    }

    public static void StopMusic()
    {
        music.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }

    public static void SelectTrack(Track track)
    {
        music.setParameterByName("Track Select", (float)track);
    }

    public static void UpdateLayersState(LayersState layersState)
    {
        music.setParameterByName("Layer 1", (float)layersState.Layer1);
        music.setParameterByName("Layer 2", (float)layersState.Layer2);
        music.setParameterByName("Layer 3", (float)layersState.Layer3);
        music.setParameterByName("Layer 4", (float)layersState.Layer4);
        //music.setParameterByName("Layer 5", (float)layersState.Layer5);
    }

}
