using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    public int avgFrameRate;
    public TextMeshProUGUI display_Text;
    public float timer;

    public bool fps60;
    public bool fps120;
    public bool fps144;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;        
    }

    public void Update()
    {
        if(fps60 == true)
        {
            Application.targetFrameRate = 60;
        }
        else if(fps120 == true)
        {
            Application.targetFrameRate = 120;
        }
        else if(fps144 == true)
        {
            Application.targetFrameRate = 144;
        }
        else
        {
            Application.targetFrameRate = 1000;
        }


        //Show Fps Counter on Screen
        timer += 1 * Time.deltaTime;
        if(timer >= 0.2)
        {
            float current = 0;
            current = (int)(1f / Time.unscaledDeltaTime);
            avgFrameRate = (int)current;
            display_Text.text = avgFrameRate.ToString() + " FPS";
            timer = 0;
        }
        
    }


}
