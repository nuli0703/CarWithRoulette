using System.Collections;
using System.Collections.Generic;

using System.Globalization;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    
    float rotSpeed = 0; // 회전속도
    public int life = 0; // 목숨
    public bool RouletteTime = false ;

    CarGameManager carGameManager; // UIController 스크립트

    void Start()
    {

        carGameManager = GameObject.Find("LIFE").GetComponent<CarGameManager>();

        // 목숨 초기화
        
    }


    // Start is called before the first frame update
    void Update()
    {
        if (RouletteTime == false)
        {
            if (Input.GetMouseButton(0))
        {
            Debug.Log("마우스 클릭 입력됨");
            rotSpeed += 10;
        }

        transform.Rotate(0, 0, rotSpeed); // 회전속도만큼 룰렛을 회전시킴
        rotSpeed *= 0.992f;

        
            if (rotSpeed < 0.01f && rotSpeed != 0)
            {
                float zRotation = transform.rotation.eulerAngles.z;

                if (zRotation >= -30 && zRotation < 30)
                {
                    Debug.Log("운수 나쁨 -2");
                    life = 2;
                    RouletteTime = true;
                }
                else if (zRotation >= 30 && zRotation < 90)
                {
                    Debug.Log("운수 대통 -6");
                    life = 6;
                    RouletteTime = true;
                }
                else if (zRotation >= 90 && zRotation < 150)
                {
                    Debug.Log("운수 매우나쁨 -1");
                    life = 1;
                    RouletteTime = true;
                }
                else if (zRotation >= 150 && zRotation < 210)
                {
                    Debug.Log("운수 보통 -4");
                    life = 4;
                    RouletteTime = true;
                }
                else if (zRotation >= 210 && zRotation < 270)
                {
                    Debug.Log("운수 조심 - 3");
                    life = 3;
                    RouletteTime = true;
                }
                else if (zRotation >= 270 && zRotation < 330)
                {
                    Debug.Log("운수 좋음 - 5");
                    life = 5;
                    RouletteTime = true;
                }

                life = Mathf.Clamp(life, 0, 6);

                Debug.Log("Life: " + life);

                rotSpeed = 0;
            }

        }
    }

}
