using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public float zPos = 57.25f;
    public bool creatingSection = false;
    public int secNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!creatingSection)
        {
            StartCoroutine(GenerateSection());
            creatingSection = true;
        }
        IEnumerator GenerateSection()
        {
            secNum = Random.Range(0, 3);
            Instantiate(section[secNum],new Vector3(0,0,zPos), Quaternion.identity);
            zPos += 57.25f;
            yield return new WaitForSeconds(2);
            creatingSection = false;
        }
    }
}
