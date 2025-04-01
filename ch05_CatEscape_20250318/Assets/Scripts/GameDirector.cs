using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGuage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.hpGuage = GameObject.Find("hpGuage");
    }

    public void DecreaseHp()
    {
        this.hpGuage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
