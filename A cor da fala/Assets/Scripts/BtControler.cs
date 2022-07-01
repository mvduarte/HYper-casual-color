using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtControler : MonoBehaviour
{
    private Main main;
    private GameControler gc;
    public Color aleColor;
    // Start is called before the first frame update
    void Start()
    {
        main = FindObjectOfType(typeof(Main))as Main;
        gc = FindObjectOfType(typeof(GameControler)) as GameControler;
        aleColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        aleColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
    }
    public void CheckColor()
    {
        if (gameObject.GetComponent<Image>().color == main.mainColor)
        {
            gc.points++;
            main.SetColor();
        }
        else
        {
            main.SetColor();
        }
    }
    public void AleColor()
    {
        gameObject.GetComponent<Image>().color = aleColor;
    }
}
