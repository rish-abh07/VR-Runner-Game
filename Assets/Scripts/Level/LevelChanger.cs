using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel()
    {
        SceneManager.LoadScene("MainGame");
    }
}
