using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaAudioController : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {   
        audioSource=GetComponent<AudioSource>();      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision){
        Debug.Log("polla");
        audioSource.Play();  
    }   
}
