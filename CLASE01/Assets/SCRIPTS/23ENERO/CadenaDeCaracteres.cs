using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public GameObject bolita;
    public string data = "x:2, y:5, z:8";
    public Vector3 pos;
    

    // Start is called before the first frame update
    void Start()
    {
        //Recorrer todo nuestro string = "x:2, y:5, z:8"
        for (int i = 0; i < data.Length; i++)
        {
            //2. Revisaremos si el valor en el indeice (data[i]), is igual a 'x'
            if (data[i] == 'x')
            {
                //3. Si, si es el valor, transformaremos el caracter(data[i+2]) a entero
                int x = (int)char.GetNumericValue(data[i + 2]);

                //4. Almacenamos la información de x en nuestro vectr pos
                pos = new Vector3(x, 0, 0);
            }

            if (data[i] == 'y')
            {
                int y = (int)char.GetNumericValue(data[i + 2]);
                pos = new Vector3(y, 0, 0);
            }

            if (data[i] == 'z')
            {
                int z = (int)char.GetNumericValue(data[i + 2]);
                pos = new Vector3(z, 0, 0);
            }
        }

        Instantiate(bolita, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
