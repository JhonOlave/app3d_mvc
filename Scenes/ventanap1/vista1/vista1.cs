using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vista1 : MonoBehaviour
{
   // Start is called before the first frame update
   controlador1 controlador1;
     public void inicializar_vist()
    {
      controlador1 = GameObject.FindGameObjectWithTag("ventana_1").GetComponent<controlador1>();
    }

    public void pagi_click(int pagina)
    {
        Debug.Log("Numero de ventana es: " + pagina);
        controlador1.pagi_click_controler(ref pagina);
    }
}
