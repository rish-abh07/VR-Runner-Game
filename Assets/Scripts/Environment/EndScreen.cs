using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject LiveCoinCollector;
    public GameObject LiveDisCal;
    public GameObject EndCoinInfo;
    public GameObject EndDisInfo;
    public GameObject EndPanel;
    public GameObject EndFade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ObstacleCollision.isCollided)
        {
            StartCoroutine(CollisionDone());
        }
        
    }
    IEnumerator CollisionDone ()
    {
        yield return new WaitForSeconds(1.5f);
        LiveCoinCollector.SetActive(false);
        LiveDisCal.SetActive(false);
        EndCoinInfo.GetComponent<Text>().text = CollectedInfo.coinCount.ToString();
        EndDisInfo.GetComponent<Text>().text = LevelDistance.dis.ToString();
        EndPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        EndFade.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");

        
    }
}
