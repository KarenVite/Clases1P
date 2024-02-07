using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> prefabs; //El objecto que será instanciado
    public float tiempoEntreInstancias = 3f; //Tiempo entre cada instancia
    public float radioSpawn = 5f; //Radio alrededor del spawner donde se instanciarán objetos

    [Header("DEBUG")]
    public Vector3 SpawnerPosition;
    public Color color;


    // Start is called before the first frame update
    void Start()
    {
        //Inicio un ciclo que instancia objetos repetidamente
        InvokeRepeating("InstanciarObjetoAleatorio", 0f, tiempoEntreInstancias);
       
    }

    private void InstanciarObjetoAleatorio()
    {
        //Genera una posición aleatoria dentro del radio especificado
        Vector3 posicionAleatoria = Random.insideUnitCircle * radioSpawn;
        posicionAleatoria.z = 0f; //Asegura que la posición está en el plano XY

        //Instancia el objeto en la posición generada
        GameObject RandomObj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject nuevoObjeto = Instantiate(RandomObj, SpawnerPosition + posicionAleatoria, Quaternion.identity);

        //Asigna un color aleatorio al material del sprite
        SpriteRenderer spriteRenderer = nuevoObjeto.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        nuevoObjeto.transform.parent = transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, radioSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
