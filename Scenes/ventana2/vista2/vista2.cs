using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vista2 : MonoBehaviour
{
   // Start is called before the first frame update
   controlador2 controlador2;
    public void inicializar_vist2()
    {
      controlador2 = GameObject.FindGameObjectWithTag("ventana_2").GetComponent<controlador2>();
    }

    public void pagi_click2(int pagina)
    {
        Debug.Log("Numero de ventana es: " + pagina);
        controlador2.pagi_click_controler2(ref pagina);
    }
}

