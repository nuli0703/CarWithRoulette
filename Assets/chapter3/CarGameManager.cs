using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarGameManager : MonoBehaviour
{
    CarController carController;

    GameObject car;
    GameObject flag;
    GameObject distanceText;
    public bool status = true;
    private TextMeshProUGUI lifeText;
    public RouletteController rouletteController;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("LIFE");

        carController = car.GetComponent<CarController>();

        

        // 텍스트 초기화
        
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if (status)
        {
            distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m";
            if (length < 0)
            {
                distanceText.GetComponent<TMP_Text>().text = "Lose..";
                status = false;
            }
            else if (length <= 0.5f && carController.speed < 0.01f)
            {
                distanceText.GetComponent<TMP_Text>().text = "Win!!";
                status = false;
            }
        }
        
    }

}
