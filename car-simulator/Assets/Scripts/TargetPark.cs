using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPark : MonoBehaviour
{
    public GameObject sukses;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Misi Berhasil");
            sukses.SetActive(true);
        }
    }
}
