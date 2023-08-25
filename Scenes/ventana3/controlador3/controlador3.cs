using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador3 : MonoBehaviour
{
    managerprincipal managerprincipal;
    vista3 vista3;
    // Start is called before the first frame update
    public void inicializar3()
    {
        managerprincipal = GameObject.FindGameObjectWithTag("manager_1").GetComponent<managerprincipal>();
        vista3 = GameObject.FindGameObjectWithTag("ventana_3").GetComponent<vista3>();
        vista3.inicializar_vist3();
    }

    public void pagi_click_controler3( ref int pagina_cont)
    {
        Debug.Log("Controlador: Numero de ventana es: " + pagina_cont);
        managerprincipal.pagina_sig(ref pagina_cont);
    }
}

