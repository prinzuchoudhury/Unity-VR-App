using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggered : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip coin_sound;
    AudioSource audio;
    public GameObject red_splash_effect;
    public GameObject skyblue_splash_effect;
    public GameObject yellow_splash_effect;

   
    public float VolumeScale = 1.0f;

   
    void Start()
    {

        audio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider cd)
    {

        if (cd.gameObject.tag == "Box" ){
            
            Instantiate(red_splash_effect, cd.gameObject.transform.position, cd.gameObject.transform.rotation);
            
            Destroy(cd.gameObject);
            audio.PlayOneShot(coin_sound, VolumeScale);
            Debug.Log("You got hit by christmas box ");
        }

        else if (cd.gameObject.tag == "Star"){
            
            Instantiate(skyblue_splash_effect, cd.gameObject.transform.position, cd.gameObject.transform.rotation);
            
            Destroy(cd.gameObject);
            audio.PlayOneShot(coin_sound, VolumeScale);
            Debug.Log("You got hit by some star ");
        }

        else if (cd.gameObject.tag == "lol"){
            
            Instantiate(yellow_splash_effect, cd.gameObject.transform.position, cd.gameObject.transform.rotation);
            
            Destroy(cd.gameObject);
            audio.PlayOneShot(coin_sound, VolumeScale);
            Debug.Log("You got hit by some another chrismas star");
        }

    }
}
