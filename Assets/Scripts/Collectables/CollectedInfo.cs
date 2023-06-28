using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedInfo : MonoBehaviour
{
    public int  coinCount;
    public GameObject coinCountDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        coinCountDisplay.GetComponent<Text>().text = coinCount.ToString();
    }
}
