using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHeroe;
    public Image BarraHPHeroe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //muestro en texto el hp
        EtiquetaHeroe.text = Heroe.hp + "/" + Heroe.hpMax;

        float porcentajeHPHeroe = Heroe.hp / (float)Heroe.hpMax;
        BarraHPHeroe.fillAmount = porcentajeHPHeroe;
    }
}
