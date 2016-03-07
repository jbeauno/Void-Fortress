using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class GameAudio : MonoBehaviour {

	public AudioMixer MixerMain;
	public CameraController Camera;

	void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {

        //part 1: Mix Music = f(camera.altitude)
        mixMusic();

        //todo: part 2: play fx .....        
	}


    private float getVolumeFromAltitude(float min, float max, float altitude)
    //min < max, min: 1..10;  max: 1..10; 
    //res : 0..-30
    {
        float res = -30;

        float ainterval = max - min;
        
        if (altitude > max)
            res = 0;
        else if (altitude >= min)
        {
            res = -10;
        }

        return res;
    }

    private void mixMusic()
    {
        //todo: eventuellement avec snapshop


        //altitude: 1 .. 10 
        //bells  10..7 
        //bass   3..1
        //drum   5..1


        float maxbell = 10;
        float minbell = 7;

        float maxbass = 3;
        float minbass = 1;

        float haxdrum = 5;
        float mindrum = 1;

        MixerMain.SetFloat("bells_volume", getVolumeFromAltitude(minbell, maxbell, Camera.altitude));

        MixerMain.SetFloat("bass_fx_volume", -80);
        MixerMain.SetFloat("drum_trad_volume", -80);


        //MixerMain.SetFloat("bass_fx_volume", getVolumeFromAltitude(minbass, maxbass, Camera.altitude));
        //MixerMain.SetFloat("drum_trad_volume", getVolumeFromAltitude(mindrum, haxdrum, Camera.altitude));
    }
}
