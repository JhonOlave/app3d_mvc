using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vista3 : MonoBehaviour
{
    // Start is called before the first frame update
   controlador3 controlador3;
    public void inicializar_vist3()
    {
      controlador3 = GameObject.FindGameObjectWithTag("ventana_3").GetComponent<controlador3>();
    }

    public void pagi_click3(int pagina)
    {
        Debug.Log("Numero de ventana es: " + pagina);
        controlador3.pagi_click_controler3(ref pagina);
    }
}
