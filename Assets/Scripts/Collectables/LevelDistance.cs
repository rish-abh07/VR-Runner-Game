using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public static int dis = 0;
    public GameObject distanceText;
    public bool addingDis = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!addingDis)
        {
            
            addingDis = true;
            StartCoroutine(AddingDistance());
        }
    }
    IEnumerator AddingDistance()
    {
        dis++;
        distanceText.GetComponent<Text>().text = dis.ToString();
        yield return new WaitForSeconds(0.35f);
        addingDis = false;
    }
}
