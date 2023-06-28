using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject charModel;
    public Camera Camera;
    public GameObject LevelDis;
    public static bool  isCollided = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        Camera.GetComponent<Animator>().enabled = true;
        LevelDis.GetComponent<LevelDistance>().enabled = false;
        isCollided = true;
    }
}
