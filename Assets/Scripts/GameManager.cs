using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float hpMax=1000, hp=1000,hpMaxE=1000,hpE=1000;
    public Image hpBar,hpBarE;
    public static GameManager inst;
    public int enemigosDerrotados;
    public Text enemigosDerrotadosText;
    enum TYPOS
    {
        espada,caster,alchemist,shield
    }
    private void Awake()
    {
        enemigosDerrotadosText= GameObject.Find("EnemigosTexto").GetComponent<Text>();
        hpBar = GameObject.Find("hpint").GetComponent<Image>();
        hpBarE = GameObject.Find("hpintE").GetComponent<Image>();
        if (inst==null)
        {
            inst = this;
        }        
    }
    private void Update()
    {
        enemigosDerrotadosText.text = enemigosDerrotados.ToString();
        hpBar.fillAmount = hp / hpMax;
        hpBarE.fillAmount = hpE / hpMaxE;
    }                    
}
