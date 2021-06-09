using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freshaircode : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 5 * Time.deltaTime);

        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
        if (PlayerPrefs.GetInt("Clear") == 1)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "HP")
        {
            Destroy(gameObject);
        }

    }
}
