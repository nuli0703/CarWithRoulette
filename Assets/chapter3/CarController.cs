using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    public float speed = 0;
    Vector2 startPos;
    public float swipeLength;
    GameObject camera;


    CarGameManager carGameManager;

    GameObject distanceText;
    public RouletteController rouletteController;


    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        carGameManager = camera.GetComponent<CarGameManager>();



        distanceText = GameObject.Find("LIFE");
    }

    // Update is called once per frame
    void Update()
    {


        if (rouletteController.life > 0)
        {
            if (rouletteController.RouletteTime == true)
        {
            

                if (carGameManager.status)
                {
                    if (speed < 0.01f)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            startPos = Input.mousePosition;
                        }
                        else if (Input.GetMouseButtonUp(0))
                        {
                            Vector2 endPos = Input.mousePosition;
                            swipeLength = endPos.x - startPos.x;
                            speed = swipeLength / 1500.0f;
                            

                            GetComponent<AudioSource>().Play();
                            rouletteController.life--;
                        }
                    }

                    if (rouletteController.life == 0)
                     {
                        carGameManager.status = false;
                         distanceText.GetComponent<TMP_Text>().text = "Lose..";
                     }
                }
            }
        }

        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
