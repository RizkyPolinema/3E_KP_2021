using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ini adalah prefab untuk memunculkan objek virus secara random, baik itu diposisi mana maupun kapan waktunya
public class ShowVirus : MonoBehaviour
{
    public GameObject virus;
    public float TimeMin, TimeMax;
    public float MinPos, MaxPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowingVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowingVirus() //ini untuk memunculkan dimana letak virus dan kapan virus itu akan me-respawn atau 
    //mengulang kembali pada posisi dan waktu yang random atau beracakan
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(MinPos, MaxPos), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(TimeMin, TimeMax));
        StartCoroutine(ShowingVirus());
    }
}
