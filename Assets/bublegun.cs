using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bublegun : MonoBehaviour
{
    
    void Update()
    {
        if (transform.position.x < 16)
            transform.position += transform.up * -Time.deltaTime * 2;
        else
            Destroy(gameObject);
        if (PlayerPrefs.GetInt("Clear") == 1)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "gas")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") + 1);
        }
        if (coll.gameObject.tag == "virus")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") + 1);
        }
    }
}
