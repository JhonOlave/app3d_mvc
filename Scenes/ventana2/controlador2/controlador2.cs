using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador2 : MonoBehaviour
{
    managerprincipal managerprincipal;
    vista2 vista2;
    // Start is called before the first frame update
    public void inicializar2()
    {
        managerprincipal = GameObject.FindGameObjectWithTag("manager_1").GetComponent<managerprincipal>();
        vista2 = GameObject.FindGameObjectWithTag("ventana_2").GetComponent<vista2>();
        vista2.inicializar_vist2();
    }

    public void pagi_click_controler2( ref int pagina_cont)
    {
        Debug.Log("Controlador: Numero de ventana es: " + pagina_cont);
        managerprincipal.pagina_sig(ref pagina_cont);
    }
}
