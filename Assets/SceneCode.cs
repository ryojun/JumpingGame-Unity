using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCode : MonoBehaviour
{
    public GameObject HP1, HP2, HP3;
    // Start is called before the first frame update
    void Start()
    {
        HP1.SetActive(true);
        HP2.SetActive(true);
        HP3.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("HP") == 3)
        {
            HP1.SetActive(true);
            HP2.SetActive(true);
            HP3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("HP") == 2)
        {
            HP1.SetActive(true);
            HP2.SetActive(true);
            HP3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("HP") == 1)
        {
            HP1.SetActive(true);
            HP2.SetActive(false);
            HP3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("HP") <= 0)
        {
            HP1.SetActive(false);
            HP2.SetActive(false);
            HP3.SetActive(false);
        }
    }
}
