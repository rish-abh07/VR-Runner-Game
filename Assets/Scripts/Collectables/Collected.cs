using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    public AudioSource coinFX;
   

    // Start is called before the first frame update
    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectedInfo.coinCount++;
        Destroy(this.gameObject);
    }
}
