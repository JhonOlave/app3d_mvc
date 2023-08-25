using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerprincipal : MonoBehaviour
{
    GameObject ventana1p;
    GameObject ventana2p;
    GameObject ventana3p;

    controlador1 controlador1;
    controlador2 controlador2;
    controlador3 controlador3;
    // Start is called before the first frame update
    void Start()
    {
        ventana1p = GameObject.FindGameObjectWithTag("ventana_1");
        ventana2p = GameObject.FindGameObjectWithTag("ventana_2");
        ventana3p = GameObject.FindGameObjectWithTag("ventana_3");

        controlador1 = GameObject.FindGameObjectWithTag("ventana_1").GetComponent<controlador1>();
        controlador2 = GameObject.FindGameObjectWithTag("ventana_2").GetComponent<controlador2>();
        controlador3 = GameObject.FindGameObjectWithTag("ventana_3").GetComponent<controlador3>();

        controlador1.inicializar();
        controlador2.inicializar2();
        controlador3.inicializar3();

        int n = 0;
        pagina_sig(ref n);
    }

    // Update is called once per frame
    public void pagina_sig(ref int num)
    {
        descativar_venta();
        switch (num)
        {
          case 0:
            ventana1p.SetActive(true);
          break;
          case 1:
            ventana2p.SetActive(true);
          break;
          case 2:
            ventana3p.SetActive(true);
          break;
          default:
          Debug.Log("NO EXIStE");
          break;
        }
    }

    void descativar_venta()
    {
        ventana1p.SetActive(false);
        ventana2p.SetActive(false);
        ventana3p.SetActive(false);
    }
}
