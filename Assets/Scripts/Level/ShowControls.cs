using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public GameObject buttons;
    // Start is called before the first frame update
    void Start()
    {
        if(SystemInfo.deviceType == DeviceType.Handheld)
        {
            buttons.SetActive(true);
        }
    }

    // Update is called once per frame
  
}
