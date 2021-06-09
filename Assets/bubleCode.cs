using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubleCode : MonoBehaviour
{

    float GameTime = 0;
    float SpeedTime = 0;
    int SpeedCount = 0;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(transform.position.x + Random.Range(21, 30), transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;
        Destroy();


        if (GameTime <= 20)
        {
            transform.Translate(Vector3.left * Time.deltaTime * GameTime);
        }
        else if (GameTime > 20)
        {
            transform.Translate(Vector3.left * Time.deltaTime * SpeedCount);
        }

        if (PlayerPrefs.GetInt("Clear") == 1)
        {
            Destroy(gameObject);

        }


    }
    void Destroy()
    {
        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
    void SpeedUp()
    {
        SpeedTime += Time.deltaTime;
        SpeedTime = (int)SpeedTime % 10;
        if (SpeedTime == 10)
        {
            SpeedCount++;

        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Point")
        {
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("Class", 2);

        }


    }
}
