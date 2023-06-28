using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCounter : MonoBehaviour
{
    public GameObject Countdown3;
    public GameObject Countdown2;
    public GameObject Countdown1;
    public GameObject CountdownGo;
    public GameObject Fade;
    public AudioSource readyFX;
    public AudioSource goFX;
    private PlayerMove plMove;

    // Start is called before the first frame update
    void Start()
    {
        plMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        StartCoroutine(CountSequence());
    }

    // Update is called once per frame
   IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        Countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        Countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        CountdownGo.SetActive(true);
        goFX.Play();
        plMove.canMove = true;
    }
}
