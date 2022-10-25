using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtControler : MonoBehaviour
{
    private Main main;
    private GameControler gc;
    public Color aleColor;
    private float timer;
    private bool act= true;
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
        timer += Time.deltaTime;
        if (timer >= 0.5f& act)
        {
            main.SetColor();
            act = false;
        }
        aleColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
    }
    public void CheckColor()
    {
        if (gameObject.GetComponent<Image>().color == main.mainColor)
        {
            main.timeFinal += 5;
            gc.points++;
            main.SetColor();
        }
        else
        {
            main.timeFinal -= 5;
            main.SetColor();
        }
    }
    public void AleColor()
    {
        gameObject.GetComponent<Image>().color = aleColor;
        gameObject.GetComponent<Image>().sprite = main.aleSprites[Random.Range(0,main.aleSprites.Length)];
    }
}
