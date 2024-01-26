using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayStudy : MonoBehaviour
{
    public Text ui;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        //1<<6����1����6λ������һλ�Ϳ��Լ���ĸ��㼶
        LayerMask layerMask = 1 << 8;
        if (Physics.Raycast(ray, out hitInfo, 100, layerMask))
        {
            text=hitInfo.collider.GetComponent<Text>();
            ui.text = text.text;
        }
        else
        {
            ui.text = "";
        }
    }
}
