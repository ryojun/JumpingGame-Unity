using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCode : MonoBehaviour
{

    float DelayFire = 0;
    int CountDonut;
    int CountIce;
    bool ShootRemit = true;
    public GameObject PlayScene;
    public GameObject OverScene;
    public GameObject MainChar;
    public AudioSource CoinSound;
    public AudioSource FrySound;
    public AudioSource backSound;
    public GameObject PointHide;
    float x = 0;
    float Donutx = 0;
    float Icex = 0;
    bool CharBool = true;
    public GameObject Fire;
    // Use this for initialization
    public GameObject CharCol;
    public GameObject gun;
    public Sprite IceProtect;
    public Sprite BacktoChar;
    public SpriteRenderer MainCharSprit;
    


    [Space(10)]
    public Text debugText;
    public Text debugText2;

    public Text timerText;
    public Text Test1;
    

    void Start()
    {
        PlayerPrefs.SetInt("Point", 0);
        PlayerPrefs.SetInt("Class", 1);
        OverScene.SetActive(false);
        MainCharSprit.sprite = BacktoChar;
    }

    // Update is called once per frame
    void Update()
    {

        if (CountIce >= PlayerPrefs.GetInt("AcIce"))
        {
            PlayerPrefs.SetInt("AcIce", CountIce);
        }
        if (CountDonut >= PlayerPrefs.GetInt("AcDonut"))
        {
            PlayerPrefs.SetInt("AcDonut", CountDonut);

        }
        if (PlayerPrefs.GetInt("ClearFunc") == 1)
        {
            CountDonut = 0;
            CountIce = 0;
            PlayerPrefs.SetInt("ClearFunc", 0);
        }

        if (PlayerPrefs.GetInt("HP") <= 0)
        {
            GameOver();
        }
        


        //if (MainChar.transform.position.y <= -3.4f || MainChar.transform.position.y > 3.5f)
        //{
        //    GameOver();
        //}

        if (PlayerPrefs.GetInt("Class") == 2)
        {
            if (x < 5)
            {

                Shoot();
                x += Time.deltaTime;
            }
            else
            {
                PlayerPrefs.SetInt("Class", 1);
                x = 0;
            }

        }

        if (Time.timeScale == 2)
        {
            if (Donutx < 5)
            {
                Donutx += Time.deltaTime;
            }
            else
            {
                Time.timeScale = 1;
                Donutx = 0;
            }
        }


        if (CharBool == false)
        {
            if (Icex < 5)
            {
                Icex += Time.deltaTime;
            }
            else
            {
                CharBool = true;
                CharCol.SetActive(true);
                MainCharSprit.sprite = BacktoChar;
                Icex = 0;
            }
        }


    }
    void OnCollisionEnter2D(Collision2D Item)
    {
        if (Item.gameObject.tag == "Ice")
        {
            CharCol.SetActive(false);
            gun.SetActive(false);
            CharBool = false;
            MainCharSprit.sprite = IceProtect;
            CountIce++;
        }
        if (Item.gameObject.tag == "Donut")
        {
            CountDonut++;
        }
        
    }

    //void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.gameObject.tag == "Point")
    //    {
    //        Destroy(coll.gameObject);
    //        CoinSound.Play();
    //        PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") + 1);
    //    }


       
    //}
    void GameOver()
    {
        Application.LoadLevel(2);
    }
    public void Shoot()
    {
        if (DelayFire <= 0.1)
        {
            if (ShootRemit == true)
            {
                Instantiate(Fire, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.Euler(0, 0, 90));
                ShootRemit = false;
            }


            DelayFire += Time.deltaTime;

        }
        else
        {
            DelayFire += Time.deltaTime;

        }
        if (DelayFire > 1)
        {
            DelayFire = 0;
            ShootRemit = true;
        }

    }
    IEnumerator MakeClound1()
    {
        while (true)
        {
            Instantiate(Fire, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.identity);
            Vector3 StartPos = gun.transform.position;
            Vector3 direction = transform.right * 2;
            float distance = 100;
            Debug.DrawRay(StartPos, direction, Color.red, 0.2f);
            RaycastHit2D hit = Physics2D.Raycast(StartPos, direction, distance);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "gas")
                    Destroy(hit.collider.gameObject);
                if (hit.collider.gameObject.tag == "virus")
                    Destroy(hit.collider.gameObject);
            }
        }
    }
}
