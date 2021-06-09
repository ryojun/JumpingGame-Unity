using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCode : MonoBehaviour
{
    public GameObject FreshAir;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 2 * Time.deltaTime);

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

        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") + 1);
            Instantiate(FreshAir, new Vector3(transform.position.x-2, transform.position.y, 0), Quaternion.Euler(0, 0, 90));
        }
        if (coll.gameObject.tag == "HP")
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("HP", PlayerPrefs.GetInt("HP")-1);
            Debug.Log(PlayerPrefs.GetInt("HP"));
        }

    }

}
