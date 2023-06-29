using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySection : MonoBehaviour
{
    public GameObject[] section;
    public string parentName;
    // Start is called before the first frame update
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    // Update is called once per frame
   IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(30);
            if (parentName == "Section (Clone)")
            {

                Destroy(gameObject);
            }
    }
}
