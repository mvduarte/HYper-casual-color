using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerColor : MonoBehaviour
{
    public Image Bt;
    private float timerTroca;
    public Color cor;
    // Start is called before the first frame update
    void Start()
    {
        Bt = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        cor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
        timerTroca += Time.deltaTime;
        if (timerTroca >= Random.Range(0.2f, 0.8f))
        {
            Bt.color = cor;
            timerTroca = 0;
        }
    }
}
