using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    public AudioSource coinFX;
    private CollectedInfo coins;

    // Start is called before the first frame update
    private void Start()
    {
       coins = GameObject.FindWithTag("LevelControl").GetComponent<CollectedInfo>();
    }

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        coins.coinCount++;
        Destroy(this.gameObject);
    }
}
