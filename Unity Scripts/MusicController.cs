using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioManager.LayersState layersState = new AudioManager.LayersState();
    AudioManager.Track selectedTrack;

    // Start is called before the first frame update
    void Start()
    {
        //Game starts with the 1st track and 1st layer playing;
        var initTrack = AudioManager.Track.TRACK1;
        selectedTrack = initTrack;
        AudioManager.SelectTrack(selectedTrack);
        layersState.Layer1 = AudioManager.Layer.ENABLED;
        AudioManager.UpdateLayersState(layersState);
        AudioManager.PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
            AudioManager.PlayMusic();
        
        if (Input.GetKeyDown("s"))
            AudioManager.StopMusic();
        
        if (Input.GetKeyDown("c"))
            ToggleChangeTrack();
        
        if (Input.GetKeyDown("1"))
            ToggleLayerState(ref layersState.Layer1);
        
        if (Input.GetKeyDown("2"))
            ToggleLayerState(ref layersState.Layer2);
        
        if (Input.GetKeyDown("3"))
            ToggleLayerState(ref layersState.Layer3);
        
        if (Input.GetKeyDown("4"))
            ToggleLayerState(ref layersState.Layer4);
        
        //if (Input.GetKeyDown("5"))
        //    ToggleLayerState(ref layersState.Layer5);
        
    }

    void ToggleLayerState (ref AudioManager.Layer layer){
        if (layer == AudioManager.Layer.DISABLED)
            layer = AudioManager.Layer.ENABLED;
        else 
            layer = AudioManager.Layer.DISABLED;
        AudioManager.UpdateLayersState(layersState);
        
    }

    void ToggleChangeTrack (){
        if(selectedTrack == AudioManager.Track.TRACK1)
            selectedTrack = AudioManager.Track.TRACK2;
        else
            selectedTrack = AudioManager.Track.TRACK1;
        AudioManager.SelectTrack(selectedTrack);
    }
}
