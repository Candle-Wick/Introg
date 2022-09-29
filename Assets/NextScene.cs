using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{

    Button nexty;
    GameObject m_camera;
    GameObject m_button;
    int pos;
    // Start is called before the first frame update
    void Start()
    {
        m_camera = GameObject.Find("/Main Camera");
        m_button = GameObject.Find("Button");
        nexty = m_button.GetComponent<Button>();
        nexty.onClick.AddListener(changeView);
        pos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeView()
    {   
        pos = (pos + 1) % 3;
        Text m_text = m_button.GetComponentInChildren<Text>();
        switch (pos)
        {
            case 0:
                m_camera.transform.position = new Vector3(3.79f,4.72f,-10);
                m_text.text = "Bigger!";
                break;
            case 1:
                m_camera.transform.position = new Vector3(1.30999994f,31.8799992f,-621.719971f);
                m_text.text = "Bigger!!";
                break;
            case 2:
                m_camera.transform.position = new Vector3(-5.80000019f,33.7999992f,-951);
                m_text.text = "Too Big!";
                break;

            default:
                m_camera.transform.position = new Vector3(3.79f,4.72f,-10);
                break;
        }


    }


}
