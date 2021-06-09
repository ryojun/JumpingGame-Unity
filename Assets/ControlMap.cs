using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlMap : MonoBehaviour {
    
    float SYTimer;
    int RandomCloud;
    int RandomDonut;
    int RandomIce;
    int RandomBlock;
    int RandomeCSpace, RandomeCSpace2;
    public GameObject Bird,Bee;
    public GameObject upBlock, upBlock1, upBlock2;
    public GameObject DownBlock, DownBlock1;
    public GameObject Coin;
    public GameObject Ice1,Ice2,Ice3,Ice4;
    public GameObject Clound1, Clound2, Clound3, Clound4, Clound5;

    public GameObject Tabasgo;
    public GameObject Donut1,Donut2,Donut3;
   
    int GameLevel;
   

    int MakeSpeed = 10;

    void Start()
    {
        GameStop();


    }


    void Update()
    {
        
        if (SYTimer >= PlayerPrefs.GetInt("AcTime"))
        {
            PlayerPrefs.SetInt("AcTime", (int)SYTimer);
        }
        

        if(PlayerPrefs.GetInt("Again") == 1)
        {
            GameStop();
            SYTimer = 0;
            PlayerPrefs.SetInt("Again", 0);
        }
       
        SYTimer += Time.deltaTime;

        if (SYTimer<=30)
        {
            
            MakeSpeed = Random.Range(8,10);
        }
        else if (SYTimer > 30 && SYTimer <= 50)
        {
            
            MakeSpeed = Random.Range(6, 8);
            
        }
        else if (SYTimer > 50 && SYTimer <= 80)
        {
            
            MakeSpeed = 5;
            MakeSpeed = Random.Range(3, 7);
            
        }
        else if (SYTimer > 80 && SYTimer <= 100)
        {
            
            MakeSpeed = 3;
            MakeSpeed = Random.Range(2, 8);
            
        }

        
    }


 
    IEnumerator MakeCoin()
    {
        while (true)
        {
            
            Instantiate(Coin, new Vector3(17, Random.Range(2, -3), -3), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator MakeBee()
    {
        while (true)
        {
            Instantiate(Bee, new Vector3(17, Random.Range(3, -5), 15), Quaternion.identity);
            yield return new WaitForSeconds(MakeSpeed);
            
        }
    }
    IEnumerator MakeBird()
    {
        while (true)
        {
            Instantiate(Bird, new Vector3(17, Random.Range(3, -5), 15), Quaternion.identity);
            yield return new WaitForSeconds(MakeSpeed);
        }
    }
    IEnumerator MakeBlock()
    {
        
        while (true)
        {
            RandomBlock = Random.Range(1, 5);
            if (RandomBlock == 1)
            {
                int B = Random.Range(0, 4);
                if (B == 1)
                {
                    Instantiate(upBlock, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);
                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 2)
                {
                    Instantiate(upBlock, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);

                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 3)
                {

                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
            }
            else if (RandomBlock == 2)
            {
                int B = Random.Range(0, 4);
                if (B == 1)
                {
                    Instantiate(upBlock1, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);
                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 2)
                {
                    Instantiate(upBlock1, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);

                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 3)
                {

                    Instantiate(DownBlock1, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
            }
            else if (RandomBlock == 3)
            {
                int B = Random.Range(0, 4);
                if (B == 1)
                {
                    Instantiate(upBlock2, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);
                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 2)
                {
                    Instantiate(upBlock2, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);

                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 3)
                {

                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
            }
            else if (RandomBlock == 4)
            {
                int B = Random.Range(0, 4);
                if (B == 1)
                {
                    Instantiate(upBlock, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);
                    Instantiate(DownBlock1, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 2)
                {
                    Instantiate(upBlock2, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);

                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 3)
                {

                    Instantiate(DownBlock1, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
            }
            else if (RandomBlock == 5)
            {
                int B = Random.Range(0, 4);
                if (B == 1)
                {
                    Instantiate(upBlock1, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);
                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 2)
                {
                    Instantiate(upBlock, new Vector3(17, Random.Range(4, 6), 0), Quaternion.identity);

                    yield return new WaitForSeconds(MakeSpeed);
                }
                else if (B == 3)
                {

                    Instantiate(DownBlock, new Vector3(17, Random.Range(-4, -6), 0), Quaternion.identity);
                    yield return new WaitForSeconds(MakeSpeed);
                }
            }
            
        }
    }
    
    IEnumerator MakeClound1()
    {
        while (true)
        {
            RandomeCSpace = Random.Range(1,14);
            RandomeCSpace2 = Random.Range(16, 18);
            RandomCloud = Random.Range(1, 5);
            if (RandomCloud == 1)
            {
                Instantiate(Clound1, new Vector3(17, Random.Range(2, -6), RandomeCSpace), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(3, 8));
            }
            if (RandomCloud == 2)
            {
                Instantiate(Clound2, new Vector3(17, Random.Range(2, -6), RandomeCSpace2), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(3, 8));
            }
            if (RandomCloud == 3)
            {
                Instantiate(Clound3, new Vector3(17, Random.Range(2, -6), RandomeCSpace), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(3, 8));
            }
            if (RandomCloud == 4)
            {
                Instantiate(Clound4, new Vector3(17, Random.Range(2, -6), RandomeCSpace2), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(3, 8));
            }
            if (RandomCloud == 5)
            {
                Instantiate(Clound5, new Vector3(17, Random.Range(2, -6), RandomeCSpace), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(3, 8));
            }
        }
        
    }
    IEnumerator MakeIce()
    {
        while (true)
        {
            RandomIce = Random.Range(1, 5);
            if (RandomIce == 1)
            {
                Instantiate(Ice1, new Vector3(17, Random.Range(2, -4), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }
            else if (RandomIce == 2)
            {
                Instantiate(Ice2, new Vector3(17, Random.Range(2, -4), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }
            else if (RandomIce == 3)
            {
                Instantiate(Ice3, new Vector3(17, Random.Range(2, -4), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }
            else if (RandomIce == 4)
            {
                Instantiate(Ice3, new Vector3(17, Random.Range(2, -4), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }

        }

    }
    IEnumerator MakeTaba()
    {
        while (true)
        {
            Instantiate(Tabasgo, new Vector3(17, Random.Range(2, -4), -3), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(10, 20));
        }

    }
    IEnumerator MakeDonut()
    {
        while (true)
        {
            RandomDonut = Random.Range(1, 3);
            if (RandomDonut == 1)
            {
                Instantiate(Donut1, new Vector3(17, Random.Range(2, -2), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }
            else if (RandomDonut == 2)
            {
                Instantiate(Donut2, new Vector3(17, Random.Range(2, -2), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }
            else if (RandomDonut == 3)
            {
                Instantiate(Donut3, new Vector3(17, Random.Range(2, -2), -3), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(10, 20));
            }

        }

    }
    public void GameStop()
    {
        StartCoroutine(MakeCoin());
        StartCoroutine(MakeBee());
        StartCoroutine(MakeBird());
        StartCoroutine(MakeBlock());
        StartCoroutine(MakeClound1());
        StartCoroutine(MakeIce());
        StartCoroutine(MakeTaba());
        StartCoroutine(MakeDonut());
    }

}
