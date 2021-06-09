using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class maincode : MonoBehaviour
{
    public Rigidbody2D MainCha;
    float upForce = 30f;
    public Text PointText;
    float TimeCount = 0;
    float Clearx = 5;
    public GameObject Turebo;
    public SpriteRenderer player;
    public Sprite char1, char2;
    public AudioSource FrySound;
    public AudioSource backSound;

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("Clear", 0);
        PlayerPrefs.SetInt("HP", 3);

    }

    // Update is called once per frame
    void Update()
    {
        
        PointText.text = "" + PlayerPrefs.GetInt("Point");
        //LastPoint.text = "" + PlayerPrefs.GetInt("Point");
        //HightPointText.text = "" + PlayerPrefs.GetInt("HightPoint");

        Timer();
        TouchFry();

        if (Clearx < 1)
        {
            PlayerPrefs.SetInt("Clear", 1);
            Clearx += Time.deltaTime;
        }
        else
            PlayerPrefs.SetInt("Clear", 0);


        PlayerPrefs.GetInt("Point");

        if (PlayerPrefs.GetInt("Point") > PlayerPrefs.GetInt("HightPoint"))
        {
            PlayerPrefs.SetInt("HightPoint", PlayerPrefs.GetInt("Point"));
        }
    }

    void Timer()
    {
        TimeCount += Time.deltaTime;
    }
    void TouchFry()
    {
        //if (Input.touchCount == 1)
        //{

        //    MainCha.AddForce(Vector3.up * upForce);
        //}
        if (Input.GetKey("space"))
        {
            MainCha.AddForce(Vector3.up * upForce);
            Turebo.SetActive(true);
            player.sprite = char1;
            //FrySound.Play();
        }
        else
        {
            Turebo.SetActive(false);
            player.sprite = char2;
        }
        
    }

 
    public void HomeButton()
    {
        Application.LoadLevel(0);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
