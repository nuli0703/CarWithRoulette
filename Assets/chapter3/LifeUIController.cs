using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUIController : MonoBehaviour
{
    private TextMeshProUGUI lifeText;

    // Start is called before the first frame update
    void Start()
    {
        // LifeText 오브젝트의 TextMeshProUGUI 컴포넌트 가져오기
        lifeText = GetComponent<TextMeshProUGUI>();

        // 텍스트 초기화
        lifeText.text = "LIFE : 6";
    }

    public void UpdateLife(int life)
    {
        // 텍스트 업데이트
        lifeText.text = "LIFE : " + life;
    }
}
