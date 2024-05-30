using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class loginManager : MonoBehaviour
{
    public string Contraseña = "Pepe";
    public InputField Ingresar_Contraseña;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChequearContraseña()
    {
        if (Ingresar_Contraseña.text == Contraseña)
        {
            Debug.Log("Acces Granted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }

}
