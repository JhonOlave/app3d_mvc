using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador1 : MonoBehaviour
{
    managerprincipal managerprincipal;
    vista1 vista1;
    // Start is called before the first frame update
    public void inicializar()
    {
       
        managerprincipal = GameObject.FindGameObjectWithTag("manager_1").GetComponent<managerprincipal>();
        vista1 = GameObject.FindGameObjectWithTag("ventana_1").GetComponent<vista1>();
        vista1.inicializar_vist();
    }

    public void pagi_click_controler( ref int pagina_cont)
    {
        Debug.Log("Controlador: Numero de ventana es: " + pagina_cont);
        managerprincipal.pagina_sig(ref pagina_cont);
    }
}
