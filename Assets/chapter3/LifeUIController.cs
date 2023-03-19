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
        // LifeText ������Ʈ�� TextMeshProUGUI ������Ʈ ��������
        lifeText = GetComponent<TextMeshProUGUI>();

        // �ؽ�Ʈ �ʱ�ȭ
        lifeText.text = "LIFE : 6";
    }

    public void UpdateLife(int life)
    {
        // �ؽ�Ʈ ������Ʈ
        lifeText.text = "LIFE : " + life;
    }
}
